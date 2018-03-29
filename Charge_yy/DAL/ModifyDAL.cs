/****************************
 * 文件名：ModifyDAL
 * 命名空间：DAL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/6 12:22:26
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class CheckPWD : IDal.ICheck
    {


        public IList<Entity.User> SelectUser(Entity.User UserInfo)
        {
            SqlParameter[] sqlParams = { new SqlParameter("@userID", UserInfo.UserID), new SqlParameter("@pwd", UserInfo.PassWord) };
            //SqlParameter[] sqlParams = { new SqlParameter("@userID", UserInfo.UserID) };
            string sql = "select * from User_info where UserID=@userID and PassWord=@pwd";
            //string sql = @"select * from User_info where UserID=@userID";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, sqlParams);
            IList<Entity.User> user = DAL.CovertHelper<Entity.User>.ConvertToModel(table);
            return user;
            //return table;



        }
    }
    class ModifyPWD :IDal.IModify 
    {

        public bool modify(string UserName, string PWD)
        {
            SqlParameter[] sqlParams = { new SqlParameter("@userID", UserName), new SqlParameter("@userPWD", PWD ) };
            string sql = @"update User_info set PassWord =@userPWD  where UserID=@userID";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlParams);
            
        }
    }

#region 更新表card的余额
    class UpdateCardMoneyDAL : IDal.UpdateMoney
    {
      
       
       void IDal.UpdateMoney.modify(Entity.Card card)
        {
            SqlParameter[] sqlparams = {new SqlParameter ("@cardno",card.CardNo ),
                                            new SqlParameter ("@Money",card.Money )};
            string sql = @"update card_info set money = @Money where cardno = @cardno";
            DAL.sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlparams);
        }


       public void modifyState(Entity.Card card) //设置使用状态
       {
           //throw new NotImplementedException();
           SqlParameter[] para = { new SqlParameter ("@cardno",card.CardNo ),
                                     new SqlParameter  ("@notes","未使用")

                                  };
           string sql = "update card_info set notes=@notes";
           DAL.sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
       }
    }
#endregion

 #region 修改学生基本信息--2017-02-07
    class ModifyStudentDal : IDal.ModifyStudentInfo
    {
        public void modify(Entity.Student student)
        {
            //throw new NotImplementedException();
            SqlParameter[] sqlparams = {new SqlParameter ("@StudentName",student.Name ),
                                            new SqlParameter ("@sex",student.Sex ),
                                            new SqlParameter ("@Department",student .Department ),
                                            new SqlParameter ("@grade",student.Grade ),
                                            new SqlParameter ("@class",student.Class ),
                                            new SqlParameter ("@notes",student.Notes ),
                                            new SqlParameter ("@studentno",student.StudentNo )
                                        };
            string sql = "ModifyStudentinfo";
            DAL.sqlhelper.ExecuteNonquery(sql, CommandType.StoredProcedure , sqlparams);
        }
    }
 


#endregion

#region 结账--2017.02.08
    class CheckOutDAL : IDal.CheckOut
    {
        public IList<Entity.Card> select(Entity.Card card)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = {new SqlParameter ("@UserID",card.UserID ),
                                      new SqlParameter ("@Status","未结账" )

                                   };
            string sql = "select * from card_info where userID =@UserID and Status =@Status";
            DataTable table = DAL.sqlhelper.GetDatable (sql,CommandType.Text ,para );
            IList<Entity.Card> LCard = DAL.CovertHelper<Entity.Card>.ConvertToModel(table);
            return LCard;
        }

        public IList<Entity.ReturnCard> select(Entity.ReturnCard Returncard)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { new SqlParameter("@userid", Returncard.UserID ),
                                    new SqlParameter ("@Ischeck","未结账" ),

                                  };
            string sql = "select * from returnCard_info where userID =@userid and Ischeck =@Ischeck";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, para);
            IList<Entity.ReturnCard> LreturnCard = DAL.CovertHelper<Entity.ReturnCard>.ConvertToModel(table);
            return LreturnCard;
        }

        public IList<Entity.Charge> select(Entity.Charge charge)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = {new SqlParameter ("@UserID",charge.UserID ),
                                       new SqlParameter ("@Ischeck","未结账" )
                                   };
            string sql = "select * from charge_info where userID =@UserID and ischeck =@Ischeck";
            DataTable table = DAL.sqlhelper.GetDatable(sql, CommandType.Text, para);
            IList<Entity.Charge > LCharge = DAL.CovertHelper<Entity.Charge >.ConvertToModel(table);
            return LCharge;

        }

        //修改标记状态
        public void ModifyIscheck(string userID)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { new SqlParameter("@userID",userID ) 
                                  };
            string sql = "ModifyIscheck";
            DAL.sqlhelper.ExecuteNoquery (sql, CommandType.StoredProcedure, para);

        }

        //public void addBill (
    }
 
#endregion

#region 设置基本数据
    class ModifyBasicDateDAL : IDal.ModifyBasicDate
    {
        public void ModifyBasicDate(Entity.BasicData basicDate)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { 
                                    new SqlParameter ("@rate",basicDate.Rate ),
                                    new SqlParameter ("@tmprate",basicDate.TmpRate ),
                                    new SqlParameter ("@UntilTime",basicDate.UntilTime ),
                                    new SqlParameter ("@preparyTime",basicDate.PreparyTime ),
                                    new SqlParameter ("@leastmoney",basicDate.LeastMoney )
                                  };
            string sql = "update basicdata_info set rate =@rate,tmpRate=@tmprate,untiltime=@UntilTime,preparytime=@preparyTime,leastmoney=@leastmoney";
            DAL.sqlhelper.ExecuteNonquery (sql,CommandType.Text ,para );

        }
    }
 

#endregion
    
}
