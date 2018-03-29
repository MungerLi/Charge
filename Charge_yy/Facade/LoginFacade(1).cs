/****************************
 * 文件名：LoginFacade
 * 命名空间：Facade
 * 版本号：V1.0.0.0
 * 创建人：刘雅雯
 * 创建时间：2016/12/23 10:53:10
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Facade
{
  public  class LoginFacade
    {
      /// <summary>
      /// 判断用户信息是否有误
      /// </summary>
      /// <param name="user"></param>
      /// <returns></returns>
      public string  loginfacade(Entity.User user)
      {
          BLL.QueryBLL ConfirmUserBLL = new BLL.QueryBLL();
          return ConfirmUserBLL.UserBll(user);
      }
        #region 查询用户信息
      public class QueryUserFAC
      {
          public IList<Entity.User> queryUser(Entity.User user)
          {
              BLL.QueryUserbll queryUser = new BLL.QueryUserbll();
              return queryUser.QueryUser(user);
          }
      }

        #endregion

        #region 查看学生基本信息--2017.01.08
    }
    /// <summary>
    /// 学生表-frmstudent
    /// </summary>
  public class StudentFacade
  {
      //public bool  studentfacade(Entity.Student student)
      //{
      //    BLL.QueryStudentBLL queryStudent = new BLL.QueryStudentBLL();
      //    return queryStudent.QuerystudentBLL(student);
      //}
      public IList<Entity.Student> studentfacade(Entity.Student student)
      {
          BLL.QueryStudentBLL queryStudent = new BLL.QueryStudentBLL();
          return queryStudent.queryStudent(student);
      }
  }
#endregion 

#region 查看学生余额 --2017.01.09
  public class StudentMoneyFacade
  {
      public IList<Entity.Card> StudentMoney(Entity.Card card)
      {
          BLL.QueryMoney quermoney = new BLL.QueryMoney();
          return quermoney.queryMoney(card);
      }
  }
#endregion

#region 查询卡号是否注册--2017.01.17
    public class QuerIesitCardno
    {
        public IList<Entity.Card> QuerIsexitcardno(Entity.Card card)
        {
            BLL.IsExitCardno querIsexitCardno = new BLL.IsExitCardno();
            return querIsexitCardno.isexitCardno(card);
        }
    }

#endregion

#region 是否有该卡号--2017.01.19
    public class QueyExitCardno
    {
        public IList<Entity.Card> queryExitCardno(Entity.Card card)
        {
            BLL.ExitCardno exitCardno = new BLL.ExitCardno();
            return exitCardno.exitcardno(card);
        }
    }
#endregion

#region 查询是否正在上机--2017.01.20
    public class IsOnlineFacade
    {
        public IList<Entity.online> IsOnline(Entity.online online)
        {
            BLL.IsOnlineBLL Isonline = new BLL.IsOnlineBLL();
            return Isonline.Isonline(online);
        }
        
    }

#endregion
       
#region 查询基本数据信息
    public class QueryBasicDateFacade
    {
        public IList<Entity.BasicData> QueryBasicDate(Entity.BasicData basicdate)
        {
            BLL.QueryBasicDate queryBasicDate = new BLL.QueryBasicDate();
            return queryBasicDate.queryBasicDate(basicdate);

        }
    }

#endregion

#region 组合查询
    public class GroupQueryFacade
    {
        public DataTable  GroupQuery(Entity.GroupQuery groupQuery)
        {
            BLL.GroupQueryBLL groupquery = new BLL.GroupQueryBLL();
            return groupquery.GroupQuery(groupQuery);

        }
    }
#endregion

#region 查询user的id和用户名
    public class QueryUserFacade
    {
        public IList<Entity.User> QueryUser(Entity.User user)
        {
            BLL.QueryUserBLL queryUser = new BLL.QueryUserBLL();
            return queryUser.QueryUserbll(user);

        }
    }

#endregion

#region 查询onwork，补充WORKLOG
    public class QueryOnworkFac
    {
        public IList <Entity.onWork > queryOnwork(Entity.onWork onwork)
        {
            BLL.QueryOnworkBll queryonwork =new BLL.QueryOnworkBll ();
            return queryonwork.queryOnworkbll(onwork);
        }
    }
#endregion

}
