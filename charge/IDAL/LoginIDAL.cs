using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IDAL
{
    public interface  LoginIDAL
    {
        IList<Entity.User_Info> selectUser(Entity.User_Info user_Info);
    }

    public interface ModifyPWD
    {
        bool modify(string UserName, string PassWord);
    }
   

}
