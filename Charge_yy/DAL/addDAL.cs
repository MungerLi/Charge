/****************************
 * 文件名：addDAL
 * 命名空间：DAL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/11 14:39:12
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
    #region 添加卡片信息--2017-01-11
    class addCardDAL :IDal.IAdd 
    {

        public bool IaddCard(Entity.Card card)
        {
            SqlParameter[] sqlParms = { new SqlParameter("@Cardno", card.CardNo),
                                          new SqlParameter ("@Studentno",card.StudentNo ),
                                          new SqlParameter ("@money",card.Money ),
                                          new SqlParameter ("@Type",card.Type ),
                                          new SqlParameter  ("@Ischeck",card.Status ),
                                          new SqlParameter ("@Note" ,card.Notes),
                                          new SqlParameter ("@userid",card.UserID )   
                                      };
            string sql = "insert into card_info values(@Cardno,@money,@Type,@Note,@Ischeck,@Studentno,@userid)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text,sqlParms  );
        }
    }
    #endregion

    #region 添加正在上机的卡号学生信息--2017.01.19
    class AddOnline : IDal.Iadd
    {
        public void iaddOnline(Entity.online online)
        {
            SqlParameter [] sqlparas = {new SqlParameter ("@cardno",online.CardNo ),
                                           new SqlParameter ("@studentno",online.StudentNo ),
                                           new SqlParameter ("@studentName",online.studentname ),
                                           new SqlParameter("@sex",online.studentsex ),
                                           new SqlParameter ("@cardtype",online.cardType ),
                                           new SqlParameter ("@computer",online.Computer ),
                                           //new SqlParameter ("@ondate",online.ondate ),
                                          // new SqlParameter  ("@ontime",online.ontime)

                                       };
            string sql= "insert into online_info(cardno,studentno,studentname,sex,cardtype,computer) values(@cardno,@studentno,@studentName,@sex,@cardtype,@computer)";
            sqlhelper.ExecuteNoquery(sql, CommandType.Text, sqlparas);
        }
    }
 

    #endregion

#region 添加上机记录的学生信息--2017.01.20
    class AddLine : IDal.IAddLine
    {
        //上机时添加学生信息
        public void IaddLine(Entity.line line)
        {
            SqlParameter[] sqlparas = {new SqlParameter ("@cardno",line.CardNo ),
                                           new SqlParameter ("@ondate",line.LoginDate ),
                                           new SqlParameter ("@ontime",line.LoginTime ),
                                          // new SqlParameter ("@userId",line.UserID ), //暂时去掉了，因为登录窗体没有使用,zhuyi后来考虑不合适删了
                                           new SqlParameter ("@Status",line.Status),
                                           new SqlParameter ("@studentno",line.StudentNo ),
                                           new SqlParameter ("@studentname",line.StudentName),
                                           new SqlParameter ("@computer",line.Computer ),
                                           new SqlParameter ("@sex",line.sex )

                                      };
            string sql = "insert into line_info(cardno,logindate,logintime,status,studentno,studentname,computer,sex) values(@cardno,@ondate,@ontime,@Status,@studentno,@studentname,@computer,@sex)";
            sqlhelper.ExecuteNoquery(sql, CommandType.Text, sqlparas);
            
        }

        //下机时添加学生信息 --添加时间  

        public void iaddLineOff(Entity.line line)
        {
            
            SqlParameter[] sqlparas = {
                                          new SqlParameter ("@Cardno",line.CardNo ),
                                          new SqlParameter ("@loginDate",line.LoginDate ),
                                          new SqlParameter ("@logintime",line.LoginTime ),
                                          new SqlParameter ("@status",line.Status )
                                          
                                       };
            string sql = "update line_info set offdate = getdate(),offtime = getdate(), status =@status where cardno = @Cardno and logindate = @loginDate and logintime=@logintime";
            sqlhelper.ExecuteNoquery(sql, CommandType.Text, sqlparas);
        }

        //下机时添加学生信息--添加金额--2017.01.24



        public void IaddLineOffMoney(Entity.line line)
        {
            SqlParameter[] sqlparas = {
                                          new SqlParameter ("@Cardno",line.CardNo ),
                                          new SqlParameter ("@loginDate",line.LoginDate ),
                                          new SqlParameter ("@logintime",line.LoginTime ),
                                          new SqlParameter ("@ConsumeTime",line.ConsumeTime ),
                                          new SqlParameter ("@consumeMoney",line.ConsumeMoney ),
                                          new SqlParameter ("@money",line.Money )
                                      };
            string sql = "update line_info set consumetime=@ConsumeTime,consumemoney=@consumeMoney,money =@money where cardno = @Cardno and logindate = @loginDate and logintime=@logintime";
            sqlhelper.ExecuteNoquery(sql, CommandType.Text, sqlparas);
            
        }
    }
 

#endregion

#region 添加学生信息--2017.02.12
    class AddStudentDAL : IDal.IAddStudent
    {
        public bool  IaddStudent(Entity.Student student)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = {new SqlParameter ("@StudentID",student.StudentNo ),
                                    new SqlParameter ("@studentname",student.Name ),
                                    new SqlParameter ("@grade",student.Grade ),
                                    new SqlParameter ("@sex",student.Sex ),
                                    new SqlParameter ("@class",student.Class ),
                                    new SqlParameter ("@department",student.Department ),
                                    new SqlParameter ("@notes",student.Notes)
                                   };
            string sql = "insert into student_info values(@StudentID,@studentname,@sex,@department,@grade,@class,@notes)";
            return   sqlhelper.ExecuteNonquery(sql,CommandType.Text, para );
        }
    }
 
#endregion

#region 充值和退卡的处理,分别向退卡和充值卡中添加一条记录--2017-02-12
    class IaddAndRturnMoneyDal : IDal.IaddMoney
    {
        public bool IaddMoney(Entity.Charge charge)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { new SqlParameter("@cardno", charge.CardNo) ,
                                    new SqlParameter ("@studentNO",charge.StudentNo ),
                                    new SqlParameter ("@UserID",charge.UserID ),
                                    new SqlParameter ("@Addmoney",charge.AddMoney ),
                                    new SqlParameter ("@ischeck","未结账" )
                                  };
            string sql = "insert into charge_info(cardno1,studentno,userid,addmoney,ischeck) values(@cardno,@studentNO,@UserID,@Addmoney,@ischeck)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
        }

        public bool ModifyReturn(Entity.ReturnCard returnCard)
        {
            //throw new NotImplementedException();
            SqlParameter [] para={
                                     new SqlParameter ("@cardno",returnCard.CardNo ),
                                     new SqlParameter ("@userID",returnCard.UserID ),
                                     new SqlParameter ("@returnMoney",returnCard.ReturnMoney ),
                                     new SqlParameter ("@Ischeck",returnCard.IsCheck )
                                 };
            string sql = "insert into returnCard_info(cardno,userid,returnMoney,ischeck) values(@cardno,@userID,@returnMoney,@Ischeck)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
                                  
        }
    }
 

#endregion

#region 删除和添加用户
    class IaddUserDal : IDal.IaddUser
    {
        public bool IaddUser(Entity.User user)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { new SqlParameter ("@userid",user.UserID),
                                    new SqlParameter ("@username",user.UserName ),
                                    new SqlParameter ("@password",user.PassWord ),
                                    new SqlParameter ("@level",user.Level ),
                                    new SqlParameter ("@head",user.Head)
                                
                                };
            string sql = "insert into user_info values(@userid,@username,@password,@level,@head)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
        }

        public bool IdelUser(Entity.User user)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = { new SqlParameter("@userid", user.UserID) };
            string sql = "delete from user_info where userID =@userid";
            return sqlhelper .ExecuteNonquery(sql,CommandType.Text, para);
        }
    }
 

#endregion

#region 添加正在上机教师,对worklog ，onworklog
    class addWorkerDAL : IDal.IaddWorker
    {
        public bool IaddonWorker(Entity.onWork onwork)
        {
            //throw new NotImplementedException();
            SqlParameter[] para = {
                                      new SqlParameter ("@userID",onwork .UserID ),
                                      new SqlParameter ("@level",onwork.Level ),
                                      new SqlParameter ("@computer",onwork.Computer )
                                   };
            string sql = "insert into onwork_info(userID,level,computer) values(@userID,@level,@computer)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
        }

        public bool IaddWorkerlog(Entity.WorkLog worklog)
        {
           // throw new NotImplementedException();
            SqlParameter[] para ={
                                     new SqlParameter ("@userID",worklog.UserID ),
                                     new SqlParameter ("@level",worklog .Level ),
                                     new SqlParameter ("@computer",worklog.Computer ),
                                     new SqlParameter ("@status",worklog.Status )

                                  };
            string sql = "insert worklog_info(userid,level,computer,status) values(@userID,@level,@computer,@status)";
            return sqlhelper.ExecuteNonquery(sql, CommandType.Text, para);
        }





        public void IdelOnworker(Entity.onWork onwork)
        {
            SqlParameter[] para = { new SqlParameter("@userID", onwork.UserID) };
            string sql = "delete from onwork_info where userID=@userID";
            sqlhelper.ExecuteNoquery(sql, CommandType.Text, para);
        }

        public void IaddWorkerLogTime(Entity.WorkLog worklog)
        {
            SqlParameter[] para = {
                                      new SqlParameter ("@userid",worklog.UserID ),
                                      new SqlParameter ("@level",worklog.Level ),
                                      new SqlParameter ("@logdate",worklog.LogDate ),
                                      new SqlParameter ("@logtiem",worklog.LogTime ),
                                      new SqlParameter ("@computer",worklog.Computer ),
                                      new SqlParameter ("@status","正常下机" )
                                      //new SqlParameter ("@offdate",worklog.OffDate ),
                                      //new SqlParameter ("@offtime",worklog.OffTime )
                                   };
            string sql = "update worklog_info set offdate=getdate(),offtime=getdate(),status=@status where userid=@userid and level=@level and logdate=@logdate and logtime=@logtiem";
            sqlhelper.ExecuteNoquery(sql,CommandType.Text ,para);
        }
    }
 
#endregion




}
