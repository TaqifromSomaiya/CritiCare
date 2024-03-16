using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace HospitalProject
{
    public partial class Receptionist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                MultiView1.SetActiveView(View2);
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
            string cs = WebConfigurationManager.ConnectionStrings["HospitalDbConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Delete from Patient WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Label3.Text = "Patient Deleted succesfully ☠️☠️💀";

            }
            catch (Exception ex)
            {

                Label3.Text = ex.Message;
            }
        }
    }
}