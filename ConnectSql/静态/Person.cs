using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态
{
    public class Person
    {
        public void M1()
        {
            Console.WriteLine("非静态");
        }
        public static void M2()
        {
            Console.WriteLine("静态");
        }
    }
}
