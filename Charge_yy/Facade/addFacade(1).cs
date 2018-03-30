/****************************
 * 文件名：addFacade
 * 命名空间：Facade
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/11 15:35:49
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    #region 添加卡片--2017.01.11
   public class addCardFacade
    {
       public bool addCard(Entity.Card card)
        {
            BLL.addCardBLL addCardfacade = new BLL.addCardBLL();
            return  addCardfacade.AddCard(card);
        }
    }
    #endregion

    #region 添加学生上机信息--2017.01.20
   public class addOnlineFacade
   {
       public void addOnline(Entity.online online)
       {
           BLL.addOnlineBLL addonline = new BLL.addOnlineBLL();
           addonline.addOnline(online);
       }
   }

    #endregion

#region 添加上机记录的学生信息--2017.01.20
   public class AddLineFacade
   {
       public void addLine(Entity.line line)
       {
           BLL.AddLineBll AddLine = new BLL.AddLineBll();
           AddLine.addLine(line);

       }

       public void addLineOff(Entity.line line)
       {
           BLL.AddLineBll addLineoff = new BLL.AddLineBll ();
           addLineoff.addLineOff(line);


       }
   }
#endregion

#region 添加学生基本信息--2017.02.12
   public class AddStudentFacade
   {
       public bool addStudent(Entity.Student student)
       {
           BLL.AddStudentBll addStudentinfo = new BLL.AddStudentBll();
           return addStudentinfo.addStudent(student);
       }
   }
#endregion

#region 添加充值和退卡记录--2017-02-12
   public class AddChargeAndReturn
   {
       public bool addCharge(Entity.Charge charge)
       {
           BLL.AddChargeAndReturn addCharge = new BLL.AddChargeAndReturn();
           return addCharge.addCharge(charge);
       }

       public bool addReturn(Entity.ReturnCard returnCard)
       {
           BLL.AddChargeAndReturn addReturn = new BLL.AddChargeAndReturn();
           return addReturn.addReturn(returnCard);
       }
       
   }

#endregion

#region 增加和删除用户
   public class AddVSdelUserFacade
   {
       public bool addUser(Entity.User user)
       {
           BLL.ADDvsDelUserBll addUser = new BLL.ADDvsDelUserBll();
           return addUser.addUser(user);
       }

       public bool delUser(Entity.User user)
       {
           BLL.ADDvsDelUserBll delUser = new BLL.ADDvsDelUserBll();
           return delUser.delUser(user);
       }
   }

#endregion

   #region 添加值班教师ing和日志
   public class AddWorkerFacade
   {
       public bool addOnwork(Entity.onWork onwork)
       {
           BLL.AddWorkerBLL addonwork = new BLL.AddWorkerBLL();
           return addonwork.addonWork(onwork);
       }

       public bool addWorkLog(Entity.WorkLog worklog)
       {
           BLL.AddWorkerBLL addworkLog = new BLL.AddWorkerBLL();
           return addworkLog.addWorkLog(worklog);
       }

       public void delonWorkFac(Entity.onWork onwork)
       {
           BLL.AddWorkerBLL delONwork = new BLL.AddWorkerBLL();
           delONwork.delonwork(onwork);

       }

       public void addWorkLogTime(Entity.WorkLog worklog)
       {
           BLL.AddWorkerBLL addWorklogtime = new BLL.AddWorkerBLL();
           addWorklogtime.addWorklogTime(worklog);
       }
   }

   #endregion

}
