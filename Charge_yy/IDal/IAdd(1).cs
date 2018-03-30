/****************************
 * 文件名：IAdd
 * 命名空间：IDal
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/11 14:40:07
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal
{
    public interface  IAdd
    {
        bool IaddCard(Entity.Card card);
    }
    public interface Iadd
    {
        void iaddOnline(Entity.online online);
    }

    public interface IAddLine
    {
        void IaddLine(Entity.line line);
        void iaddLineOff(Entity.line line);
        void IaddLineOffMoney(Entity.line line);
    }

    public interface IAddStudent
    {
        bool IaddStudent(Entity.Student student);
    }

    //充值
    public interface IaddMoney
    {
        bool IaddMoney(Entity.Charge charge);
        bool ModifyReturn(Entity.ReturnCard returnCard);
    }

    //添加和删除User
    public interface IaddUser
    {
        bool IaddUser(Entity.User user);
        bool IdelUser(Entity.User user);
    }

    //添加正在值班教师和教师工作日志
    public interface IaddWorker
    {
        bool IaddonWorker(Entity.onWork onwork);
        bool IaddWorkerlog(Entity.WorkLog worklog);
        void IdelOnworker(Entity.onWork onwork); //删除值班ing
        void IaddWorkerLogTime(Entity.WorkLog worklog); //补充完值班记录
    }
}   

