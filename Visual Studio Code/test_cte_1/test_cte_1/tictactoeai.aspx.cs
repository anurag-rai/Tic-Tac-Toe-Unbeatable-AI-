using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace test_cte_1
{
    public partial class tictactoeai : System.Web.UI.Page
    {
        static int[,] arr = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };      //game array of random values
        static int m = 0;
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
            Button1.Text = "X";
            Button1.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[0,0] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button2.Text = "X";
            Button2.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[0, 1] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button3.Text = "X";
            Button3.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[0, 2] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button4.Text = "X";
            Button4.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[1, 0] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button5.Text = "X";
            Button5.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[1, 1] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button6.Text = "X";
            Button6.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[1, 2] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button7.Text = "X";
            Button7.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[2, 0] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button8.Text = "X";
            Button8.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[2, 1] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }   

        protected void Button9_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.move).Play();     //PLAY SOUND FOR THE MOVE
            Button9.Text = "X";
            Button9.Enabled = false;                                            //Disable the button after the move
            m++;
            arr[2, 2] = 0;
            comp_move();                                                        //Make the computer move
            game_status();                                                      //Check if the game has ended
        }

        /**
         * This method restart the game by removing text and enabling all buttons
         * It also re-initializes the game array to default values
         * */
        protected void restart_button_Click(object sender, EventArgs e)     
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arr[i, j] = 2;
            m = 0;
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
            winner_label.Text = "";
        }

        /**
         * This method determines the move of the computer
         * Explanation of the methods are in the algo.html file
         * */
        protected void comp_move()              
        {
            if (check_win())
                return;       
            if(check_oppo_win())
                return;
            if (create_fork())
                return;
            if (block_fork())
                return;
            if(occupy_centre())
                return;
            if(occupy_corner())
                return;
            if(occupy_edge())
                return;
        }


        protected bool check_win()
        {
            if (check_row(1))
		        return true;
	        if (check_column(1))
		        return true;
	        if(check_diagonal(1))
		        return true;
            return false;
        }
        protected bool check_oppo_win()
        {
            if (check_row(0))
                return true;
            if (check_column(0))
                return true;
            if (check_diagonal(0))
                return true;
            return false;
        }
        protected bool check_row(int num) 
        {
           int count1 = 0;
           int count2 = 0;
           int index_i = 0;
           int index_j = 0;
            for( int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if ( arr[i,j] == num)
                        count1++;
                    if ( arr[i,j] == 2)
                    {
                        count2++;
                        index_i = i;
                        index_j = j;
                    }
                
                }
                if (count1 == 2 && count2 == 1)         //if two are '1' and one is '2'
                {
                    make_move(index_i, index_j);        //win the game
                    return true;     
                }
                count1 = 0;
                count2 = 0;
                index_i = 0;
                index_j = 0;
            }
            return false;
        }
        protected bool check_column(int num) 
        { 
            int count1 = 0;
            int count2 = 0;
            int index_i = 0;
            int index_j = 0;
            for( int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if ( arr[j,i] == num)
                        count1++;
                    if ( arr[j,i] == 2)
                    {
                          count2++;
                        index_i = j;
                        index_j = i;
                    }  
                }
                if(count1 == 2 && count2 == 1)
                {
                   make_move(index_i, index_j);
                    return true;
                }
                count1 = 0;
                count2 = 0;
                index_i = 0;
                index_j = 0;
            }
            return false; 
        }
        protected bool check_diagonal(int num)
        { 
            int count1 = 0;
            int count2 = 0;
            int index_i = 0;
            int index_j = 0;
            //top-left to bottom right
            for( int i = 0; i < 3; i++)
            {
                if ( arr[i,i] == num)
                    count1++;
                if ( arr[i,i] == 2)
                {
                    count2++;
                    index_i = i;
                }
                if (count1 == 2 && count2 == 1)
                {
                    make_move(index_i, index_i);
                    return true;
                }
            }
            count1 = 0;
            count2 = 0;
            index_i = 0;
            index_j = 0;
            //top-right to bottom left
            for( int i = 0; i < 3; i++)
            {
                if ( arr[i,2-i] == num)
                    count1++;
                if ( arr[i,2-i] == 2)
                {
                    count2++;
                    index_i = i;
                    index_j = 2-i;
                }
                if (count1 == 2 && count2 == 1)
                {
                    make_move(index_i, index_j);
                    return true;
                }
            }
            return false; 
        }
        protected bool create_fork()
        {
            int[,] dup = new int[3,3];				//create a duplcate array of the original move array 
	        int count1 = 0;
	        int count2 = 0;
	        int win_count = 0;
	        for(int i = 0; i < 3; i ++)
	        {
		        for(int j = 0; j < 3; j ++)
		        {
			        if( arr[i,j] == 2)				//check if the no move has been played in the slot
			        {
                        for (int p = 0; p < 3; p++)
                            for (int q = 0; q < 3; q++)
                                dup[p, q] = arr[p, q];
				        dup[i,j] = 1;
				        count1 = 0;
				        count2 = 0;
				        for(int k = 0; k < 3; k ++)		//check if a row can be won
				        {
					        if(dup[i,k] == 1)
						        count1++;
					        if(dup[i,k] == 2)
						        count2++;
				        }
				        if(count1 == 2 && count2 == 1)
					        win_count++;
				        count1 = 0;
				        count2 = 0;
				        for(int k = 0; k < 3; k ++)		//check if a column can be won
				        {
					        if(dup[k,j] == 1)
						        count1++;
					        if(dup[k,j] == 2)
						        count2++;
				        }
				        if(count1 == 2 && count2 == 1)
					        win_count++;
				        count1 = 0;
				        count2 = 0;
				        if( ((i == 0) && (j==0)) || ((i == 1) && (j==1)) || ((i == 2) && (j==2)) )	//check if the element is a diagonal
				        {
					        for(int k = 0; k < 3; k ++)				//check the diagonal (top-left to bottom-right)
					        {
						        if(dup[k,k] == 1)
							        count1++;
						        if(dup[k,k] == 2)
							        count2++;
					        }
					        if(count1 == 2 && count2 == 1)
						        win_count++;
				        }
				        count1 = 0;
				        count2 = 0;
				        if( ((i == 0) && (j==2)) || ((i == 1) && (j==1)) || ((i == 2) && (j==0)) )	//check if the element is a diagonal
				        {
					        for(int k = 0; k < 3; k ++)				//check the diagonal (top-right to bottom-left)
					        {
						        if(arr[k,2-k] == 1)
							        count1++;
						        if(arr[k,2-k] == 2)
							        count2++;
					        }
					        if(count1 == 2 && count2 == 1)
						        win_count++;
				        }
				        if(win_count >= 2)
				        {
					        make_move(i,j);
                            return true;
				        }
			        }
		        }
	        }
            return false;
        }
        protected bool block_fork()
        {
            int[,] dup = new int[3,3];					//create a duplcate array of the original move array
	        int status = 0;									//to count 2 forks. E.g. 0 - X, 4 - O, 8 - X. must not play 2 or 6. Create two in a row so that player has to defend.
	        int count0 = 0;
	        int count2 = 0;
	        int index_i = 0;
	        int index_j = 0;
	        int win_count = 0;
	        for(int i = 0; i < 3; i ++)
	        {
		        for(int j = 0; j < 3; j ++)
		        {
                    win_count = 0;
			        if( arr[i,j] == 2)					//check if the no move has been played in the slot
			        {   
                        for (int p = 0; p < 3; p++)
                            for (int q = 0; q < 3; q++)
                                dup[p, q] = arr[p, q];
				        dup[i,j] = 0;
				        count0 = 0;
				        count2 = 0;
				        for(int k = 0; k < 3; k ++)		//check if a row can be won
				        {
					        if(dup[i,k] == 0)
						        count0++;
					        if(dup[i,k] == 2)
						        count2++;
				        }
				        if(count0 == 2 && count2 == 1)
					        win_count++;
				        count0 = 0;
				        count2 = 0;
				        for(int k = 0; k < 3; k ++)		//check if a column can be won
				        {
					        if(dup[k,j] == 0)
						        count0++;
					        if(dup[k,j] == 2)
						        count2++;
				        }
				        if(count0 == 2 && count2 == 1)
					        win_count++;
				        count0 = 0;
				        count2 = 0;
				        if( ((i == 0) && (j==0)) || ((i == 1) && (j==1)) || ((i == 2) && (j==2)) )	//check if the element is a diagonal
				        {
					        for(int k = 0; k < 3; k ++)				//check the diagonal (top-left to bottom-right)
					        {
						        if(dup[k,k] == 0)
							       count0++;
						        if(dup[k,k] == 2)
						        	count2++;
					        }
					        if(count0 == 2 && count2 == 1)
						        win_count++;
				        }
				        count0 = 0;
				        count2 = 0;
				        if( ((i == 0) && (j==2)) || ((i == 1) && (j==1)) || ((i == 2) && (j==0)) )	//check if the element is a diagonal
				        {
					        for(int k = 0; k < 3; k ++)				//check the diagonal (top-right to bottom-left)
					        {
						        if(dup[k,2-k] == 0)
							        count0++;
						        if(dup[k,2-k] == 2)
							        count2++;
					        }
					        if(count0 == 2 && count2 == 1)
						        win_count++;
				        }
				        if(win_count >= 2)
				        {
					        index_i = i;
					        index_j = j;
					        status++;
				        }
			        }
		        }
	        }
            if (status == 1)
            {
                make_move(index_i, index_j);
                return true;
            }

            if (status == 2)
            {
                two_in_a_row();
                return true;
            }
            return false;
        }
        protected void two_in_a_row()
        {
            int count1 = 0;
            int count2 = 0;
            int index_i = 0;
            int index_j = 0;
            for(int i = 0; i < 3; i ++)
	        {
		        for(int j = 0; j < 3; j ++)
		        {
			        if(arr[i,j] == 1)
				        count1++;
			        if(arr[i,j] == 2)
			        {
				        count2++;
				        index_i = i;
				        index_j = j;
			        }
                    if (count1 == 1 && count2 == 2)
                    {
                        make_move(index_i, index_j);
                        return;
                    }            
		        }
                count1 = 0;
                count2 = 0;
	        }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[j, i] == 1)
                        count1++;
                    if (arr[j, i] == 2)
                    {
                        count2++;
                        index_i = j;
                        index_j = i;
                    }
                    if (count1 == 1 && count2 == 2)
                    {
                        make_move(index_i, index_j);
                        return;
                    }
                }
                count1 = 0;
                count2 = 0;
            }
        }
        protected bool occupy_centre()
        {
            if (arr[1, 1] == 2)
            {
                make_move(1, 1);
                return true;
            }
            return false;
                
        }
        protected bool occupy_corner()
        {
            if (arr[0, 0] == 2)
            {
                make_move(0, 0);
                return true;
            }
            if (arr[0, 2] == 2)
            {
                make_move(0, 2);
                return true;
            }
            if (arr[2, 0] == 2)
            {
                make_move(2, 0);
                return true;
            }
            if (arr[2, 2] == 2)
            {
                make_move(2, 2);
                return true;
            }
            return false;

        }
        protected bool occupy_edge()
        {
            if (arr[0, 1] == 2)
            {
                make_move(0, 1);
                return true;
            }
            if (arr[1, 0] == 2)
            {
                make_move(1, 0);
                return true;
            }
            if (arr[1, 2] == 2)
            {       
                make_move(1, 2);
                return true;
            }
            if (arr[2, 1] == 2)
            {
                make_move(2, 1);
                return true;
            }
            return false;
        }
        protected void make_move(int i, int j) 
        {
            if (i == 0)
            {
                if (j == 0)
                {
                    Button1.Text = "O";
                    Button1.Enabled = false;
                    arr[0, 0] = 1;
                    m++;
                }
                if (j == 1)
                {
                    Button2.Text = "O";
                    Button2.Enabled = false;
                    arr[0, 1] = 1;
                    m++;
                }
                if (j == 2)
                {
                    Button3.Text = "O";
                    Button3.Enabled = false;
                    arr[0, 2] = 1;
                    m++;
                }
            }
            if (i == 1)
            {
                if (j == 0)
                {
                    Button4.Text = "O";
                    Button4.Enabled = false;
                    arr[1, 0] = 1;
                    m++;
                }
                if (j == 1)
                {
                    Button5.Text = "O";
                    Button5.Enabled = false;
                    arr[1, 1] = 1;
                    m++;
                }
                if (j == 2)
                {
                    Button6.Text = "O";
                    Button6.Enabled = false;
                    arr[1, 2] = 1;
                    m++;
                }
            }
            if (i == 2)
            {
                if (j == 0)
                {
                    Button7.Text = "O";
                    Button7.Enabled = false;
                    arr[2, 0] = 1;
                    m++;
                }
                if (j == 1)
                {
                    Button8.Text = "O";
                    Button8.Enabled = false;
                    arr[2, 1] = 1;
                    m++;
                }
                if (j == 2)
                {
                    Button9.Text = "O";
                    Button9.Enabled = false;
                    arr[2, 2] = 1;
                    m++;
                }
            }
        }
        /**
         * Method to check if the game has ended
         * */
        protected void game_status()            
        {
            int x = 0;
            int y = 0;
            int count = 0;
            int record = 5; //random value
            bool win = false;
            bool pwin = false;
            /* 
             * check the rows
             */
            for (x = 0; x < 3; x++)
            {
                record = arr[x, 0];
                if (record == 2)
                    continue;
                for (y = 0; y < 3; y++)
                    if (arr[x, y] == record)
                        count++;
                    else
                        break;
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                    {
                        winner_label.Text = "YOU WIN"; // YOU WIN
                        pwin = true;
                    }
                    else
                    {
                        winner_label.Text = "YOU LOST!"; // YOU LOST!

                    }
                }
                count = 0;
            }
            /*
             * check column
             * */
            for (x = 0; x < 3; x++)
            {
                record = arr[0, x];
                if (record == 2)
                    continue;
                for (y = 0; y < 3; y++)
                    if (arr[y, x] == record)
                        count++;
                    else
                        break;
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                    {
                        winner_label.Text = "YOU WIN!"; // YOU WIN
                        pwin = true;
                    }
                    else
                    {
                        winner_label.Text = "YOU LOST!"; // YOU LOST!
                    }
                }
                count = 0;
            }
            /*
             * check diagonal
             * */
            //upper-left to lower-right
            record = arr[0, 0];
            if (record == 0 || record == 1)
            {
                for (x = 0; x < 3; x++)
                    if (arr[x, x] == record)
                        count++;
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                    {
                        winner_label.Text = "YOU WIN!"; // YOU WIN
                        pwin = true;
                    }
                    else
                        winner_label.Text = "YOU LOST!"; // YOU LOST!   
                }
            }
            count = 0;
            //upper-right to lower-left
            y = 0;
            record = arr[0, 2];
            if (record == 0 || record == 1)
            {
                for (x = 2; x >= 0; x--)
                {
                    if (arr[y, x] == record)
                        count++;
                    y++;
                }
                if (count == 3)
                {
                    win = true;
                    if (record == 0)
                    {
                        winner_label.Text = "YOU WIN!"; // YOU WIN
                        pwin = true;
                    }
                    else
                    {
                        winner_label.Text = "YOU LOST!"; // YOU LOST!   
                    }
                }
            }   
            count = 0;
            if (win)
            {
                disable_all();
                if (pwin)                       //IF THE PLAYERS WINS, ADD +1 TO SCORE
                {
                    //play happy sound
                    new System.Media.SoundPlayer(Properties.Resources.win).Play();                  //PLAY SOUND
                    //update score
                    string username = Request.Cookies["log_info"]["username"];
                    string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(db);
                    conn.Open();

                    String command;
                    command = "select score from logininfo where username = @username";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    string temp = cmd.ExecuteScalar().ToString();
                    int temp_score = Convert.ToInt32(temp);
                    temp_score += 1;

                    command = "UPDATE logininfo SET score = @temp_score where username = @username";
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@temp_score", temp_score);
                    cmd2.ExecuteNonQuery();                      //Execute the query
                    conn.Close();                               //Close connection to DB

                    check_label_1.Text = temp_score.ToString();
                }
                else                         //IF THE PLAYERS LOSES, ADD -1 TO SCORE
                {
                    //play sad sound
                    new System.Media.SoundPlayer(Properties.Resources.loss).Play();                 //PLAY AUDIO
                    //update score
                    string username = Request.Cookies["log_info"]["username"];
                    string db = "Data Source=Lazy;Initial Catalog=test;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(db);
                    conn.Open();

                    String command;
                    command = "select score from logininfo where username = @username";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    string temp = cmd.ExecuteScalar().ToString();
                    int temp_score = Convert.ToInt32(temp);
                    temp_score -= 1;

                    command = "UPDATE logininfo SET score = @temp_score where username = @username";
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@temp_score", temp_score);
                    cmd2.ExecuteNonQuery();                      //Execute the query
                    conn.Close();                               //Close connection to DB

                    check_label_1.Text = temp_score.ToString();
                }
            }
            if (m >= 9 && win == false)             //If all buttons have been clicked and there is no winner, the draw
            {
                winner_label.Text = "DRAW";
            }
        }
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

        protected void HOME_Click(object sender, EventArgs e)
        {
            restart_button_Click(sender, e);    //NEEDED, otherwise static values will remain same if game is quit when unfinished, and rejoined
            Response.Redirect("home.aspx");
        }

    }
}