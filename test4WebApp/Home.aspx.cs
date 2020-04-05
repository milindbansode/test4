using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test4WebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test
            Response.Write("test3");
            Response.Write("Hello World");
            Response.Write(string.Format("test app: {0}", DateTime.Now));
        }
    }
}