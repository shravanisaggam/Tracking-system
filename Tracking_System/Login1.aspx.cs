using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Database=USER-PC;Initial Catalog=ProblemTrackingUtility;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select EmployeeId,EmailId,JobCategory from UserRegistration where EmployeeId='" + TextBox1.Text + "' and EmailId='" + TextBox2.Text + "'", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        string UserName = TextBox1.Text;
        string Password = TextBox2.Text;

        while (dr.Read())
        {
            if ((dr["EmployeeId"].ToString() == UserName) && (dr["EmailId"].ToString() == Password))
            {
                Session.Add("EID",dr["EmployeeId"]);
                if (dr["JobCategory"].ToString() == "Supervisor")
                {
                    Response.Redirect("ProblemLogin.aspx");
                }
                else
                {
                    Response.Redirect("SMEScreen.aspx");
                }
            }
            else
            {
                Label1.Text = "Invalid UserName or Password";
            }


        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}