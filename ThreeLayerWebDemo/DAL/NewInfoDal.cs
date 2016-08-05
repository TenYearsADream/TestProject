using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class NewInfoDal
    {
        public List<NewInfo> GetAllNews()
        {
            DataTable dt=SqlHelper.ExecuteDataTable("select stuno, stuname, stusex, stumajor, stutel from dbo.STUINFO",CommandType.Text);
        }
    }
}
