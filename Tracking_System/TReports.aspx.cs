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
    public partial class TReports : System.Web.UI.Page
    {
          
        SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (!this.Page.User.Identity.IsAuthenticated)
           // {
             //   FormsAuthentication.RedirectToLoginPage();
               // return;
           // }
            btnCancel.Attributes.Add("onClick", "javascript:history.back(); return false;");
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
            SqlDataAdapter cmd = new SqlDataAdapter("select * from tblLogs where CAST(LogDate as DATE) between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
        //protected void ValidateDuration(object sender, ServerValidateEventArgs e)
        //{
        //    try
        //    {
        //        DateTime start = DateTime.Parse(TextBox1.Text);
        //        DateTime end = DateTime.Parse(TextBox2.Text);

        //        int months = (end.Month - start.Month) + 12 * (end.Year - start.Year);

        //        e.IsValid = months < 12.0;
        //    }
        //    catch (Exception ex)
        //    {
        //        lblError.Text = ex.Message;
        //    }
        //}

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
   
    }
}