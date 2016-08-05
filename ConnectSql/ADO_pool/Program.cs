using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ADO.NET的启用效果
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";

            ////默认ADO.NET的连接池是被启用的
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //using(SqlConnection con= new SqlConnection(constr))
            //{
            //    con.Open();
            //    con.Close();
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.ReadKey();
            #endregion

            #region 禁用ADO.NET连接池的效果
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true;pooling=false";

            //默认ADO.NET的连接池是被启用的
            Stopwatch watch = new Stopwatch();
            watch.Start();
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                con.Close();
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.ReadKey();
            #endregion 
        }
    }
}
