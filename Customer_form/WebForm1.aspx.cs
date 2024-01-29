using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer_form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "User Name: " + TxtName.Text;
                LblMsg.Text += "<br/> Password: " + TxtMobile.Text;
                LblMsg.Text += "<br/> Email: " + TxtEmail.Text;
                LblMsg.Text += "<br/> Password: " + Password.Text;

            }
        }
    }
}