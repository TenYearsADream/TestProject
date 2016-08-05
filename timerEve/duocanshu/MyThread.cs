using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duocanshu
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
        Form1 frm1 = new Form1();
        public void C()
        {
         
        }
    }
}
