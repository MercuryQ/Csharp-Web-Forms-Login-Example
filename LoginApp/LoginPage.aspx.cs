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
    public partial class LoginPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        // Create SQL database connection from Log in button
        protected void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Server = idea-PC; Database = webLogTest; Trusted_Connection = true";
               
                con.Open(); // Open db connection
                SqlCommand cmd = new SqlCommand("select * from Login where username = @username and password = @password", con); // Query to check login information
                cmd.Parameters.AddWithValue("@username", TextBox3.Text); // Username is related to username field of Login Table
                cmd.Parameters.AddWithValue("@password", TextBox4.Text); // Password is related to password field of Login Table
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    Response.Redirect("Greeting.aspx"); // Direct user to the greeting page
                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "**Wrong Details**";  // Display error message
                    TextBox3.Text = string.Empty;
                }
                con.Close(); // Close db connection
          
          }
        }   
                
       

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("NewUserPage.aspx"); // Direct user to new user page
        }
    }
}
