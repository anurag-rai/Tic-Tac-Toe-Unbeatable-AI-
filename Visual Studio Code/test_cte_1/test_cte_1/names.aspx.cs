using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_cte_1
{
    public partial class names : System.Web.UI.Page
    {
        /**
         * When the page loads, 'cookie' for the player is checked.
         * If the cookie is present, we display the username associated with it.
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
            own_label.Text = Request.Cookies["log_info"]["username"];
        }

        /**
         * Here we take a name for the opponent and make a cookie
         * This cookie will be used to display turns while playing the game
         * To check for a valid name, we first check if the name is empty or has only spaces
         * Then we also check if the name starts with a space
         * */
        protected void war_button_Click(object sender, EventArgs e)
        {
            //make a cookie for opponent
            if (string.IsNullOrWhiteSpace(opp_textbox.Text))           //check for an empty argument or a whitespace argument
            {
                name_label.Text = "Enter a name";
                return;
            }
            if (opp_textbox.Text[0] == ' ')
            {
                name_label.Text = "Can't start with space";             //checks if the first character is a space
                return;
            }
            String cname = "oppo_info";                                 //name of the cookie for the opponent
            HttpCookie oppoinfo = new HttpCookie(cname);
            Response.Cookies[cname]["name"] = opp_textbox.Text;
            oppoinfo.Expires = DateTime.Now.AddDays(1);                 //expiration of the cookie is irrelevant to us
            Response.Redirect("tictactoe.aspx");
        }
    }
}