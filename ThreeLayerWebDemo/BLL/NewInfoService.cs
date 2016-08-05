using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewInfoService
    {
        private NewInfoDal newInfoDal = new NewInfoDal();
        public List<NewInfo> GetAllNews()
        {
            return newInfoDal.GetAllNews();
        }
    }
}
