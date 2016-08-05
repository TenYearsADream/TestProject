using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelDemo
{
    class Program
    {
        delegate int AddDel(int a, int b);
        static void Main(string[] args)
        {
            AddDel del = new AddDel(AddStaticFunc);
            Program p = new Program();
            del += p.AddInstanceFunc;
            int result = del(3, 4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int AddStaticFunc(int a,int b)
        {
            return a + b;
        }
        public int AddInstanceFunc(int a,int b)
        {
            return a + b + 2;
        }
    }
}
