using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Factory
{
    public class LoginFactory
    {
        string StrDB = System.Configuration.ConfigurationManager.AppSettings["DB"];

        public IDAL.LoginIDAL CreaterUser()
        {
            string ClassName = StrDB + "." + "LoginDAL";
            return (IDAL.LoginIDAL)Assembly.Load(StrDB).CreateInstance(ClassName);
        }
    }
}
