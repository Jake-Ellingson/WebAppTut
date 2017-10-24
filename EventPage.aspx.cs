using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTut
{
    public partial class EventPage : System.Web.UI.Page
    {
        protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
        {
            this.Page.Title = MyEventUserControl.PageTitle;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}