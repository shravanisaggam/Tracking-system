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
    public partial class TSMEScreen : System.Web.UI.Page
    {

        DataTable dtLogs = new DataTable();
        SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        DataRow[] selectedLog = new DataRow[0];
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // if (!this.Page.User.Identity.IsAuthenticated)
                //{
                //    FormsAuthentication.RedirectToLoginPage();
                //    return;
               // }
                if (User.IsInRole("Admin") || User.IsInRole("SME"))
                {
                    //if (!this.Page.User.Identity.IsAuthenticated)
                    //{
                    //    FormsAuthentication.RedirectToLoginPage();
                    //    return;
                    //}
                    btnCancel.Attributes.Add("onClick", "javascript:history.back(); return false;");
                    if (!IsPostBack)
                    {
                        try
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("select * from tblLogs where SmeId='" + Session["EID"].ToString() + "' and ProposedStaus='" + "" + "'", con);
                            con.Open();
                            cmd.Fill(dtLogs);
                            ddlLogs.DataTextField = "LogNo";
                            ddlLogs.DataSource = dtLogs;
                            ddlLogs.DataBind();
                            ddlLogs.Items.Insert(0, "--Select Log--");
                            //ddlLogs.Items.Add("select log");
                            ViewState["Logs"] = dtLogs;
                        }
                        catch (Exception ex)
                        {

                        }


                    }
                }
                else
                {
                    Logout lg = new Logout();
                    lg.Session_Start(sender, e);

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
        protected void ddlLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlLogs.SelectedItem.Text != "select log")
                {
                    dtLogs = (DataTable)ViewState["Logs"];
                    DataColumn logNo = new DataColumn();

                    selectedLog = dtLogs.Select("LogNo=" + ddlLogs.SelectedItem.Text + "");
                    txtSrDate.Text = selectedLog[0]["LogDate"].ToString();
                    txtPbSeviority.Text = selectedLog[0]["ProblemSeviority"].ToString();
                    txtPbCategory.Text = selectedLog[0]["ProblemCategory"].ToString();
                    txtCurrentStatus.Text = selectedLog[0]["CurrentStatus"].ToString();
                    txtProposedStatus.Text = selectedLog[0]["ProposedStaus"].ToString();
                    txtPbDescription.Text = selectedLog[0]["ProblemDescription"].ToString();
                    txtSupervisorid.Text = selectedLog[0]["SupervisorId"].ToString();
                    //txtSupervisorName.Text = selectedLog[0][""].ToString();
                    txtResoution.Text = selectedLog[0]["Resolution"].ToString();
                    txtSME.Text = selectedLog[0]["SmeId"].ToString();

                    //SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
                   

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

        protected void btnUpdateSr_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE [tblLogs] SET CurrentStatus='" + txtCurrentStatus.Text + "',ProposedStaus='" + txtProposedStatus.Text + "',Resolution='" + txtResoution.Text + "' where LogNo='" + ddlLogs.SelectedItem.Text + "'";
                con.Open();
                SqlCommand cmd1 = new SqlCommand(sql, con);

                //cmd1.Parameters.AddWithValue("@CurrentStatus", txtCurrentStatus.Text);
                //cmd1.Parameters.AddWithValue("@ProposedStaus", txtProposedStatus);
                //cmd1.Parameters.AddWithValue("@Resolution", txtResoution.Text);
                //cmd1.Parameters.AddWithValue("@LogNo", ddlLogs.SelectedItem.Text);
                cmd1.ExecuteNonQuery();
                string toMail = (string)(Session["EmailId"]);
                string str = "";
                string ccMail = string.Empty;
                string agentMail = string.Empty;



                string sqlSelect = "select EmailId from UserRegistration where EmployeeId='" + txtSupervisorid.Text + "'";
SqlCommand Comm = new SqlCommand(sqlSelect, this.con);
object result = Comm.ExecuteScalar();
if (result != null)
{
     ccMail = Convert.ToString(result);
}
//dtLogs = (DataTable)ViewState["Logs"];
//DataColumn logNo = new DataColumn();
//LogNo = " + ddlLogs.SelectedItem.Text + ";
string sqlSelect1 = "select AgentId from tblLogs where LogNo='" + ddlLogs.SelectedItem.Text + "'";
SqlCommand Comm1 = new SqlCommand(sqlSelect1, this.con);
object result1 = Comm1.ExecuteScalar();
if (result1 != null)
{
    string sqlSelect2 = "select EmailId from UserRegistration where EmployeeId='" + result1 + "'";
    SqlCommand Comm2 = new SqlCommand(sqlSelect2, this.con);
    object result2 = Comm2.ExecuteScalar();
    agentMail = Convert.ToString(result2);
}
  // DateTime dtResult = Convert.ToDateTime(result);

                //SqlDataAdapter da = new SqlDataAdapter("select EmailId from UserRegistration where id='" + txtSupervisorid.Text + "'", con);
               
                //ddlSme.DataTextField = "EmployeeId";
                //ddlSme.DataValueField = "EmployeeName";
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //ddlSme.DataSource = dt;
                //ddlSme.DataBind();
                //ddlSme.Items.Insert(0, "--Select--");

                Boolean state = false;



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

                System.Net.Mail.MailAddress cc = new System.Net.Mail.MailAddress(ccMail);
                System.Net.Mail.MailAddress cc1 = new System.Net.Mail.MailAddress(agentMail);

                System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage(From, To);
                System.Net.Mail.MailMessage ccMessage = new System.Net.Mail.MailMessage(From, cc);
                System.Net.Mail.MailMessage agentMessage = new System.Net.Mail.MailMessage(From, cc1);
                Message.Subject = "Log No " + ddlLogs.SelectedItem.Text + " Updated Successfully";
                ccMessage.Subject = "Log No " + ddlLogs.SelectedItem.Text + " Updated Successfully";
                agentMessage.Subject = "Log No " + ddlLogs.SelectedItem.Text + " Updated Successfully";
                Message.Body = "Status updated to " + txtCurrentStatus.Text + " at " + System.DateTime.Now.Date.ToShortDateString();
                ccMessage.Body = "Status updated to " + txtCurrentStatus.Text + " at " + System.DateTime.Now.Date.ToShortDateString();
                agentMessage.Body = "Status updated to " + txtCurrentStatus.Text + " at " + System.DateTime.Now.Date.ToShortDateString();
                // Message.Attachments.Add(new System.Net.Mail.Attachment(openFileDialog1.FileName.ToString()));

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(str);

                client.EnableSsl = Convert.ToBoolean(state);

                client.Credentials = new System.Net.NetworkCredential("prblmtracking@gmail.com", "trackingsystem");

                client.Send(Message);
                client.Send(ccMessage);
                client.Send(agentMessage);
                btnRedirect_Click();

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

        protected void btnRedirect_Click()
        {
            try
            {
                // string message = "Submitted Sucessfully";

                string script = "alert('Updated and Mail sent sucessfully');\n";
                //script += "var f='" + Session["flag"].ToString() + "';\n";
                //script += "if (f == 'L')\n";
                script += "location.href='TSMEScreen.aspx';\n";

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", script, true);
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


        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtCurrentStatus.Text = string.Empty;
                txtPbCategory.Text = string.Empty;
                txtPbDescription.Text = string.Empty;
                txtPbSeviority.Text = string.Empty;
                txtProposedStatus.Text = string.Empty;
                txtResoution.Text = string.Empty;
                txtSME.Text = string.Empty;
                txtSrDate.Text = string.Empty;
                txtSupervisorid.Text = string.Empty;
                ddlLogs.SelectedIndex = 0;
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}