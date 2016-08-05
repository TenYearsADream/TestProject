using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Interface;

namespace Service
{
    public class CalculatorService : ICalculator
    {
        /// <summary>
        /// 创建实现契约接口的服务
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x,double y)
        {
            return x + y;
        }
        public double Subtract(double x,double y)
        {
            return x - y;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
        }
    }
}
