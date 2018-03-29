/****************************
 * 文件名：deleteFacade
 * 命名空间：Facade
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/1 16:58:35
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    #region 删除正在上机的数据 online
   public  class deleteFacade
    {
       public void DeleteOnline(Entity.online online)
       {
           BLL.DeleteOnlineBll deleteOnline = new BLL.DeleteOnlineBll();
           deleteOnline.DeleteOnline(online);

       }
    }
    #endregion
}
