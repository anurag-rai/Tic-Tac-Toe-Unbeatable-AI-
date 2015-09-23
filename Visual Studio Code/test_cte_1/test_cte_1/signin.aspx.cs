using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace test_cte_1
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Does nothing. Redundant method.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name, pass, password;
            name = namebox.Text;
            password = passbox.Text;
            pass = CalculateMD5Hash(password);                              //converts the password into its MD5 hash
            /* compare With SQL database then login and go to home.aspx
             * else redirect to same page (signin.aspx) with label "incorrect data"
             * */
            string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
            SqlConnection conn = new SqlConnection(db);
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM logininfo WHERE username = @username AND pass = @pass", conn);
            using (conn)
            {
                sda.SelectCommand.Parameters.AddWithValue("@username", name);
                sda.SelectCommand.Parameters.AddWithValue("@pass", pass);

                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    this.Label1.Text = "Wrong username or password combination";
                    return;
                }

                // Reaching here = Valid login

                //Make a cookie for the Player

                String cname = "log_info";                      //name of the cookie
                HttpCookie loginfo = new HttpCookie(cname);
                Response.Cookies[cname]["username"] = name;
                Response.Cookies[cname]["pass"] = pass;
                loginfo.Expires = DateTime.Now.AddDays(1);
                Response.Redirect("home.aspx");
            }
        }
        /**
         * This method calculates the MD5 hash of the given passoword and returns it as a string
         * */
        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}