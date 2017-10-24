using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTut
{
    public partial class RequiredFields : System.Web.UI.Page
    {
        protected void btnSubmitForm_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                btnSubmitForm.Text = "My form is valid!";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
    }
}