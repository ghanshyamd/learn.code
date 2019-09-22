using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn.asp.net.Caching
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Cookies["TEST"].Value = "TEST";

            object t = Request.Cookies["TEST"].Value;


            HttpCookie httpCookie = new HttpCookie("TEST1");
            httpCookie.Value = "TEST";

            dynamic test = new List<object>() { 1, "2", "3" };

            ViewState["TEST"] = test;


            Response.Cookies.Add(httpCookie);

            HttpCookie httpCookie2 = Request.Cookies["TEST"];

            if (httpCookie2 != null)
            {
                object test2 = httpCookie2["TEST"].ToString();

                httpCookie2.Expires = DateTime.Now.AddHours(1);
            }

        }
    }

    /// <summary>
    /// Control State
    /// </summary>
    public class ControlStateWebControl : Control
    {
        #region Membersprivate 
        string _strStateToSave;
        #endregion

        #region Methods
        protected override void OnInit(EventArgs e)
        {
            Page.RegisterRequiresControlState(this);
            base.OnInit(e);
        }
        protected override object SaveControlState()
        {
            return _strStateToSave;
        }
        protected override void LoadControlState(object state)
        {
            if (state != null)
            {
                _strStateToSave = state.ToString();
            }
        }
        #endregion
    }

}