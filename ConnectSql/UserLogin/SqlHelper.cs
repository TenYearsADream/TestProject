using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserLogin
{
    public static class SqlHelper
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["MMS"].ConnectionString;
        //执行增删改
        public static int ExcuteNonQuery(string sql,params SqlParameter[] pms)
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    if(pms!=null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static object ExcuteScalar(string sql,params SqlParameter[] pms)
        {
            using(SqlConnection con=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    if(pms!=null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        public static SqlDataReader ExcuteDataReader(string sql,params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(constr);
            using(SqlCommand cmd=new SqlCommand(sql,con))
            {
                if(pms!=null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }
    }
}
