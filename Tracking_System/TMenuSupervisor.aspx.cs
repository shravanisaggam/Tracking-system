using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracking_System
{
    public partial class TMenuSupervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (User.IsInRole("Admin") || User.IsInRole("Supervisor"))
                {
                    if (!IsPostBack)
                    {
                     //   if (!this.Page.User.Identity.IsAuthenticated)
                       // {
                         //   FormsAuthentication.RedirectToLoginPage();
                        //    return;
                      //  }
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
    }
}