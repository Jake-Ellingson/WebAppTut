using System;
using System.Web;
using System.Data;

namespace WebAppTut
{
    public partial class Sessions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BackgroundColor"] != null)
            {
                ColorSelector.SelectedValue = Session["BackgroundColor"].ToString();
                BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }
        }

        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            Session["BackgroundColor"] = ColorSelector.SelectedValue;
        }
    }
}