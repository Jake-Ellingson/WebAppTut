using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTut
{
    public partial class NumberCompare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_SubmitFormClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                btnSubmit.Text = "Numbers compare well.";
            }
            else
            {
                if (btnSubmit.Text.Equals("OK"))
                {
                    return;
                }
                else
                {
                    btnSubmit.Text = "OK";
                }
            }
        }
    }
}