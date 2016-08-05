using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAddRangeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buffer = new byte[5];
            for(byte i=0;i<5;i++)
            {
                buffer[i] = i;
            }
            List<byte> list=new List<byte>();
            list.Add(1);
            foreach(var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------");
            }
            list.AddRange(buffer);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
