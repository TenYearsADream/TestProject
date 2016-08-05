using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFHost_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建宿主基地址
            Uri baseAddress = new Uri("http://localhost:8733");
            using(ServiceHost host=new ServiceHost(typeof(User),baseAddress))
            {
                //向宿主中添加终结点
                host.AddServiceEndpoint(typeof(IUser), new WSHttpBinding(), "");
                //将HttpGetEnabled属性设置为true
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                //将行为添加到behaviors中
                host.Description.Behaviors.Add(smb);
                //打开宿主
                host.Open();
                Console.WriteLine("WCF中的HTTP监听已经启动....");
                Console.ReadLine();
                host.Close();
            }
         
            
        }
    }
}
