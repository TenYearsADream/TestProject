using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.OpenRead("C:\\Users\\wangxf2\\Desktop\\test.txt");
            byte[] arr = new byte[100];
            while (fs.Read(arr, 0, arr.Length) > 0)
            {
                Console.WriteLine(arr);
            }
            Console.ReadKey();
        }
    }
}
