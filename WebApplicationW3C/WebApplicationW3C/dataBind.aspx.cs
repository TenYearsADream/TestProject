using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationW3C
{
    public partial class dataBind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList mycountries = new ArrayList();
            mycountries.Add("China");
            mycountries.Add("Sweden");
            mycountries.Add("France");
            mycountries.Add("Italy");
            mycountries.TrimToSize();
            mycountries.Sort();
            rdBind.DataSource = mycountries;
            rdBind.DataBind();

            string Sql = "select * from dbo.[User]";
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataSet(Sql);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            datagrid.DataSource = dt;
            datagrid.DataBind();
        }
    }
}