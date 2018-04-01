using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class LoginFacade
    {
        public Boolean SelectUser(Entity.User_Info user)
        {
            bool flag;

            BLL.LoginBLL userBLL = new BLL.LoginBLL();
            flag = userBLL.UserBLL(user);
            return flag;
        }
    }
}
