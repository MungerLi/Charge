using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;


namespace BLL
{

   #region 登录信息查询
    public class QueryBLL
    {
        public string  UserBll(Entity.User User)
        {
            Factory.Factory fact = new Factory.Factory(); //实例化工厂
            IDal.ICheck idal = fact.CreateUserInfo(); //调用工厂方法创建接口

           // DataTable table = idal.SelectUser(User); //接受D层的返回值         
           // string  flag;
           //     if (table.Rows.Count == 0) //返回的datatable类型，如果他的行数等于0，说明没有符合该账号密码的用户
           //         { flag = "无用户";}
           //     else 
           //     {
           //         if (table.Rows[0]["PassWord"].ToString() == User.PassWord)
           //         {
           //             flag = "登录成功";
           //         }
           //         else
           //         {
           //             flag = "密码不正确";
           //         }
           //     }
               
           //return flag;

            IList<Entity.User> user = idal.SelectUser(User);
            string flag;
            if (user.Count  == 0) //返回的datatable类型，如果他的行数等于0，说明没有符合该账号密码的用户
            { flag = "无用户"; }
            else
            {
                if (user[0].PassWord  == User.PassWord)
                {
                    flag = "登录成功";
                }
                else
                {
                    flag = "密码不正确";
                }
            }

            return flag;
        }
    }
#endregion

    #region 查询用户的信息
    public class QueryUserbll
    {
        public IList<Entity.User> QueryUser(Entity.User user)
        {
            Factory.Factory queryUserfac = new Factory.Factory();
            IDal.IQueryUser queryUser = queryUserfac.QueryUser();
            return queryUser.select(user);
        }
    }
    #endregion

    # region 查询学生基本信息--2017.01.08
    /// <summary>
    /// 对学生表操作-frmStudent
    /// </summary>
   public class QueryStudentBLL
   {

      
       public IList<Entity.Student> queryStudent (Entity.Student student)
       {
           Factory.Factory fact = new Factory.Factory();
           IDal.IqueryStudnet QueryStudent = fact.QueryStudent();
           IList<Entity.Student> Student = QueryStudent.SelectUser(student);
           return Student;
       }


   }

#endregion
    
 #region 查询学生金额--2017.01.09
   public class QueryMoney
   {
       public IList<Entity.Card> queryMoney(Entity.Card card)
       {
           Factory.Factory fact = new Factory.Factory();
           IDal.IqueryCard querymoney = fact.QueryStudentMoney();
           IList<Entity.Card> Card = querymoney.Select(card);
           return Card;
       }
   }
#endregion

#region 查询卡号是否注册--2017.01.15
   public class IsExitCardno
   {
       public IList<Entity.Card> isexitCardno(Entity.Card card)
       {
           Factory.Factory fact = new Factory.Factory();
           IDal.IqueryCard queryIsExit = fact.IexitCard();
           IList<Entity.Card> Card = queryIsExit.Select(card);
           return Card;

       }
   }
    #endregion

#region 查询是否有卡号--2017.01.19
   public class ExitCardno
   {
       public IList<Entity.Card> exitcardno(Entity.Card card)
       {
           Factory.Factory fact = new Factory.Factory();
           IDal.IqueryCard queryCardno = fact.IExitCardno();
           IList<Entity.Card> lCard = queryCardno.Select(card);
           return lCard;
       }
   }
        
#endregion

#region 查询是否正在上机--2017.01.20
   public class IsOnlineBLL
   {
      
           public IList<Entity.online> Isonline(Entity.online online)
           {
               Factory.Factory fact = new Factory.Factory();
               IDal.IOnline IsOnline = fact.IsOnline();
               IList<Entity.online> lonline = IsOnline.select(online);
               return lonline;
           }
      

   }

#endregion

#region 查询基础数据
   public class QueryBasicDate
   {
       public IList<Entity.BasicData> queryBasicDate(Entity.BasicData basicDate)
       {
           Factory.Factory fact = new Factory.Factory();
           IDal.IqueryBasicdate QuerybasicDate = fact.IqueryBasicDate();
           IList<Entity.BasicData> LbasicDate = QuerybasicDate.select(basicDate);
           return LbasicDate;
       }
   }

#endregion

#region 组合查询
   public class GroupQueryBLL
   {
       public DataTable  GroupQuery(Entity.GroupQuery groupQuery)
       {
           Factory.Factory factoryQueryGroup = new Factory.Factory();
           IDal.IGroupQuery igroupQuery = factoryQueryGroup.GroupQuery();
           //IList<Entity.GroupQuery> LgroupQuery = igroupQuery.select(groupQuery);
           DataTable LgroupQuery = igroupQuery.select(groupQuery);
           return LgroupQuery;


       }
   }
#endregion

#region 查询用户的id和姓名
   public class QueryUserBLL
   {
       public IList<Entity.User> QueryUserbll(Entity.User user)
       {
           Factory.Factory QueryUserFac = new Factory.Factory();
           IDal.IQueryUser QueryUser = QueryUserFac.QueryUser();
           IList<Entity.User> LUser = QueryUser.select(user);
           return LUser;
       }
   }
#endregion

#region 查询onwork，补充worklog
   public class QueryOnworkBll
   {
       public IList<Entity.onWork> queryOnworkbll(Entity.onWork onwork)
       {
           Factory.Factory queryOnworkfac = new Factory.Factory();
           IDal.IqueryOnwork queryOnwork = queryOnworkfac.queryOnwork();
           IList<Entity.onWork> LonWork = queryOnwork.select(onwork);
           return LonWork;
       }
   }

#endregion
}
