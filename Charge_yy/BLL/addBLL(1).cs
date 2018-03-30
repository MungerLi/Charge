/****************************
 * 文件名：addBLL
 * 命名空间：BLL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/11 15:22:12
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    #region 添加学生卡 -2017.01.11
    public  class addCardBLL
    {
        public bool AddCard(Entity.Card card)
        {
            Factory.Factory fact = new Factory.Factory();
            IDal.IAdd addCard = fact.AddCard();

            return addCard.IaddCard(card);

         }
    }
    #endregion

    #region 添加正在上机的学生信息-2017.01.20
    public class addOnlineBLL
    {
        public void addOnline(Entity.online online)
        {
            Factory.Factory fact = new Factory.Factory();
            IDal.Iadd addonline = fact.addOnlie();
            addonline.iaddOnline(online);
        }
    }

    #endregion

#region 添加上机记录的学生信息--2017.01.20
    public class AddLineBll //上机时
    {
        public void addLine(Entity.line line)
        {
            Factory.Factory fact = new Factory.Factory();
            IDal.IAddLine addline = fact.addLine();
            addline.IaddLine(line);

        }

        //下机时
        public void addLineOff(Entity.line line)
        {
            Factory.Factory fact = new Factory.Factory();
            IDal.IAddLine addlineoff = fact.addLine();
            addlineoff.iaddLineOff(line);
        }
    }

    
#endregion

#region 添加学生基本信息
    public class AddStudentBll
    {
        public bool addStudent(Entity.Student student)
        {
            Factory.Factory addStudentfac = new Factory.Factory();
            IDal.IAddStudent addStudent = addStudentfac.addStudent();
            return addStudent.IaddStudent(student);

        }
    }

#endregion

#region 添加充值和退卡记录--2017-02-12
    public class AddChargeAndReturn
    {
        public bool addCharge(Entity.Charge charge)
        {

            //对卡片金额的修改
            Entity.Card card = new Entity.Card();
            card.CardNo = Convert.ToInt16(charge.CardNo);
                //查出来
                    Factory.Factory fact = new Factory.Factory();
                    IDal.IqueryCard queryCardno = fact.IExitCardno();
                    IList<Entity.Card> lCard = queryCardno.Select(card);
               //修改     
                    card.Money = lCard[0].Money + charge.AddMoney;
                    Factory.Factory factUpdateMoney = new Factory.Factory();
                    IDal.UpdateMoney UpdateMoneyBll = factUpdateMoney.Updatemoney();

                    UpdateMoneyBll.modify(card);        
            //在charge实体添加数据
            Factory.Factory addChargefac = new Factory.Factory();
            IDal.IaddMoney addCharge = addChargefac.addChargeAndReturn();
            return addCharge.IaddMoney(charge);

            
                


        }

        public bool addReturn(Entity.ReturnCard returnCard)
        {
            Factory.Factory addReturnfac = new Factory.Factory();
            IDal.IaddMoney addReturn = addReturnfac.addChargeAndReturn();
            return addReturn.ModifyReturn(returnCard);
        }

    }
#endregion

 #region 删除用户，user
    public class ADDvsDelUserBll
    {
        public bool addUser(Entity.User user)
        {
            Factory.Factory addUserfac = new Factory.Factory();
            IDal.IaddUser addUser = addUserfac.AddvsDelUser();
            return addUser.IaddUser(user);
            
        }

        public bool delUser(Entity.User user)
        {
            Factory.Factory delUserfac = new Factory.Factory();
            IDal.IaddUser delUser = delUserfac.AddvsDelUser();
            return delUser.IdelUser(user);
        }
    }
#endregion

#region 添加值班ing教师，和值班日志
    public class AddWorkerBLL
    {
        public bool addonWork(Entity.onWork onwork)
        {
            Factory.Factory addonworkfac = new Factory.Factory();
            IDal.IaddWorker addonwork = addonworkfac.addWorker();
            return addonwork.IaddonWorker(onwork);
        }

        public bool addWorkLog(Entity.WorkLog worklog)
        {
            Factory.Factory addWorkLogfac = new Factory.Factory();
            IDal.IaddWorker addWorklog = addWorkLogfac.addWorker();
            return addWorklog.IaddWorkerlog(worklog);
        }

        public void delonwork(Entity.onWork onwork)
        {
            Factory.Factory delonWorkfac = new Factory.Factory();
            IDal.IaddWorker delOnwork = delonWorkfac.addWorker();
            delOnwork.IdelOnworker(onwork);

        }

        public void addWorklogTime(Entity.WorkLog worklog)
        {
            Factory.Factory addWorklogtimefac = new Factory.Factory();
            IDal.IaddWorker  addworklogtime = addWorklogtimefac.addWorker();
            addworklogtime.IaddWorkerLogTime(worklog);
            
        }
    }


#endregion
}
