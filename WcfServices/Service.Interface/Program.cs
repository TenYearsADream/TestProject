using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service.Interface
{
    /// <summary>
    /// 创建服务契约
    /// </summary>
    [ServiceContract(Name = "CalculatorService", Namespace = "http://www.artech.com/")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);
        [OperationContract]
        double Subtract(double x, double y);

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
