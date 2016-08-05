using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class Program
    {  
        public class OperationFactory  //工厂类
        {
            //用抽象产品类创建产品
            public Operation CreateOperate(string operate)
            {
                Operation oper = null;
                switch(operate)
                {
                    case "+":
                        oper=new OperationAdd();
                        break;
                    case "-":
                        oper = new OperationSub();
                        break;
                    case "*":
                        oper = new OperationMulti();
                        break;
                    case "/":
                        oper = new OperationDiv();
                        break;
                    default:
                        break;
                }
                return oper;
            }        
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入：");
                OperationFactory Of = new OperationFactory();
                Operation o = Of.CreateOperate("+");
                Console.WriteLine(o.GetResult());
                Console.ReadKey();
            }



            //while(true)
            //{
            //    List<char> strValue = new List<char>();
            //    string enterNumber = Console.ReadLine();
            //    if (enterNumber.Contains("+"))
            //    {
            //        int i = 0;
            //        foreach (var item in enterNumber)
            //        {
            //            if (item == '+')
            //            {
            //                i = i + 1;
            //            }
            //        }
            //        if (i > 1)
            //        {
            //            Console.WriteLine("输入无效");
            //        }
            //        else
            //        {
            //            string[] tempArry = enterNumber.Split('+');
                       
            //            OperationAdd oper = new OperationAdd();
            //            oper.NumberA = Convert.ToInt32(tempArry[0]);
            //            oper.NumberB = Convert.ToInt32(tempArry[1]);
            //            double result = oper.GetResult();
            //            Console.WriteLine(result);
            //        }
            //    }         
            //}         
        }
    }
}
