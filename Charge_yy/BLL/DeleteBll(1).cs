/****************************
 * 文件名：DeleteBll
 * 命名空间：BLL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/1 16:52:42
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    #region 删除online表用户的信息
    public  class DeleteOnlineBll
    {
        public void  DeleteOnline(Entity.online online)
        {
            Factory.Factory fact = new Factory.Factory();
            IDal.IDeleteOnline deleteOnline = fact.DeleteOnline();
            deleteOnline.DeleteOnline(online);

        }
    }
    #endregion
}
