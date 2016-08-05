using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace timerspan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(12, 12, 11, 12, 21);
            int days = new TimeSpan(12, 12, 11, 12, 21).Days;
            TimeSpan duration = new TimeSpan(-12, 12, 11, 12, 21).Duration();//24小时的反值
            double totalDays = new TimeSpan(12, 12, 11, 12, 21).TotalDays;
            double totalHours = new TimeSpan(2, 12, 11, 12, 21).TotalHours;
            int hours = new TimeSpan(12, 12, 11, 12, 21).Hours;
            int minutes = new TimeSpan(12, 12, 11, 12, 21).Minutes;
            TimeSpan ts2 = new TimeSpan(1, 3, 01, 12, 21);
            // TimeSpan ts2 = new TimeSpan(5, 3, 1, 12, 21);//this is also right
            TimeSpan ts3 = new TimeSpan(5, 3, 01, 12, 21).Add(ts);
            TimeSpan ts4 = new TimeSpan(4, 3, 01, 12, 21).Subtract(ts);
            TimeSpan ts5 = new TimeSpan(4, 3, 01, 12, 21).Subtract(ts).Duration();
            TimeSpan Negate = new TimeSpan(5, 3, 01, 12, 21).Negate();
            DateTime dtnow = DateTime.Now;
            Console.WriteLine(ts);
            Console.WriteLine(days);
            Console.WriteLine(duration);
            Console.WriteLine(totalDays);
            Console.WriteLine(totalHours);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(ts2);
            Console.WriteLine(ts + ts2);
            Console.WriteLine(ts3);
            Console.WriteLine("Subtract:" + ts4);
            Console.WriteLine("Duration:" + ts5);
            Console.WriteLine(ts - ts2);
            Console.WriteLine(Negate);
            DateTime span = DateTime.Now.Add(ts2);
            TimeSpan spdate = span - DateTime.Now;
            long dateTicks = DateTime.Now.Add(ts2).Ticks;
            Console.WriteLine(span);
            Console.WriteLine(spdate);
            Console.WriteLine(dateTicks);
            Console.ReadKey();
        }
    }
}
