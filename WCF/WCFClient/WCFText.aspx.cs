using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.WCF;

namespace WCFClient
{
    public partial class WCFText : System.Web.UI.Page
    {          
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnClick(object sender,EventArgs e)
        {
            UserClient user = new UserClient();
            
            string result=user.ShowName(this.txtName.Text);
            Response.Write(result);
        }
    }
}