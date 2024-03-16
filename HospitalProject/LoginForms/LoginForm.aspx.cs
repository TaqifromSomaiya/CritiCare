using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalProject.LoginForms
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reception_Click(object sender, EventArgs e)
        {
            Response.Redirect("Receptionist.aspx");

        }

        protected void Doctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorsLogin.aspx");
        }
    }
}