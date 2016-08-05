using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFBuyPiao
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]//服务合同 即提供服务的接口和类
    public interface IService1
    {

        [OperationContract] //服务契约 即提供服务的实现方法
        void AddTicket(int count);  //增加车票的方法 

        [OperationContract]
        int BuyTicket(int Num);   //购买车票的方法

        [OperationContract]
        int GetRemainingNum();   //查询车票的方法

        // TODO: 在此添加您的服务操作
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract] //数据契约
    public class Ticket
    {
        bool boolCount = true; //判断是否还有车票
        int howmany = 10; //还有多少车票

        [DataMember]
        public bool BoolCalue  //判断是否还有票
        {
            get { return boolCount; }
            set { 
                if(HowMany>0)
                {
                    boolCount = false;
                }
                else
                {
                    boolCount = true;
                }
            }
        }

        [DataMember]
        public int HowMany
        {
            get { return howmany; }
            set { howmany = value; }
        }
    }
}
