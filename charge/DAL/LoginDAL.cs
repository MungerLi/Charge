using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDAL:IDAL.LoginIDAL 
    {
        public DataTable slectUser(User_Info user_Info)
        {
            SqlParameter[] sqlParams = { new SqlParameter("@userID", user_Info.UserID), new SqlParameter("@PassWord", user_Info.UserName) };
            string sql = @"SELECT *FROM [User_Info] where UserID=@UserID and PWD=@PassWord";
            DataTable table = sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlParams);
            return table;
        }
    }
}
