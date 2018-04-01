using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class LoginBLL
    {
        public bool UserBLL(Entity.User_Info user_Info)
        {
            bool flag;

            Factory.LoginFactory fact = new Factory.LoginFactory();

            IDAL.LoginIDAL idal = fact.CreaterUser();

            DataTable table = idal.selectUser(user_Info);

            if (table.Rows.Count == 0)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
