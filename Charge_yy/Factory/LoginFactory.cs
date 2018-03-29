/****************************
 * 文件名：LoginFactory
 * 命名空间：Factory
 * 版本号：V1.0.0.0
 * 创建人： 刘雅雯
 * 创建时间：2016/12/21 21:27:31
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration ;
using System.Reflection ;


namespace Factory
{
   public class Factory
    {
        string StrDB = System.Configuration.ConfigurationManager.ConnectionStrings ["DAL"].ToString() ;         //接收来自配置文件的数据

        public IDal.ICheck CreateUserInfo()
        {
            string className = StrDB + "." + "QueryDAL";
            return (IDal.ICheck)Assembly.Load(StrDB).CreateInstance(className);
            
        }

        public IDal.ICheck Checkpwd()
        {
            string className = StrDB + "." + "CheckPWD";
            return (IDal.ICheck)Assembly.Load(StrDB).CreateInstance(className);
        }

        //实现修改密码的接口
        public IDal.IModify  ModifyPWD(string UserName,string PWD)
        {
            string className = StrDB + "." + "ModifyPWD";
            return (IDal.IModify  )Assembly.Load(StrDB).CreateInstance(className);
        }
       /// <summary>
       /// 反射查询学生信息
       /// </summary>
       /// <returns></returns>
        public IDal.IqueryStudnet  QueryStudent()
        {

            string className = StrDB + "." + "StudentDAL";
            return (IDal.IqueryStudnet )Assembly.Load(StrDB).CreateInstance(className);

        }
        public IDal.IqueryCard QueryStudentMoney()
        {
            string className = StrDB + "." + "StudentMoneyDAL";
            return (IDal.IqueryCard)Assembly.Load(StrDB).CreateInstance(className);
        }

        #region 添加新卡的信息
        public IDal.IAdd AddCard()
        {
            string className = StrDB + "." + "addCardDAL";
            return (IDal.IAdd )Assembly.Load(StrDB).CreateInstance(className);
        }
        #endregion

        #region 查询卡号是否注册 ---2017.01.15
        public IDal.IqueryCard IexitCard()
        {
            string className = StrDB + "." + "IsExitCardNoDAL";
            return (IDal.IqueryCard )Assembly.Load(StrDB).CreateInstance(className);
        }
        #endregion

        #region 查询时候有该卡号--2017.01.17
        public IDal.IqueryCard IExitCardno()
       {
           string className = StrDB + "." + "IsExitCardno";
           return (IDal.IqueryCard)Assembly.Load(StrDB).CreateInstance(className);
       }
        #endregion

        #region 添加正在上机的学生信息--2017.01.20
        public IDal.Iadd addOnlie()
        {
            string className = StrDB + "." + "AddOnline";
           return (IDal.Iadd )Assembly.Load(StrDB).CreateInstance(className);
       }
        
        #endregion

        #region 添加上机记录的学生信息--2017.01.20
       
           public IDal.IAddLine addLine()
           {
               string className = StrDB + "." + "AddLine";
               return (IDal.IAddLine )Assembly.Load(StrDB).CreateInstance(className);
           }

        #endregion

        #region 是否正在上机--2017.01.20
        public IDal.IOnline IsOnline()
        {
            string className = StrDB + "." + "IsOnline";
            return (IDal.IOnline )Assembly.Load(StrDB).CreateInstance(className);

        }

        #endregion

        #region 查询上机记录表
        public IDal.IQueryline IqueryLine()
        {
            string className = StrDB + "." + "QuerLine";
            return (IDal.IQueryline )Assembly.Load(StrDB).CreateInstance(className);
        }

        #endregion

        
       #region 查询basicdate的数据--2017.01.23
        public IDal.IqueryBasicdate  IqueryBasicDate()
        {
            string className = StrDB + "." + "BasicDateDAL";
            return (IDal.IqueryBasicdate)Assembly.Load(StrDB).CreateInstance(className);
        }
        #endregion

        #region 更新表card ，更新金额
        
        public IDal.UpdateMoney Updatemoney()
        {
            string className = StrDB + "." + "UpdateCardMoneyDAL";
            return (IDal.UpdateMoney )Assembly.Load(StrDB).CreateInstance(className);
        }

        #endregion

        #region 删除正在上机的记录表
        
        public IDal.IDeleteOnline DeleteOnline()
        {
            string className = StrDB + "." + "DeleteOnlineDAL";
            return (IDal.IDeleteOnline  )Assembly.Load(StrDB).CreateInstance(className);
        }

        #endregion

        #region 组合查询
       
           public IDal.IGroupQuery GroupQuery()
           {
               string className = StrDB + "." + "QueryGroupDal";
               return (IDal.IGroupQuery)Assembly.Load(StrDB).CreateInstance(className);
           }

        #endregion

      #region 修改学生基本信息
         
             public IDal.ModifyStudentInfo modifyStudent()
             {
                 string className = StrDB + "." + "ModifyStudentDal";
                 return (IDal.ModifyStudentInfo)Assembly.Load(StrDB).CreateInstance(className);
             }

        #endregion

        #region 查询user中的用户id和姓名
       
           public IDal.IQueryUser QueryUser()
           {
               string className = StrDB + "." + "QueryUserDAL";
               return (IDal.IQueryUser )Assembly.Load(StrDB).CreateInstance(className);
           }


        #endregion

        #region //结账，对多个表操作
       
           public IDal.CheckOut  checkOut()
           {
               string className = StrDB + "." + "CheckOutDAL";
               return (IDal.CheckOut)Assembly.Load(StrDB).CreateInstance(className);
           }
        #endregion

        #region 添加学生信息
       
           public IDal.IAddStudent addStudent()
           {
               string className = StrDB + "." + "AddStudentDAL";
                 return (IDal.IAddStudent )Assembly.Load(StrDB).CreateInstance(className);
           }

        #endregion

        #region 添加充值和退卡信息
       
           public IDal.IaddMoney addChargeAndReturn()
           {
               string className = StrDB + "." + "IaddAndRturnMoneyDal";
                 return (IDal.IaddMoney  )Assembly.Load(StrDB).CreateInstance(className);
           }

        #endregion

        #region 添加删除用户
           public IDal.IaddUser AddvsDelUser()
           {

               string className = StrDB + "." + "IaddUserDal";
                 return (IDal.IaddUser   )Assembly.Load(StrDB).CreateInstance(className);

           }

        #endregion

        #region 设置基本数据
       
           public IDal.ModifyBasicDate modifyBasicDate()
           {

               string className = StrDB + "." + "ModifyBasicDateDAL";
               return (IDal.ModifyBasicDate )Assembly.Load(StrDB).CreateInstance(className);
           }

        #endregion

        #region 添加值班记录和当值教师记录
           public IDal.IaddWorker addWorker()
           {

               string className = StrDB + "." + "addWorkerDAL";
               return (IDal.IaddWorker  )Assembly.Load(StrDB).CreateInstance(className);

           }

        #endregion

        #region 查询onwork，补充worklog
           public IDal.IqueryOnwork queryOnwork()
           {

               string className = StrDB + "." + "QueryOnwork";
               return (IDal.IqueryOnwork  )Assembly.Load(StrDB).CreateInstance(className);   
           }
        #endregion
    }

   
   
}
