/****************************
 * 文件名：DeleteDALcs
 * 命名空间：DAL
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/1 16:39:44
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    #region 删除正在上机的记录表
    class DeleteOnlineDAL :IDal.IDeleteOnline 
    {
        

        void IDal.IDeleteOnline.DeleteOnline(Entity.online online)
        {
            
            SqlParameter[] sqlParms = { new SqlParameter("@cardno", online.CardNo) };
            string sql = "delete from online_info where cardno =@cardno";
            DAL.sqlhelper.ExecuteNonquery(sql, CommandType.Text, sqlParms);
        }
    }
    #endregion
}
