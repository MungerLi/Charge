/****************************
 * 文件名：ISelectUser
 * 命名空间：IDal
 * 版本号：V1.0.0.0
 * 创建人：Viola
 * 创建时间：2016/12/23 11:24:28
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IDal
{
     public interface  ICheck
    {
         IList <Entity.User > SelectUser(Entity.User user);
        
    }

     public interface IqueryStudnet
     {
        IList <Entity.Student> SelectUser(Entity.Student student);
     }

    //查询余额--card_info
     public interface IqueryCard
     {
         IList <Entity.Card >Select(Entity.Card card);
     }
    
    //查询是否正在上机
     public interface IOnline
     {
         IList<Entity.online> select(Entity.online online);
     }

    //查询上机记录
     public interface IQueryline
     {
         IList<Entity.line> select(Entity.line line);
     }

    //查询basicdate数据
     public interface IqueryBasicdate
     {
         IList<Entity.BasicData> select(Entity.BasicData basicdate);
     }
    
    //查询worklog 组合查询
     public interface IGroupQuery
     {
         DataTable  select(Entity.GroupQuery GroupCheck);
     }

    //查询 user 结账
     public interface IQueryUser
     {
         IList<Entity.User> select(Entity.User user);
     }
    
    //查询 onwork
     public interface IqueryOnwork
     {
         IList<Entity.onWork > select(Entity.onWork onwork);

     }
    
}
