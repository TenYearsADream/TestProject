using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectSql
{
    class Program
    {       
        static void Main(string[] args)
        {         
            #region 建立数据库连接
            //连接数据库步骤
            //1.创建连接字符串
            //Data Source=DESKTOP-OIJACEC;
            //Initial Catalog=itcast2014;
            //Integrated Security=ture;
            //string constr="Data Source=DESKTOP-OIJACEC;Initial Catalog=itcast2014;Integrated Security=True";
            //string constr = "Data Source=DESKTOP-OIJACEC;Initial Catalog=MyFirstDatabase;Integrated Security=True";
            //创建连接对象
            //using(SqlConnection con=new SqlConnection(constr))
            //{
            //    con.Open();
            //    Console.WriteLine("打开连接成功");
            //}
            //Console.WriteLine("关闭连接释放资源");
            //Console.ReadKey();
            #endregion
            #region 插入数据
            ////创建连接字符串
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated Security=True";
            ////创建连接对象
            //using(SqlConnection con=new SqlConnection(constr))
            //{

            //    //编写sql语句
            //    string sql = "insert into dbo.Class122 values('拾一',110,'2012-03-06','历史')";
            //    //创建执行sql语句的命令对象sqlcommand
            //    using(SqlCommand cmd=new SqlCommand(sql,con))
            //    {
            //        //打开连接
            //        con.Open();
            //        Console.WriteLine("open sucess!");
            //        //cmd.CommandText = sql;
            //        //cmd.Connection = con;
            //        //开始执行sql语句
            //        //cmd.ExecuteNonQuery();//insert\delete\update int类型 表示执行查询语句后所影响的行数  特别注意：只有执行insertdelete update时才会返回影响行数  执行其他语句永远返回负一
            //        //cmd.ExecuteScalar();//当执行返回单个结果时
            //        //cmd.ExecuteReader();//当查询出多行多列时
            //        int r=cmd.ExecuteNonQuery();
            //        Console.WriteLine("cha ru sucess{0}rows",r);
            //    }          
            //}
            //Console.ReadKey();
            #endregion
            #region 删除数据
            ////连接字符串
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated security=true";
            ////连接对象
            //using(SqlConnection con=new SqlConnection(constr))
            //{
            //    //sql语句
            //    string sql = "delete from dbo.Class122 where 学号=10";
            //    //创建命令对象
            //    using(SqlCommand cmd=new SqlCommand(sql,con))
            //    {
            //        //打开连接
            //        con.Open();
            //        Console.WriteLine("sucess!");
            //        //执行
            //        int r=cmd.ExecuteNonQuery();
            //        Console.WriteLine("shou ying xiang hangshu{0}",r);
            //    }

            //}
            //Console.ReadKey();
            #endregion
            #region 修改数据
            ////写连接字符串
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            ////创建连接对象
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    //sql
            //    string sql = "update dbo.Class122 set 成绩=110 where 学号=11";
            //    //创建命令对象
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        //打开连接
            //        con.Open();
            //        Console.WriteLine("sucess!");
            //        //执行
            //        int r = cmd.ExecuteNonQuery();
            //        Console.WriteLine("affect {0} row(s)", r);
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region 查询表中修改条数
            string str = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
            using(SqlConnection con=new SqlConnection(str))
            {
                DataTable myDataTable = new DataTable();
                string sql = "select * from 临床_病程记录存储表";
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            myDataTable.Load(reader);
                        }

                    }
                }
            }
            Console.ReadKey();
            #endregion
        }   
    }
}
