using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Security;
using System.Text.RegularExpressions;


namespace Tracking_System
{

    public partial class TUserCreation : System.Web.UI.Page
    {

        DataTable dtLogs = new DataTable();
        //SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        SqlConnection con = new SqlConnection("Database=USER-PC;Initial Catalog=Tracking;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // if (!this.Page.User.Identity.IsAuthenticated) // Checks whether user is present or not
               // {
               //     FormsAuthentication.RedirectToLoginPage();
               //     return;
               // }
                if (User.IsInRole("Admin") || User.IsInRole("Supervisor")) // It checks whether user has permission to view this page or not(Here in this Admin and Supervisor only has permissions to view this page).
                {
                    //if (!this.Page.User.Identity.IsAuthenticated)
                    //{
                    //    FormsAuthentication.RedirectToLoginPage();
                    //    return;
                    //}
                    btnCancel.Attributes.Add("onClick", "javascript:history.back(); return false;"); // this is javascript which perform a step back operation.
                    if (!IsPostBack)
                    {
                        //where SmeId='" + Session["EID"].ToString() + "' and ProposedStaus='" + "" + "'
                        SqlDataAdapter cmd = new SqlDataAdapter("select * from aspnet_Roles", con);  //specify what type of interaction you want to perform with a database.
                        con.Open();  //To insert data we need to open connection for database
                        cmd.Fill(dtLogs); // Whatever data fetched using dataadapter that is matched and filled into datatable
                        ddlJobCategory.DataTextField = "RoleName";
                        ddlJobCategory.DataSource = dtLogs; //binding a list of items to dropdownlist
                        ddlJobCategory.DataBind();
                        ddlJobCategory.Items.Insert(0, "--Select Role--"); // Adding list items manually
                        //ddlLogs.Items.Add("select log");
                        ViewState["Logs"] = dtLogs;



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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtPswd.Text.Trim(), @"^(?=.*?[a-z])(?=.*?\d)(?=.*?[!@#$%\^&*\(\)\-_+=;:'""\/\[\]{},.<>|`])", RegexOptions.IgnoreCase)) // Checks whether password data field has special character or not.
                {
                    if (ModelState.IsValid)
                    {

                        // Attempt to register the user
                        MembershipCreateStatus createStatus;
                        System.Web.Security.Membership.CreateUser(TextBox1.Text, txtPswd.Text, TextBox3.Text, null, null, true, out createStatus);

                        if (createStatus == MembershipCreateStatus.Success)
                        {
                            FormsAuthentication.SetAuthCookie(TextBox1.Text, false /* createPersistentCookie */);
                            //return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            // ModelState.AddModelError("", ErrorCodeToString(createStatus));
                        }
                    }

                    // If we got this far, something failed, redisplay form
                    // return View(model);

                    Guid id = Guid.NewGuid();
                    int id2 = 0;

                    Guid id1 = Guid.NewGuid();



                    SqlCommand cmd = new SqlCommand("insert into UserRegistration values(@EmployeeId,@EmployeeName,@JobCategory,@EmailId)", con);
                    // SqlCommand cmd1 = new SqlCommand("insert into aspnet_Users (ApplicationId,UserId,UserName,LoweredUserName,IsAnonymous,LastActivityDate) values(@ApplicationId,@EmployeeId,@EmployeeName,@LoweredUserName,@Anonymous,@DateTime)", con);
                    //cmd1.Parameters.Add(new SqlParameter("@DateTime", System.DateTime.Now));
                    //cmd1.Parameters.Add(new SqlParameter("@ApplicationId", id));
                    //cmd1.Parameters.Add(new SqlParameter("@EmployeeId", id1));
                    //cmd1.Parameters.Add(new SqlParameter("@LoweredUserName", "A"));
                    //cmd1.Parameters.Add(new SqlParameter("@Anonymous", id2));
                    cmd.Parameters.Add(new SqlParameter("@EmployeeId", TextBox1.Text));
                    //cmd1.Parameters.Add(new SqlParameter("@EmployeeName", TextBox2.Text));
                    cmd.Parameters.Add(new SqlParameter("@EmployeeName", TextBox2.Text));
                    cmd.Parameters.Add(new SqlParameter("@JobCategory", ddlJobCategory.Text));
                    cmd.Parameters.Add(new SqlParameter("@Emailid", TextBox3.Text));
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (!Roles.IsUserInRole(TextBox1.Text, ddlJobCategory.Text))
                    {
                        Roles.AddUserToRole(TextBox1.Text, ddlJobCategory.Text);
                    }
                    //int j = cmd1.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Label1.Visible = false;
                        Label3.ForeColor = System.Drawing.Color.Green;
                        Label3.Text = "Submitted Successfully";
                    }
                    else
                    {
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Text = "please try again";
                    }
                    //if (j > 0)
                    //{
                    //    Label1.Text = "Submitted Successfully";
                    //}
                    //else
                    //{
                    //    Label1.Text = "please try again";
                    //}
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Password must contain atleast one special character";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint 'PK_UserRegistration'. Cannot insert duplicate key in object 'dbo.UserRegistration'.")) // Checks for the message of this type.
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Employee ID already exists. Please enter any unique Employee ID."; //Updates label with this message.

                }
                else
                {
                    Label1.Text = ex.Message;
                }
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtPswd.Text = string.Empty; // Clears textbox.
            TextBox1.Text = string.Empty; // Clears textbox.
            TextBox2.Text = string.Empty; // Clears textbox.
            TextBox3.Text = string.Empty; // Clears textbox.
            ddlJobCategory.SelectedIndex = 0; // Clears textbox.
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}