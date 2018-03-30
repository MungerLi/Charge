/****************************
 * 文件名：ModifyPWD
 * 命名空间：BLL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2016/12/30 20:41:31
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data;

namespace BLL
{
   public  class ModifyPWDBLL
    {
       public bool CheckpwdBLL(Entity.User user,string PWD)
       {
           Factory.Factory fact = new Factory.Factory();
           //IDal.ICheck ICheck = fact.CreateUserInfo();
           IDal.ICheck ICheck = fact.Checkpwd();

           //接受D层的参数
          // DataTable table =ICheck .SelectUser (user );
           //DataTable table = ICheck.SelectUser(user);
           IList<Entity.User> User = ICheck.SelectUser(user);
           bool flag;
           if (User.Count  == 0)
                { flag = false; }
           else
                {
                    this.ModifyPassWordBLL(user.UserID, PWD);
                    flag =true ;
                }
           return flag ;

           

       }
         //修改当前用户的密码
       public bool  ModifyPassWordBLL(string UserName, string PWD)
       {
           Factory.Factory fact = new Factory.Factory();         
           IDal.IModify imodify = fact.ModifyPWD(UserName, PWD);
           return imodify.modify(UserName, PWD);


           //DataTable table = imodify.modify(UserName, PWD);
           //bool flag;
           //flag = false;
           //if (table.Rows.Count > 0)
           //    { flag = true; }
          
           //return flag;
           
       }
    }

   #region 下机--2017.01.22
   public class OffLineBLL
   {
       Entity.BasicData basicDate = new Entity.BasicData();
      public IList <Entity.line > CountMoney (Entity.line line )
      {
          //得到上机记录的数据
          Factory.Factory fact = new Factory.Factory();
          IDal.IQueryline QueryLine = fact.IqueryLine();
          IList<Entity.line> Lline = QueryLine.select(line);

          //得到basicdate的数据
          Factory.Factory factBasic = new Factory.Factory();
          IDal.IqueryBasicdate QueryBasicDate = factBasic.IqueryBasicDate();
          IList<Entity.BasicData> LbasicDate = QueryBasicDate.select(basicDate);

          //计算时间差
          int ConsumeTime;
          int ConsumeMoney;
          TimeSpan date = Lline[0].OffDate - Lline[0].LoginDate;
          TimeSpan time = Lline[0].OffTime - Lline[0].LoginTime;
          int min =Convert.ToInt16 ( date.TotalMinutes) + Convert .ToInt16 (time.TotalMinutes );

                //比较准备时间
          if (min < LbasicDate[0].PreparyTime)
          { ConsumeTime = 0; }
          else
          {
              if ((min - LbasicDate[0].PreparyTime) < 30)
              { ConsumeTime = 30; }
              else
              { ConsumeTime = min - LbasicDate[0].PreparyTime; }
             
          }
          //计算钱
          if (Lline[0].Status == "固定用户")
          { ConsumeMoney = LbasicDate[0].Rate / 2 * (ConsumeTime / 30); }

          else
          {
              //if (Lline[0].Status == "临时用户")
               ConsumeMoney = LbasicDate[0].TmpRate / 2 * (ConsumeTime / 30); 
          }
          //将金额放入line表中，同时显示到窗体上。
          line.ConsumeMoney = ConsumeMoney;
          line.ConsumeTime = ConsumeTime;
          line.Money = (Convert.ToInt16(line.Money )- (Convert.ToInt16(ConsumeMoney)));
          
          Factory.Factory factLineMoney = new Factory.Factory();
          IDal.IAddLine AddLineMoney = factLineMoney.addLine();
          AddLineMoney.IaddLineOffMoney(line);

          IList<Entity.line> lineAll = QueryLine.select(line);
          return lineAll ;
      }

    

       //算钱
   }

   #endregion

#region 更新表card ，跟新金额
   public class UpdateMoneyBLL
   {
       public void  UpdateMoney(Entity.Card card)
       {
           Factory.Factory factUpdateMoney = new Factory.Factory ();
           IDal.UpdateMoney UpdateMoneyBll = factUpdateMoney.Updatemoney();
          
           UpdateMoneyBll.modify(card);
          
       }

       public void ModifyStatus(Entity.Card  card)
       {
           Factory.Factory ModifyStatusfac = new Factory.Factory();
           IDal.UpdateMoney ModifyStatus = ModifyStatusfac.Updatemoney();
           ModifyStatus.modifyState(card);
       }
       
   }

#endregion

#region 修改表student_info 修改学生基本信息
   public class ModifyStudentBLL
   {
       public void ModifyStudent(Entity.Student student)
       {
           Factory.Factory ModifyStudentFac = new Factory.Factory();
           IDal.ModifyStudentInfo modifyStudent = ModifyStudentFac.modifyStudent();
           modifyStudent.modify(student);
       }
   }

#endregion

#region 结账，修改多张表 --2017.02.10
   public class CheckOutBLL
   {
       //对注册表操作
       public IList<Entity.Card > checkOutCard(Entity.Card card)
       {
           Factory.Factory checkOutCardfac = new Factory.Factory();
           IDal.CheckOut checkOut = checkOutCardfac.checkOut();
           IList<Entity.Card> LCard = checkOut.select(card);
           return LCard;
       }

       //对退卡表的操作
       public IList<Entity.ReturnCard> CheckReturnCard(Entity.ReturnCard returnCard)
       {
           Factory.Factory checkReturnCardfac = new Factory.Factory();
           IDal.CheckOut checkReturnCard = checkReturnCardfac.checkOut();
           IList<Entity.ReturnCard> LReturnCard = checkReturnCard.select(returnCard);
           return LReturnCard;
       }

       //对充值表的操作
       public IList<Entity.Charge> CheckCharge(Entity.Charge charge)
       {
           Factory.Factory checkOutchargefac = new Factory.Factory ();
           IDal.CheckOut checkOutCharge = checkOutchargefac.checkOut();
           IList<Entity.Charge> Lcharge = checkOutCharge.select(charge);
           return Lcharge;
       }

       //设置是否结账
       public void ModifyIsCheckOut(string userID)
       {
           Factory.Factory ModifyIsCheckOutfac = new Factory.Factory();
           IDal.CheckOut modifyIsCheckOut = ModifyIsCheckOutfac.checkOut();
           modifyIsCheckOut.ModifyIscheck(userID);
          
       }
   }
#endregion

#region 设置基本数据
   public class ModifyBasicDateBll
   {
       public void modifyBasicDate(Entity.BasicData basicDate)
       {
           Factory.Factory modifyBasicfac = new Factory.Factory ();
           IDal.ModifyBasicDate modifyBasic = modifyBasicfac.modifyBasicDate ();
           modifyBasic.ModifyBasicDate(basicDate);
       }
   }

#endregion
}
