using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebAppTut
{
    public partial class MySQLFirstAccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT name FROM test_users", conn))
                    using(MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            Response.Write(dr["name"].ToString() + "<br />");
                        dr.Close();
                    }
                    conn.Close();
                }
            } catch (Exception ex)
            {
                Response.Write("An error occured: " + ex.Message);
            }
        }
    }
}