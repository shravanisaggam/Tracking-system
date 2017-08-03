using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracking_System
{
    public partial class TLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (System.Web.Security.Membership.ValidateUser(TextBox1.Text, TextBox2.Text)) //Validates username and password
                    {
                        FormsAuthentication.SetAuthCookie(TextBox1.Text, true);
                        //if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        //    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        //{
                        //    return Redirect(returnUrl);
                        //}
                        //else
                        //{
                        SqlCommand cmd = new SqlCommand("select EmployeeId,EmailId,JobCategory from UserRegistration where EmployeeId='" + TextBox1.Text + "'", con);
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        string UserName = TextBox1.Text;
                        string Password = TextBox2.Text;

                        while (dr.Read())
                        {
                            Session.Add("EID", dr["EmployeeId"]); // Storing Employee Id into session till logout is triggered
                            Session.Add("EmailId", dr["EmailId"]); // Storing Email Id into session till logout is triggered

                            if (System.Web.Security.Membership.ValidateUser(UserName, Password)) //  re direct to page according to user roles
                            {
                                FormsAuthentication.SetAuthCookie(UserName, true);
                                if (Roles.IsUserInRole(UserName, "Admin"))
                                {
                                    Response.Redirect("~/TMenuScreen.aspx");
                                }
                                else if (Roles.IsUserInRole(UserName, "Agent"))
                                {
                                    Response.Redirect("~/TProblemLogin.aspx");
                                }
                                else if (Roles.IsUserInRole(UserName, "SME"))
                                {
                                    Response.Redirect("~/TSMEScreen.aspx");
                                }
                                else if (Roles.IsUserInRole(UserName, "Supervisor"))
                                {
                                    Response.Redirect("~/TMenuSupervisor.aspx");
                                }


                            }

                            //if (dr["JobCategory"].ToString() == "Supervisor")
                            //{
                            //    FormsAuthentication.RedirectFromLoginPage(UserName, true);
                            //    Response.Redirect("TMenuSupervisor.aspx");
                            //}
                            //else if (dr["JobCategory"].ToString() == "Admin")
                            //{
                            //    FormsAuthentication.RedirectFromLoginPage(UserName, true);
                            //    Response.Redirect("TMenuScreen.aspx", true);

                            //}
                            //else if (dr["JobCategory"].ToString() == "Agent")
                            //{
                            //    FormsAuthentication.RedirectFromLoginPage(UserName, true);
                            //    Response.Redirect("TProblemLogin.aspx");
                            //}
                            //else
                            //{
                            //    FormsAuthentication.RedirectFromLoginPage(UserName, true);
                            //    Response.Redirect("TSMEScreen.aspx");
                            //}
                        }
                        //}
                    }
                    else
                    {
                        Label1.Text = "The user name or password provided is incorrect.";
                        ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    }
                }

                //SqlCommand cmd = new SqlCommand("select EmployeeId,EmailId,JobCategory from UserRegistration where EmployeeId='" + TextBox1.Text + "' and EmailId='" + TextBox2.Text + "'", con);
                //con.Open();
                //SqlDataReader dr = cmd.ExecuteReader();
                //string UserName = TextBox1.Text;
                //string Password = TextBox2.Text;

                //while (dr.Read())
                //{
                //    if ((dr["EmployeeId"].ToString() == UserName) && (dr["EmailId"].ToString() == Password))
                //    {
                //        Session.Add("EID", dr["EmployeeId"]);
                //        if (dr["JobCategory"].ToString() == "Supervisor")
                //        {
                //            FormsAuthentication.RedirectFromLoginPage(UserName, true);
                //            Response.Redirect("TMenuSupervisor.aspx");
                //        }
                //        else if (dr["JobCategory"].ToString() == "Admin")
                //        {
                //            FormsAuthentication.RedirectFromLoginPage(UserName, true);
                //            Response.Redirect("TMenuScreen.aspx",true);

                //        }
                //        else if (dr["JobCategory"].ToString() == "Agent")
                //        {
                //            FormsAuthentication.RedirectFromLoginPage(UserName, true);
                //            Response.Redirect("TProblemLogin.aspx");
                //        }
                //        else
                //        {
                //            FormsAuthentication.RedirectFromLoginPage(UserName, true);
                //            Response.Redirect("TSMEScreen.aspx");
                //        }
                //    }
                //    else
                //    {
                //        Label1.Text = "Invalid UserName or Password";
                //    }


                //}
            }
            catch(Exception ex)
            {
                string script = ex.Message;
                //script += "var f='" + Session["flag"].ToString() + "';\n";
                //script += "if (f == 'L')\n";
                //script += "location.href='TSMEScreen.aspx';\n";

                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", script, true);
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty; // Clears Textbox
            TextBox2.Text = string.Empty; // Clears Textbox
        }

        //protected void Button3_Click(object sender, EventArgs e)
        //{

        //}
    }
}