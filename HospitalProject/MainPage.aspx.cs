using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalProject
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Appointment_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LoginForms\\LoginForm.aspx");
        }

        protected void EmergencyForm_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PatientInfo.aspx");
        }

        protected void Appointment_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Appointment.aspx");
        }
    }
}