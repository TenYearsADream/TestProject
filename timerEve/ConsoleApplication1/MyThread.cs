using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyThread
    {
        public MyThread(string x,string y)
        {
            A = x;
            B = y;
        }
        string a;
        public string A
        {
            get { return a; }
            set { a = value; }
        }
        string b;
        public string B
        {
            get { return b; }
            set { b = value; }
        }
        
        public void C()
        {
            Console.WriteLine("这是{0},那是{1}", A, B);            
        }
    }
}
