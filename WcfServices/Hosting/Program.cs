using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Service.Interface;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {

        /// <summary>
        /// 寄宿 采用终结点的通信手段
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost(typeof(CalculatorService)))
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "Http://127.0.0.1:3721/calculatorservice");
                if(host.Description.Behaviors.Find<ServiceMetadataBehavior>()==null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:3721/calculatorservice/metadata");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate
                {
                    Console.WriteLine("Calculator已经启动，按任意键终止服务");
                };
                    host.Open();
                    Console.ReadKey();
               
            }
        }
    }
}
