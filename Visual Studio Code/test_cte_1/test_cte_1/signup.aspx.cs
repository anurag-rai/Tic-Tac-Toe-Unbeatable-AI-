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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pass_label.Text = "";
        }

        /** 
         * This method creats a new entry for the table in the database
         * Also checks for a unique "username"
         * If username already existst, user is prompted to change the username
         * */
        protected void signup_button_Click(object sender, EventArgs e)
        {
            String name, mail, pass, pass2;
            name = namebox.Text;
            mail = mailbox.Text;
            pass = passbox1.Text;
            pass2 = passbox2.Text;
            
            //check if username is already present in the database
            string d_b = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
            SqlConnection con = new SqlConnection(d_b);
            con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM logininfo WHERE username = @username", con);
            using (con)
            {
                sda.SelectCommand.Parameters.AddWithValue("@username", name);
                sda.Fill(dt);
                if (dt.Rows.Count != 0)                         //If the data-table has some rows
                {
                    name_label.Text = "Username already taken";
                    con.Close(); 
                    return;
                } 
            }

            if (name == "" || pass == "")                       //If the username or password is empty
            {
                pass_label.Text = "Required fields should not empty";
                return;
            }

            if (pass != pass2)                                  //If the password and "re-type password" don't match
            {
                pass_label.Text = "Passwords don't match";
            }
            else                                                //All parameters are valid and we enter the data
            {
                //enter data in the SQL database
                string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
                SqlConnection conn = new SqlConnection(db);
                conn.Open();                                //Open the connection to DB 
                string cmdstr;
                cmdstr = "INSERT into logininfo values(@username,@pass,@email,@score)";
                //Insert into <table_name> values (" + name + "," + pass + "," + "mail" + "," + "0)"
                SqlCommand cmd = new SqlCommand(cmdstr,conn);
                cmd.Parameters.AddWithValue("@username",name);
                cmd.Parameters.AddWithValue("@pass", CalculateMD5Hash(pass));
                cmd.Parameters.AddWithValue("@email", mail);
                cmd.Parameters.AddWithValue("@score", 0);
                cmd.ExecuteNonQuery();                      //Execute the query
                conn.Close();                               //Close connection to DB
                Response.Redirect("signin.aspx");           
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