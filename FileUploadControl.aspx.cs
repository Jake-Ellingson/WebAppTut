using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebAppTut
{
    public partial class FileUploadControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUploadControl1.HasFile)
            {
                if (FileUploadControl1.PostedFile.ContentLength <= 500000)
                {
                        try
                        {
                            string filename = Path.GetFileName(FileUploadControl1.FileName);

                                FileUploadControl1.SaveAs(Server.MapPath("~/") + filename);
                                StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        catch (Exception ex)
                        {
                            StatusLabel.Text = "Upload status: The file could not be uploaded. Error: " + ex.Message;
                        }
                }
                else
                {
                    StatusLabel.Text = "Upload status: Error! File size may only be 500 kb!";
                }
            }
        }
    }
}