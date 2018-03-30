/****************************
 * 文件名：GroupQuery
 * 命名空间：Entity
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/3 14:37:43
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class GroupQuery
    {
       public GroupQuery()
       {

       }
       public string table { set; get; }

       public object  fileds1 { set; get; } //字段名
       public string fileds2 { set; get; }
       public string fileds3 { set; get; }

       public string Operator1 { set; get; }//操作符
       public string Operator2 { set; get; }
       public string Operator3 { set; get; }

       public object Context1 { set; get; }//输入的内容
       public string Context2 { set; get; }
       public string Context3 { set; get; }

       public string Relation1 { set; get; } //组合关系
       public string Relation2 { set; get; }



    }
}
