﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalProject.LoginForms
{
    public partial class Dentist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
           
                string cs = WebConfigurationManager.ConnectionStrings["HospitalDbConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Delete from Dentist WHERE Id=@Id", conn);
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
            Response.Redirect("Dentist.aspx");
            Label3.Text = "Patient Deleted succesfully ☠️☠️💀";
        }
    }
}