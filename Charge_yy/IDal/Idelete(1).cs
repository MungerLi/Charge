/****************************
 * 文件名：Idelete
 * 命名空间：IDal
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/1 16:36:38
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal
{
    //删除正在上机的记录
    public interface IDeleteOnline
    {
       void DeleteOnline(Entity.online online );

    }
}
