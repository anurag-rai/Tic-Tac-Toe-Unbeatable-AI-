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
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int move = 0;
        static int[,] ttt = new int[3,3] {{8,9,10} , {11,12,13} , {14,15,16}}; //random values
        static bool xturn = true;
        /**
         * Checks if there is a cookie of the Player.
         * If not, then re-directs to the log-in page
         * */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["log_info"] == null)
            {
                Response.Redirect("signin.aspx");
            }
        }
        /**
         * The Button click methods
         * */
        protected void Button1_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button1.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[0,0] = 1;
            }
            else
            {
                Button1.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[0,0] = 0;
            }
            Button1.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button2.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[0, 1] = 1;
            }
            else
            {
                Button2.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[0, 1] = 0;
            }
            Button2.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button3.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[0,2] = 1;
            }
            else
            {
                Button3.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[0,2] = 0;
            }
            Button3.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button4.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[1, 0] = 1;
            }
            else
            {
                Button4.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[1, 0] = 0;
            }
            Button4.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button5.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[1, 1] = 1;
            }
            else
            {
                Button5.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[1, 1] = 0;
            }
            Button5.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button6.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[1, 2] = 1;
            }
            else
            {
                Button6.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[1, 2] = 0;
            }
            Button6.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button7.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[2,0] = 1;
            }
            else
            {
                Button7.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[2,0] = 0;
            }
            Button7.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);   
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button8.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[2, 1] = 1;
            }
            else
            {
                Button8.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[2, 1] = 0;
            }
            Button8.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            string own = Request.Cookies["log_info"]["username"];
            string oppo = Request.Cookies["oppo_info"]["name"];
            if (xturn)
            {
                Button9.Text = "X";
                move_label.Text = oppo + "'s turn to make a move";
                ttt[2,2] = 1;
            }
            else
            {
                Button9.Text = "O";
                move_label.Text = own + "'s turn to make a move";
                ttt[2,2] = 0;
            }
            Button9.Enabled = false;                                            //Disable the button after the move
            xturn = !xturn;
            move++;
            checkwin(move);    
        }

        /**
         * This method restart the game by removing text and enabling all buttons
         * It also re-initializes the game array to default values
         * */
        protected void restart_Click(object sender, EventArgs e)
        {
            Button1.Text = "";
            Button2.Text = "";
            Button3.Text = "";
            Button4.Text = "";
            Button5.Text = "";
            Button6.Text = "";
            Button7.Text = "";
            Button8.Text = "";
            Button9.Text = "";
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            move = 0;
            move_label.Text = "";
            xturn = true;
            ttt = new int[3, 3] { { 8, 9, 10 }, { 11, 12, 13 }, { 14, 15, 16 } }; //random values
        }

        /**
         * The method check if the game has finished
         * */
        protected void checkwin(int m)
        {
            int x = 0;
            int y = 0;
            int count = 0;
            int record = 5;                 //random value
            bool win = false;
            bool xwin = false;
            /* 
             * check the rows
             */
            for (x = 0; x < 3; x++)
            {
                record = ttt[x, 0];
                for (y = 0; y < 3; y++)
                    if (ttt[x, y] == record)
                        count++;
                    else
                        break;
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                        move_label.Text = "O wins"; // O wins
                    else
                    {
                        move_label.Text = "X wins"; // X wins
                        xwin = true;
                    }
                }
                count = 0;
            }
            /*
             * check column
             * */
            for (x = 0; x < 3; x++)
            {
                record = ttt[0, x];
                for (y = 0; y < 3; y++)
                    if (ttt[y, x] == record)
                        count++;
                    else
                        break;
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                        move_label.Text = "O wins"; // O wins
                    else
                    {
                        move_label.Text = "X wins"; // X wins
                        xwin = true;
                    }
                }
                count = 0;
            }
            /*
             * check diagonal
             * */
            //upper-left to lower-right
            record = ttt[0, 0];
            for (x = 0; x < 3; x++)
                if (ttt[x, x] == record)
                    count++;
            if (count == 3)
            {
                win = true;
                if (record == 0)
                    move_label.Text = "O wins"; // O wins
                else
                {
                    move_label.Text = "X wins"; // X wins
                    xwin = true;
                }
            }
            count = 0;
            //upper-right to lower-left
            y = 0;
            record = ttt[0, 2];
            for (x = 2; x >= 0; x--)
            {
                if (ttt[y, x] == record)
                    count++;
                y++;
            }
            if (count == 3)
            {
                win = true;
                if (record == 0)
                    move_label.Text = "O wins"; // O wins
                else
                {
                    move_label.Text = "X wins"; // X wins
                    xwin = true;
                }
            }
            count = 0;
            if (win)                            //If the game has ended
            {
                new System.Media.SoundPlayer(Properties.Resources.win).Play();      //PLAY SOUND
                disable_all();                                                      //Disable all buttons

                if (xwin)
                {
                    /* UPDATE THE SCORE
                     * first get the score
                     * add 1 to it
                     * update database
                     * */

                    //get the score
                    string username = Request.Cookies["log_info"]["username"];
                    string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(db);
                    conn.Open();

                    String command;
                    command = "select score from logininfo where username = @username";     //get the score corresponding to the username
                    SqlCommand cmd = new SqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    string temp = cmd.ExecuteScalar().ToString();
                    int temp_score = Convert.ToInt32(temp);
                    temp_score += 1;

                    command = "UPDATE logininfo SET score = @temp_score where username = @username";    //update score
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@temp_score", temp_score);
                    cmd2.ExecuteNonQuery();                      //Execute the query
                    conn.Close();                               //Close connection to DB

                    score_label.Text = temp_score.ToString();
                }
            }
            if (m >= 9 && win==false)               //If all buttons have been clicked and there is no winner, the draw
            {
                move_label.Text = "draw";
            }
        }

        protected void home_button_Click(object sender, EventArgs e)
        {
            restart_Click(sender, e);
            Response.Redirect("home.aspx");
        }

        /**
         * Method disables all buttons when the game has ended
         * */
        protected void disable_all()
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
        }
    }
}