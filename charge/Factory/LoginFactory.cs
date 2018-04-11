using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DAL;

namespace Factory
{
    public class LoginFactory
    {
        //当是appsettings的时候用
        //string StrDB = System.Configuration.ConfigurationManager.AppSettings["DB"];
        string StrDB = System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString();

        public IDAL.LoginIDAL CreaterUser()
        {
            string ClassName = StrDB + "." + "LoginDAL";
            return (IDAL.LoginIDAL)Assembly.Load(StrDB).CreateInstance(ClassName);
            //DAL.LoginDAL loginDAL
        }
    }
}
