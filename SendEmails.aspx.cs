using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebAppTut
{
    public partial class SendEmails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            try
            {
                String msg = "Sender: " + txtFrom.Text + "\n\nMessage: " + txtMsg.Text;

                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("jacobellingson40@gmail.com", "Prince5997");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                MailMessage mailMsg = new MailMessage();
                mailMsg.To.Add("jacobellingson40@gmail.com");
                mailMsg.From = new MailAddress("jacobellingson40@gmail.com", txtFrom.Text);
                mailMsg.Subject = txtSubject.Text;
                mailMsg.Body = msg;

                client.Send(mailMsg);
                Response.Write("E-mail sent!");
            }
            catch (Exception e1)
            {
                Response.Write("Could not send e-mail - error: " + e1.Message);
            }
        }
    }
}