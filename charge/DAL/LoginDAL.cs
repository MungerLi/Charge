using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using System.Data.SqlClient;
using IDAL;

namespace DAL
{
    public class LoginDAL:IDAL.LoginIDAL 
    {
        #region
        //public DataTable slectUser(User_Info user_Info)
        //{
        //    SqlParameter[] sqlParams = { new SqlParameter("@userID", user_Info.UserID), new SqlParameter("@PassWord", user_Info.UserName) };
        //    string sql = @"SELECT *FROM [User_Info] where UserID=@UserID and PWD=@PassWord";
        //    DataTable table = sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlParams);
        //    return table;
        //}
        #endregion

#region 登录
        IList<User_Info> LoginIDAL.selectUser(User_Info user_Info)
        {

            //SqlParameter[] sqlParams = { new SqlParameter("@userID", user_Info.UserID), new SqlParameter("@pwd", user_Info.PassWord) };
            SqlParameter[] sqlParams = { new SqlParameter("@UserID", user_Info.UserID)};
            
            string sql = "select * from User_Info where UserID=@UserID ";
            DataTable table =DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlParams);
            
            IList<Entity.User_Info> user = DAL.CovertHelper<Entity.User_Info>.ConvertToModel(table);
            return user;
            
        }
        #endregion

        #region 修改密码
        public bool ModifyPWD(string UserName,string PassWord)
        {
            
            //SqlParameter[] sqlParms = { new SqlParameter ("@UserID",UserName ,)}
            SqlParameter[] sqlParams = { new SqlParameter("@UserID", UserName ),new SqlParameter("@Password",PassWord) };
            string sql=@"updata User_Info set Password=@userPWD where UserID=@UserID";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlParams);
           
        }
        #endregion 
    }
}
