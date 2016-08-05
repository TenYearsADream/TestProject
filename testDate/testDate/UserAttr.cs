using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDate
{
    class UserAttr
    {
        int userid;
        string name;
        string password;
        string discribe;
        DateTime submittime;
        //UserID, Name, Password, Discribe, SubmitTime
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Discribe
        {
            get { return discribe; }
            set { discribe = value; }
        }
        public DateTime SubmitTime
        {
            get { return submittime; }
            set { submittime = value; }
        }
    }
}
