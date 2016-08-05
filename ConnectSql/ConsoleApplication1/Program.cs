using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string strABC ="a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] ABC = strABC.Split(',');
            int len = ABC.Length;
            Random rd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(ABC[rd.Next(len)]);
            }
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
