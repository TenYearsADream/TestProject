using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        //Main程序入口 clr一开始就会创建一个默认的主线程(前台线程)，指向了main方法
        static void Main(string[] args)
        {
            //treadstrart
            Thread thread = new Thread(delegate() { 
            while(true)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(500);
            }
            });
            //线程默认是前台线程，一个进程退出标志：所有的前台线程都结束之后，
            thread.IsBackground = true;//加了这句
            thread.Priority = ThreadPriority.Highest;
            Console.WriteLine(thread.ManagedThreadId);
            //后台线程不会阻塞进程的退出。
            thread.Start();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //主线程也不断的输出
            while(true)
            {
                Console.WriteLine("from  主线程----");
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
