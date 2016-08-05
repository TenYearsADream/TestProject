using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread("3", "4"); //构造函数传参

            Thread th = new Thread(new ThreadStart(mt.C));
            th.IsBackground = true;
            th.Start();
            Console.ReadKey();
        }
    }
}
