using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn.asp.net.Caching
{
    public partial class CacheControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();

            Cache["Website"] = "CSharpCorner";

            Cache.Insert("Website", lblTime.Text, new System.Web.Caching.CacheDependency(Server.MapPath(@"tesr.txt")), DateTime.Now.AddMinutes(5), TimeSpan.Zero);
        }
    }
}