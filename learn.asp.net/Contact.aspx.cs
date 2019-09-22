using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn.asp.net
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("Valid");
            }
            else
            {
                Response.Write("Not Valid");
            }
        }
    }
}