using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> funcDemo = new Func<int, int, int>(AddStaticFunc);
            //泛型委托


            #region 匿名方法
            //Func<int,int,int> funcDemo=
            //    delegate(int a, int b) { return a + b; };
           
            #endregion
            #region Lambda
            //Func<int, int, int> funcDemo =
            //    (int a, int b) => { return a + b; };
         
            #endregion
            #region lambda
            Func<int, int, int> funcDemo = (a,b) => a + b;
            #endregion
            int result = funcDemo(3, 4);
            Console.WriteLine(result);
            

            Console.ReadKey();
        }
        static int AddStaticFunc(int a, int b)
        {
            return a + b;
        }
    }
}
