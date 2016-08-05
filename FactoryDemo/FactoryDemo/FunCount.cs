using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    abstract class Operation   //抽象产品
    {
        //public double NumberA;
        //public double NumberB;               
        double _NumberA = Convert.ToDouble(Console.ReadLine());
        double _NumberB = Convert.ToDouble(Console.ReadLine());
        public double NumberA
        {
            get
            {
                return _NumberA;
            }
            set
            {
                value = _NumberA;
            }
        }
        public double NumberB
        {
            get
            {
                return _NumberB;
            }
            set
            {
                value = _NumberB;
            }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class OperationAdd : Operation  //具体产品
    {
        public override double GetResult()
        {
            double result = 0;

            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    class OperationMulti : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            else
            {
                double result = 0;
                result = NumberA / NumberB;
                return result;
            }
        }
    }
}
