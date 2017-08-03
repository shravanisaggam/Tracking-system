using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Reports : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Database=USER-PC;Initial Catalog=ProblemTrackingUtility;Integrated Security=true"); 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter cmd = new SqlDataAdapter("select * from tblLogs where CAST(LogDate as DATE) between '" + TextBox1.Text + "' and '" + TextBox2.Text + "'", con);
        DataTable dt = new DataTable();
        cmd.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();
    }
   
}