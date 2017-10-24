using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading;

namespace WebAppTut
{
    public partial class MySqlDataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM test_users", conn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        ddlUsers.DataSource = dr;
                        ddlUsers.DataBind();
                        dr.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("An error occured: " + ex.Message);
            }
        }

        protected void SubmitPerson_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `test`.`test_users` (`name`, `country`) VALUES ('" + txtPerson.Text + "', '" + txtCountry.Text + "');", conn))
                    {
                        cmd.ExecuteNonQuery();
                        lblConfirm.Text = "Person added to database. Refreshing in 3 seconds.";
                        txtPerson.Text = "";
                        txtCountry.Text = "";
                        Response.AddHeader("REFRESH", "3;URL=MySqlDataBinding.aspx");
                    }
                }
            } 
            catch (Exception ex)
            {
                Response.Write("An error occured: " + ex.Message);
            }
        }
    }
}