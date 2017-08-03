using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class SMEScreen : System.Web.UI.Page
{
    DataTable dtLogs = new DataTable();
    SqlConnection con = new SqlConnection("Database=VAMSI-PC;Initial Catalog=ProblemTrackingUtility;Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            SqlDataAdapter cmd = new SqlDataAdapter("select * from tblLogs where SmeId='" + Session["EID"].ToString() + "' and ProposedStaus='" + "" + "'", con);
            con.Open();
            cmd.Fill(dtLogs);
            ddlLogs.DataTextField = "LogNo";
            ddlLogs.DataSource = dtLogs;
          
            ddlLogs.DataBind();
            ddlLogs.Items.Add("select log");
            ViewState["Logs"] = dtLogs;
       
        }
    }
    protected void ddlLogs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLogs.SelectedItem.Text != "select log")
        {
            dtLogs = (DataTable)ViewState["Logs"];
            DataColumn logNo = new DataColumn();

            DataRow[] selectedLog = dtLogs.Select("LogNo="+ddlLogs.SelectedItem.Text+"");
            txtSrDate.Text = selectedLog[0]["LogDate"].ToString();
            txtPbSeviority.Text = selectedLog[0]["ProblemSeviority"].ToString();
            txtPbCategory.Text = selectedLog[0]["ProblemCategory"].ToString();
            txtCurrentStatus.Text = selectedLog[0]["CurrentStatus"].ToString();
            txtProposedStatus.Text = selectedLog[0]["ProposedStaus"].ToString();
            txtPbDescription.Text = selectedLog[0]["ProblemDescription"].ToString();
            txtSupervisorid.Text = selectedLog[0]["SupervisorId"].ToString();
            //txtSupervisorName.Text = selectedLog[0][""].ToString();
            txtResoution.Text = selectedLog[0]["Resolution"].ToString();



        }
    }
    protected void btnUpdateSr_Click(object sender, EventArgs e)
    {
        string sql = "UPDATE [tblLogs] SET CurrentStatus='"+txtCurrentStatus.Text+ "',ProposedStaus='"+txtProposedStatus.Text+"',Resolution='"+txtResoution.Text+"' where LogNo='"+ddlLogs.SelectedItem.Text+"'";
        con.Open();
        SqlCommand cmd1 = new SqlCommand(sql, con);
        
        //cmd1.Parameters.AddWithValue("@CurrentStatus", txtCurrentStatus.Text);
        //cmd1.Parameters.AddWithValue("@ProposedStaus", txtProposedStatus);
        //cmd1.Parameters.AddWithValue("@Resolution", txtResoution.Text);
        //cmd1.Parameters.AddWithValue("@LogNo", ddlLogs.SelectedItem.Text);
        cmd1.ExecuteNonQuery();
    }
}