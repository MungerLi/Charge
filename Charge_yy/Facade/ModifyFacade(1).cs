/****************************
 * 文件名：ModifyFacade
 * 命名空间：Facade
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/6 15:06:56
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public  class ModifyFacade
    {
        public bool CheckPWD(Entity.User user,string pwd)
        {
            BLL.ModifyPWDBLL modifyPWD = new BLL.ModifyPWDBLL();
            return modifyPWD.CheckpwdBLL (user, pwd);
            
        }
    }

    #region 上下机对钱的计算--2017.01.22
    public class CountMoneyFacade
    {
        public IList<Entity.line> CountMoney(Entity.line line)
        {
            BLL.OffLineBLL  Countmoney =new BLL.OffLineBLL ();
            return Countmoney.CountMoney(line);

        }
    
    }

    #endregion

#region 更新表card， 跟新金额
    public class UpdateMoneyFacade
    {
        public void  UpdateMoney(Entity.Card card)
        {
            BLL.UpdateMoneyBLL updateMoney = new BLL.UpdateMoneyBLL();
            updateMoney.UpdateMoney(card);

        }

        public void ModifyState(Entity.Card card)
        {
            BLL.UpdateMoneyBLL modifyState = new BLL.UpdateMoneyBLL();
            modifyState.ModifyStatus(card);
        }
    }
#endregion

#region 更新表studentinfo 修改学生基本信息
    public class ModifyStudentinfoFacade
    {
        public void ModifyStudent(Entity.Student student)
        {
            BLL.ModifyStudentBLL modifyStudent = new BLL.ModifyStudentBLL();
            modifyStudent.ModifyStudent(student);
        }
    }
#endregion

#region 结账，对多个表进行操作
    public class CheckOutFacade
    {
        //对注册表
        public IList<Entity.Card> checkOutCard(Entity.Card card)
        {
            BLL.CheckOutBLL checkOutcard = new BLL.CheckOutBLL();
            return checkOutcard.checkOutCard(card);
        }

        //对退卡表的操作
        public IList<Entity.ReturnCard> CheckOutReturnCard(Entity.ReturnCard returnCard)
        {
            BLL.CheckOutBLL checkOutReturnCard = new BLL.CheckOutBLL();
            return checkOutReturnCard.CheckReturnCard(returnCard);
        }

        //对充值表的操作
        public IList<Entity.Charge> checkOutCharge(Entity.Charge charge)
        {
            BLL.CheckOutBLL checkOutcharge = new BLL.CheckOutBLL();
            return checkOutcharge.CheckCharge(charge);
        }

        //设置表是否操作
        public void ModifyIsCheckOut(string userID)
        {
            BLL.CheckOutBLL modifyIsCheckout = new BLL.CheckOutBLL();
            modifyIsCheckout.ModifyIsCheckOut(userID);
        }
    }

#endregion

#region 修改基本数据
    public class ModifyBasicDate
    {
        public void modifyBasicFacade(Entity.BasicData basicDate)
        {
            BLL.ModifyBasicDateBll modifyBasic = new BLL.ModifyBasicDateBll();
            modifyBasic.modifyBasicDate(basicDate);
        }
        
        
    }
#endregion
}
