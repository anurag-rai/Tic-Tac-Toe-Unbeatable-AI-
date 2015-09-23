using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_cte_1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nothing happens. Redundant.
        }

        //when the user hits the "sign-up" button
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        //when the user hits the "sign-in" button
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }
    }
}