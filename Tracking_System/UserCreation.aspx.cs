using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class UserCreation : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Database=USER-PC;Initial Catalog=ProblemTrackingUtility;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into UserRegistration values(@EmployeeId,@EmployeeName,@JobCategory,@EmailId)", con);
            cmd.Parameters.Add(new SqlParameter("@EmployeeId",TextBox1.Text));
              cmd.Parameters.Add(new SqlParameter("@EmployeeName",TextBox2.Text));
              cmd.Parameters.Add(new SqlParameter("@JobCategory", DropDownList1.Text));
            cmd.Parameters.Add(new SqlParameter("@Emailid",TextBox3.Text));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "Submitted Successfully";
            }
            else
            {
                Label1.Text = "please try again";
            }
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }


 
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}