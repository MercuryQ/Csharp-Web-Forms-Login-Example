using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginApp
{
    public partial class NewUserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // SQL connection from Create button
        protected void Button1_Click(object sender, EventArgs e)
        {
         
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Server = idea-PC; Database = webLogTest; Trusted_Connection = true";
                SqlCommand cmd = new SqlCommand();
                string sql;

                // Execute insert query
                try
                {
                    sql = "INSERT INTO Login (username, password)";
                    sql += String.Format("VALUES (@username, @password)");

                    // Prevent NuLL or Empty user input
                    if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
                    {

                        cmd = new SqlCommand(sql, con);
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);

                        con.Open(); // Open db connection
                        cmd.ExecuteNonQuery();
                        Label4.Visible = false;
                        Label5.Visible = false;
                        Label3.Visible = true;
                        Label3.Text = "Successful"; // Display successful insert
                        username.Text = "";
                        password.Text = "";

                        username.Focus();

                    }
                    // Warn user of empty or null input
                    else
                    {
                        Label5.Visible = true;
                        Label5.Text = " Warning, Cannot be empty!!!";
                    }

                }
                // Catch input errors
                catch (SqlException)
                {
                    Label4.Visible = true;
                    Label5.Visible = false;
                    Label4.Text = "Invalid, Please try again!";
                    username.Text = "";
                    password.Text = "";
                }
                finally
                {
                    con.Close(); // Clsoe db connection
                }
            
       
            }
        }
        
        // Return user to log in page
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}
