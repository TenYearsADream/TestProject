using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuteReaderFun
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SqlDataReader
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated security=true";
            //using(SqlConnection con=new SqlConnection(constr))
            //{
            //    string sql = "select * from dbo.Class122";
            //    using(SqlCommand cmd=new SqlCommand(sql,con))
            //    {
            //        con.Open();
            //        //通过调用ExcuteReader()方法。给指定的sql语句在服务器端执行
            //        //执行完毕后，服务器端就已经查询出了数据。但是数据时保存在数据库服务器中
            //        //并没有返回给应用程序。只是返回给应用程序一个reader对象，这个对象用来获取数据的对象
            //        using(SqlDataReader reader=cmd.ExecuteReader())
            //        {
            //            //接下来通过reader对象一条一条获取数据
            //            //在获取数据之前，先判断一下本次查询后，是否查询导数据
            //            if(reader.HasRows)//判断是否查询到数据
            //            {
            //                //每次获取数据之前要先调用reader。read，向后移动一次，如果成功移动到了某条数据上，则返回true，否则返回false
            //                while(reader.Read())
            //                {
            //                    //reader.Fieldcount 可以查询出列的个数
            //                    for(int i=0;i<reader.FieldCount;i++)
            //                    {
            //                        //reader.GetINT()使用强类型
            //                        //reader[]索引器来获取列值，拿到的是DBNULL.value  不是NULL。二DBNULL.value的tostring返回的是空字符串，所以没有报错
            //                        //reader.GetOrdinal();//更具列名获取列索引
            //                        Console.Write(reader[i] + "        ");
            //                        //getvalue只能通过列索引来获取列的值
            //                        //但是reader[i]索引器，可以使用列名来获取列的值reader["列名"]
            //                        //Console.Write(reader.GetValue(i)+"        ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //            }
            //            else
            //            {

            //                Console.WriteLine("There are not data!");
            //            }
            //        }
            //    }
            //    Console.ReadKey();
            //}
            #endregion


            #region 22222
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from dbo.Class122";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    //通过调用Executereader（）方法将给定的sql语句在服务器端执行。执行完毕后，数据时保存在服务器的内存中。并没有返回给应用程序。只是返回给应用程序一个renader对象。这个对象时用来获取数据的
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //reader.FieldCount可以获取出查询列的个数
                                //reader[i] object类型
                                //getvalues()只能通过列索引获取列的值
                                //但是reader【】可以通过列名来获取列的值；
                                //getordinal根据列的名称获取索引值；
                                Console.Write(reader.GetInt32(0) + "\t|\t");
                                Console.Write(reader.GetString(1) + "\t|\t");
                                Console.Write(reader.GetInt32(2) + "\t|\t");
                                Console.Write(reader.GetDateTime(3) + "\t|\t");
                                Console.Write(reader.GetString(4) + "\t|\t");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            #endregion
            Console.ReadKey();
            }
        }
    }
}
