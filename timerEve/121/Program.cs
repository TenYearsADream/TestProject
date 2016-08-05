﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperMarket.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            myTests mt = new myTests();
            mt.RunTest();

        }

    }
    class myTests
    {
        char last = 'c';
        object obj = new object();
        public void RunTest()
        {
            Thread th1 = new Thread(ShowNum);
            Thread th2 = new Thread(ShowNum);
            Thread th3 = new Thread(ShowNum);

            th1.Start('a');
            th2.Start('b');
            th3.Start('c');

            

            Console.ReadKey();
        }

        private void ShowNum(object name)
        {
            for (int i = 0; i < 300; i++)
            {
                lock (obj)
                {
                    if ((Char)name == last + 1 || (Char)name == last - 2)//如果是连续的下一个字 acii
                    {
                        Console.WriteLine(name);
                        last = (Char)name;
                        Monitor.PulseAll(obj);         
                    }
                    else
                    {
                        i--;
                        Monitor.Wait(obj);
                    }
                }
            }           
        }
        
    }

}