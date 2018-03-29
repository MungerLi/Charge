/****************************
 * 文件名：onWork
 * 命名空间：Entity
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/2/13 20:46:15
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public   class onWork
    {
        public string UserID { set; get; }
        public string Level { set; get; }
        public string Computer { set; get; }
        public DateTime logindate { set; get; }
        public TimeSpan  logintime { set; get; }
        public onWork()
        {

        }
    }
}
