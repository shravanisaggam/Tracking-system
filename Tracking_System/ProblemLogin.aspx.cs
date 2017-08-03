using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class ProblemLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
            SqlDataAdapter da=new SqlDataAdapter("select * from UserRegistration where JobCategory='SME'",con);
            ddlSme.DataTextField = "EmployeeId";
            ddlSme.DataValueField = "EmployeeName";
            DataTable dt = new DataTable();
            da.Fill(dt);
            ddlSme.DataSource = dt;
            ddlSme.DataBind();
            
        }
    }
    protected void btnCreateSr_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=Tracking;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("insert into tblLogs values(@LogDate,@ProblemCategory,@ProblemDescription,@SupervisorId,@WorkStationNo,@SmeId,@ProblemSeviority,@CurrentStatus,@Resolution,@ProposedStaus)", con);
            cmd.Parameters.Add(new SqlParameter("@LogDate", System.DateTime.Now.Date.ToShortDateString()));
            cmd.Parameters.Add(new SqlParameter("@ProblemCategory", ddlPCategory.SelectedItem.Text));
            cmd.Parameters.Add(new SqlParameter("@ProblemDescription", txtPDescription.Text));
            cmd.Parameters.Add(new SqlParameter("@SupervisorId", Session["EID"].ToString()));
            cmd.Parameters.Add(new SqlParameter("@WorkStationNo", txtWorkStationNo.Text));
            cmd.Parameters.Add(new SqlParameter("@SmeId", ddlSme.SelectedItem.Text));
            cmd.Parameters.Add(new SqlParameter("@ProblemSeviority", ddlPSiviority.SelectedItem.Text));
            cmd.Parameters.Add(new SqlParameter("@CurrentStatus", ""));
            cmd.Parameters.Add(new SqlParameter("@Resolution", ""));
            cmd.Parameters.Add(new SqlParameter("@ProposedStaus", ""));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                lblStatus.Text = "Submitted Successfully";
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

    protected void ddlSme_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}