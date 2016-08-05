using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nnArry
{
    class Program
    {
        public static int x;
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i; j++)
                {    
                 
                        Console.Write(j);
                    
                }
                for (int k = 1; k < input - i; k++)
                {
                    Console.Write(i);
                }
            }
            Console.ReadKey();
        }
    }
}
