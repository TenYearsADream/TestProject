using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int Call(int num1,int num2);//新建委托
    class Simplemath
    {
        public int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
    }
    class Program
    {            
        static void Main(string[] args)
        {           
            Simplemath objMath = new Simplemath();
            Call objCall = new Call(objMath.Multiply);////创建委托对象,并且传入和委托有一样参数的方法名。
            int result = objCall(5,3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
