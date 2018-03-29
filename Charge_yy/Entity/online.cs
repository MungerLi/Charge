/****************************
 * 文件名：online
 * 命名空间：Entity
 * 版本号：V1.0.0.0
 * 创建人：$刘雅雯$
 * 创建时间：2017/1/19 22:38:06
 * 修改日志：
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class online
    {
        public int CardNo { set; get; }
        public int StudentNo { set; get; }
        public string  studentname { set; get; }
        public string  studentsex { set; get; }
        public DateTime  ondate { set; get; }
        public TimeSpan    ontime { set; get; }
        public string cardType { set; get; }
       
        
        public string Computer { set; get; }
        public online()
        {
        }
       
    }
}
