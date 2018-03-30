/****************************
 * 文件名：CovertHelper
 * 命名空间：DAL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/8 14:49:47
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace DAL
{
    public class ReturnList<Y> where Y : new()
    {
        public static IList<Y> Returnlist(IList<Y> list)
        {
            return list;
        }
    }
    /// <summary>
    /// 
    /// </summary>
   public  class CovertHelper<T> where T :new()
    {
       public static IList<T> ConvertToModel(DataTable table)
       {
           //定义集合
           IList<T> ts = new List <T>();
           
           //获得此模型的类型
           Type type = typeof(T);
           string tempName = "";

           foreach (DataRow dr in table.Rows)
           {
               T t = new T();
               //获得模型的公共属性
               PropertyInfo[] propertys = t.GetType().GetProperties();

               foreach (PropertyInfo pi in propertys)
               {
                   tempName = pi.Name; //检查datatable是否包含此列

                   if (table .Columns.Contains(tempName))
                   {
                       //判断此属性是否有Setter
                       if (!pi.CanWrite) continue;
                       object value = dr[tempName];

                       if (value != DBNull.Value)
                           pi.SetValue(t, value, null);
                       
                   }
               }
               ts.Add(t);
           }
           return ts;

       }
    }
}
