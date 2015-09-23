using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_cte_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nothing happens. Redundant.
        }

        /**
         * This method shows the current score of the player
         * Sound is played when the button is clicked
         * */
        protected void score_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.beep).Play();     //PLAY SOUND/AUDIO
            Response.Redirect("score.aspx");
        }

        /**
         * This method is invoked to play the game
         * Sound is played when the button is clicked
         * */
        protected void battle_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.beep).Play();     //PLAY SOUND/AUDIO
            Response.Redirect("war.aspx");
        }

        /** 
         * This method is invoked the view the rules page 
         * Sound is played when the button is clicked
         * */
        protected void rules_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.beep).Play();     //PLAY SOUND/AUDIO
            Response.Redirect("rules.html");   
        }

        /**
         * This method is invoked when the person clicks the log-out button
         * Here the player cookie is deleted
         * */
        protected void logout_button_Click(object sender, EventArgs e)
        {
            Response.Cookies["log_info"].Expires = DateTime.Now.AddHours(-1);   //kill the cookie when log-out
            Response.Redirect("default.aspx");                                  //returns to the default page 
        }
    }
}