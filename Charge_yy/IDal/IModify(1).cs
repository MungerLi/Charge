/****************************
 * 文件名：IModify
 * 命名空间：IDal
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2016/12/30 20:48:06
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IDal
{
   
        public interface IModify
        {
           bool  modify(string UserName, string PWD);
        }

    //更新表card ，更新余额
        public interface UpdateMoney
        {
           void   modify(Entity.Card card);
           void   modifyState(Entity.Card card); //设置状态，使用为使用


        }
    //修改学生基本信息
        public interface ModifyStudentInfo
        {
            void modify(Entity.Student student);
        }
    //结账
        public interface CheckOut
        {
            IList<Entity.Card> select(Entity.Card card);
            IList<Entity.ReturnCard> select(Entity.ReturnCard Returncard);
            IList<Entity.Charge> select(Entity.Charge charge);

            //标记为已结账
            void  ModifyIscheck(string userID);

        }
   //设置基本参数数据
        public interface ModifyBasicDate
        {
            void ModifyBasicDate(Entity.BasicData basicDate);

        }
    
}
