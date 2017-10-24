using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebAppTut
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["BackgroundColor"] != null)
            {
                ColorSelector.SelectedValue = Request.Cookies["BackgroundColor"].Value;
                BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }
        }

        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            HttpCookie cookie = new HttpCookie("BackgroundColor");
            cookie.Value = ColorSelector.SelectedValue;
            cookie.Expires = DateTime.Now.AddHours(1);
            Response.SetCookie(cookie);
        }
    }
}