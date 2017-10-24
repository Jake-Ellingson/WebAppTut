using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTut
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EventUserControl_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EventPage.aspx");
        }
        protected void ReqFields_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RequiredFields.aspx");
        }

        protected void CompareValidator_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NumberCompare.apsx");
        }

        protected void RegExValidator_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RangeStuff");
        }

        protected void Custom_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomValidator.aspx");
        }

        protected void Caching_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cachin.aspx");
        }

        protected void SubCache_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CacheSubstitution.aspx");
        }

        protected void CachingObjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CachingObject.aspx");
        }

        protected void Cookies_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cookie.aspx");
        }

        protected void Sessions_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sessions.aspx");
        }

        protected void ViewState_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewState.aspx");
        }

        protected void Email_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SendEmails.aspx");
        }

        protected void FileUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FileUploadControl.aspx");
        }

        protected void FirstAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MySQLFirstAccess.aspx");
        }

        protected void DataBinding_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MySqlDataBinding.aspx");
        }
    }
}