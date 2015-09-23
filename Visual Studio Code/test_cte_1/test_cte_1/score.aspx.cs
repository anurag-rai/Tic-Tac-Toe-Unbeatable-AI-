using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test_cte_1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        /**
         * When the page loads, 'cookie' for the player is checked.
         * If the cookie is present, we display the score associated with it.
         * If the cookie is NOT present, we redirect the user to the log-in page.
         * This check is useful if the URL of this page has been sent from one computer to another
         * where the first computer is logged-in and the second computer is not logged-in
         * */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["log_info"] == null)
            {
                Response.Redirect("signin.aspx");
            }
            else
            {
                string username, pass;
                username = Request.Cookies["log_info"]["username"];
                pass = Request.Cookies["log_info"]["pass"];             //not necessary

                //find the score associated with the username. [Username is unique as defined in signup.aspx.cs]

                string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
                SqlConnection conn = new SqlConnection(db);
                conn.Open();
                String command;
                command = "select score from logininfo where username = @username";             
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@username", username);
                score_label.Text = cmd.ExecuteScalar().ToString();
                conn.Close();                               //Close connection to DB
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        /**
         * This method resets the score of the player to 0
         * */
        protected void reset_score_Click(object sender, EventArgs e)
        {
            string username;
            username = Request.Cookies["log_info"]["username"];

            string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
            SqlConnection conn = new SqlConnection(db);
            conn.Open();                                        //Open the connection to DB 

            string cmdstr;
            cmdstr = "UPDATE logininfo SET score = 0 where username = @username";           //Update score to 0
            
            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();                              //Execute the query
            conn.Close();                                       //Close connection to DB
            Response.Redirect("score.aspx");
        }
    }
}