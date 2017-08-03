using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracking_System
{
    public partial class TProblemLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // if (!this.Page.User.Identity.IsAuthenticated)  // If username is not authenticated then it enters in.
             //   {
               //     FormsAuthentication.RedirectToLoginPage();
                //    return;
               // }
                btnCancel.Attributes.Add("onClick", "javascript:history.back(); return false;"); // 

                if (!IsPostBack) // "!IsPostBack" used to check whether the page is loaded for first time. When a form is posted (submitted) back to the same page it is called a post back. 
                {

                    
                    SqlDataAdapter da = new SqlDataAdapter("select * from UserRegistration where JobCategory='SME'", con);  // sqldataadapter is used to map the fields of data adapter to data source.
                    ddlSme.DataTextField = "EmployeeId"; // specifies which field from the DataSource to bind to the Text property
                    ddlSme.DataValueField = "EmployeeName"; //specifies which field from the DataSource to bind to the Value property
                    DataTable dt = new DataTable();  //Datatable is used to store data in memory
                    da.Fill(dt);  // Whatever data fetched using dataadapter that is matched and filled into datatable
                    ddlSme.DataSource = dt; //binding a list of items to dropdownlist
                    ddlSme.DataBind();
                    ddlSme.Items.Insert(0, "--Select--"); // Adding list items manually

                    SqlDataAdapter dc = new SqlDataAdapter("select * from UserRegistration where JobCategory='Agent'", con);
                    ddlAgName.DataTextField = "EmployeeId";
                    ddlAgName.DataValueField = "EmployeeName";
                    DataTable dt1 = new DataTable();
                    dc.Fill(dt1);
                    ddlAgName.DataSource = dt1;
                    ddlAgName.DataBind();
                    ddlAgName.Items.Insert(0, "--Select--");

                    SqlDataAdapter de = new SqlDataAdapter("select * from UserRegistration where JobCategory='Supervisor'", con);
                    ddlSvID.DataTextField = "EmployeeId";
                    ddlSvID.DataValueField = "EmployeeName";
                    DataTable dt2 = new DataTable();
                    de.Fill(dt2);
                    ddlSvID.DataSource = dt2;
                    ddlSvID.DataBind();
                    ddlSvID.Items.Insert(0, "--Select--");

                }
            }
            catch (Exception ex)
            {
                string script = ex.Message;
                //script += "var f='" + Session["flag"].ToString() + "';\n";
                //script += "if (f == 'L')\n";
                //script += "location.href='TSMEScreen.aspx';\n";

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", script, true);
            }
        }
        public void logoff_Click(object sender, EventArgs e)
        {
            Logout lg = new Logout();
            lg.Session_Start(sender, e);


            //if (HttpContext.Current.Request.IsAuthenticated)
            //{

            //    //old authentication, kill it
            //    FormsAuthentication.SignOut();
            //    //or use Response.Redirect to go to a different page
            //    FormsAuthentication.RedirectToLoginPage("Session=Expired");
            //    HttpContext.Current.Response.End();
            //}
        }
        protected void btnCreateSr_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
                SqlCommand cmd = new SqlCommand("insert into tblLogs values(@LogDate,@ProblemCategory,@ProblemDescription,@SupervisorId,@AgentId,@WorkStationNo,@SmeId,@ProblemSeviority,@CurrentStatus,@Resolution,@ProposedStaus)", con); //specify what type of interaction you want to perform with a database.
                cmd.Parameters.Add(new SqlParameter("@LogDate", System.DateTime.Now.Date.ToShortDateString())); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@ProblemCategory", ddlPCategory.SelectedItem.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@ProblemDescription", txtPDescription.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@SupervisorId", ddlSvID.SelectedItem.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@AgentId", Session["EID"].ToString())); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@WorkStationNo", txtWorkStationNo.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@SmeId", ddlSme.SelectedItem.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@ProblemSeviority", ddlPSiviority.SelectedItem.Text)); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@CurrentStatus", "")); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@Resolution", "")); // Mapping GUI field to database field.
                cmd.Parameters.Add(new SqlParameter("@ProposedStaus", "")); // Mapping GUI field to database field.
                con.Open(); //To insert data we need to open connection for database
                int i = cmd.ExecuteNonQuery(); //used for executing statements that do not return result sets (ie. statements like insert data , update data etc.) .
                if (i > 0)
                {
                    //lblStatus.Text = "Submitted Successfully";
                    string toMail = (string)(Session["EmailId"]); // assigning email id that is stored in session.
                    string str = "";

                    Boolean state = false;
                    string suprvMail = string.Empty;
                    string smeMail = string.Empty;

                    string sqlSelect = "select EmailId from UserRegistration where EmployeeId='" + ddlSvID.SelectedItem.Text + "'";
                    SqlCommand Comm = new SqlCommand(sqlSelect, this.con);
                    object result = Comm.ExecuteScalar(); // Executes query here in case its sqlselect and it returns first column of the first row remaining columns or rows are ignored.
                    if (result != null)
                    {
                        suprvMail = Convert.ToString(result);
                    }

                    string sqlSelect1 = "select EmailId from UserRegistration where EmployeeId='" + ddlSme.SelectedItem.Text + "'";
                    SqlCommand Comm1 = new SqlCommand(sqlSelect1, this.con);
                    object result1 = Comm1.ExecuteScalar();
                    if (result1 != null)
                    {
                        smeMail = Convert.ToString(result1);
                    }

                    //string sqlSelect1 = "select AgentId from tblLogs where LogNo='" + ddlLogs.SelectedItem.Text + "'";
                    //SqlCommand Comm1 = new SqlCommand(sqlSelect1, this.con);
                    //object result1 = Comm1.ExecuteScalar();
                    //if (result1 != null)
                    //{
                    //    string sqlSelect2 = "select EmailId from UserRegistration where EmployeeId='" + result1 + "'";
                    //    SqlCommand Comm2 = new SqlCommand(sqlSelect2, this.con);
                    //    object result2 = Comm2.ExecuteScalar();
                    //    agentMail = Convert.ToString(result2);
                    //}
                    //if (right (txtfrom .Text ,9)=="gmail.com")

                    //{

                    str = "smtp.gmail.com";

                    state = true;

                    //}

                    //else if (right (txtfrom .Text ,9)=="yahoo.com")

                    //{

                    //     str = "smtp.mail.yahoo.com";

                    //      state = false ;

                    //}



                    System.Net.Mail.MailAddress From = new System.Net.Mail.MailAddress("prblmtracking@gmail.com");

                    System.Net.Mail.MailAddress To = new System.Net.Mail.MailAddress(toMail);

                    System.Net.Mail.MailAddress ccSup = new System.Net.Mail.MailAddress(suprvMail);

                    System.Net.Mail.MailAddress ccSme = new System.Net.Mail.MailAddress(smeMail);

                    System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage(From, To);

                    System.Net.Mail.MailMessage supMessage = new System.Net.Mail.MailMessage(From, ccSup);

                    System.Net.Mail.MailMessage smeMessage = new System.Net.Mail.MailMessage(From, ccSme);

                    Message.Subject = "Priority " + ddlPSiviority.SelectedItem.Text;

                    supMessage.Subject = "Priority " + ddlPSiviority.SelectedItem.Text;

                    smeMessage.Subject = "Priority " + ddlPSiviority.SelectedItem.Text;

                    Message.Body = "Problem created and reported to agent " + txtAgName.Text + " with problem description " + txtPDescription.Text + " on " + System.DateTime.Now.Date.ToShortDateString();

                    supMessage.Body = "Problem created and reported to agent " + txtAgName.Text + " with problem description " + txtPDescription.Text + " on " + System.DateTime.Now.Date.ToShortDateString();

                    smeMessage.Body = "Problem created and reported to agent " + txtAgName.Text + " with problem description " + txtPDescription.Text + " on " + System.DateTime.Now.Date.ToShortDateString();


                    // Message.Attachments.Add(new System.Net.Mail.Attachment(openFileDialog1.FileName.ToString()));

                    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(str); //creating object which allows sending mail by using smtp

                    client.EnableSsl = Convert.ToBoolean(state); 

                    client.Credentials = new System.Net.NetworkCredential("prblmtracking@gmail.com", "trackingsystem");

                    client.Send(Message);

                    client.Send(supMessage);

                    client.Send(smeMessage);

                    //Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Submitted Successfully');", true); 
                    btnRedirect_Click();

                }
                else
                {
                    lblStatus.Text = "please try again";
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }


        protected void btnRedirect_Click()
        {
            try
            {

                // string message = "Submitted Sucessfully";

                string script = "alert('Problem Submitted and Mail sent sucessfully');\n";
                //script += "var f='" + Session["flag"].ToString() + "';\n";
                //script += "if (f == 'L')\n";
                script += "location.href='TProblemLogin.aspx';\n";

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", script, true); // this is used to dispaly message box.
            }
            catch (Exception ex)
            {
                string script = ex.Message;
                //script += "var f='" + Session["flag"].ToString() + "';\n";
                //script += "if (f == 'L')\n";
                //script += "location.href='TSMEScreen.aspx';\n";

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", script, true);
            }
        }






        protected void ddlSme_SelectedIndexChanged(object sender, EventArgs e)  // dropdownlist triggered on iindex changed
        {
            txtSmeName.Text = ddlSme.SelectedItem.Value;  // Value corresponding to dropdownlist to be updated into textbox(ex:if we select supervisor id then corresponding name will be updated in textbox).
        }

        protected void ddlSvID_SelectedIndexChanged(object sender, EventArgs e) // dropdownlist triggered on iindex changed
        {
            txtSvName.Text = ddlSvID.SelectedItem.Value; // Value corresponding to dropdownlist to be updated into textbox(ex:if we select supervisor id then corresponding name will be updated in textbox).
        }

        protected void ddlAgName_SelectedIndexChanged(object sender, EventArgs e) // dropdownlist triggered on iindex changed
        {
            txtAgName.Text = ddlAgName.SelectedItem.Value; // Value corresponding to dropdownlist to be updated into textbox(ex:if we select supervisor id then corresponding name will be updated in textbox).
        }


        //protected void btnNotification_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        //    con.Open();

        //    string toMail = (string)(Session["EmailId"]);
        //     string str="";

        //    Boolean  state=false;



        //    //if (right (txtfrom .Text ,9)=="gmail.com")

        //    //{

        //         str = "smtp.gmail.com";

        //         state =true ;

        //    //}

        //    //else if (right (txtfrom .Text ,9)=="yahoo.com")

        //    //{

        //    //     str = "smtp.mail.yahoo.com";

        //    //      state = false ;

        //    //}



        //    System.Net.Mail.MailAddress From = new System.Net.Mail.MailAddress("prblmtracking@gmail.com");

        //    System.Net.Mail.MailAddress To = new System.Net.Mail.MailAddress(toMail);

        //    System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage(From, To);

        //    Message.Subject = "Priority " + ddlPSiviority.SelectedItem.Text;

        //    Message.Body = "Problem created and reported to agent " +txtAgName.Text+ " with problem description " +txtPDescription.Text+ " on " +System.DateTime.Now.Date.ToShortDateString();

        //   // Message.Attachments.Add(new System.Net.Mail.Attachment(openFileDialog1.FileName.ToString()));

        //    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(str);

        //    client.EnableSsl = Convert .ToBoolean (state );

        //    client.Credentials = new System.Net.NetworkCredential("prblmtracking@gmail.com", "trackingsystem");

        //    client.Send(Message);

        //    lblStatus.Text = "Mail sent successfully";

        //          }



        public string right(string param, int length)
        {

            string result = param.Substring(param.Length - length, length);

            return result;

        }
        //  }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtAgName.Text = string.Empty; // Clears textbox.
            txtPDescription.Text = string.Empty; // Clears textbox.
            txtSmeName.Text = string.Empty; // Clears textbox.
            txtSvName.Text = string.Empty; // Clears textbox.
            txtWorkStationNo.Text = string.Empty; // Clears textbox.
            ddlAgName.SelectedIndex = 0; // Sets the value of dropdown to --select-- as index 0 of dropdown list is --select--
            ddlPCategory.SelectedIndex = 0; // Sets the value of dropdown to --select-- as index 0 of dropdown list is --select--
            ddlPSiviority.SelectedIndex = 0; // Sets the value of dropdown to --select-- as index 0 of dropdown list is --select--
            ddlSme.SelectedIndex = 0; // Sets the value of dropdown to --select-- as index 0 of dropdown list is --select--
            ddlSvID.SelectedIndex = 0; // Sets the value of dropdown to --select-- as index 0 of dropdown list is --select--

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}