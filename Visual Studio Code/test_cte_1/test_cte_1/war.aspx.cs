using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_cte_1
{
    public partial class war : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void human_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("names.aspx");
        }

        protected void comp_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("tictactoeai.aspx");
        }

        protected void run_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}