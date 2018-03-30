using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class program
    {
        [STAThread] //单元线程，瞬间高大上了很多的样子
        static void Main()
        {
            Application .EnableVisualStyles ();
            Application .SetCompatibleTextRenderingDefault (false);
            Application .Run(new frmLogin ());  //启动项为登录
           //Application.Run(new frmMain()); //启动项为main窗体

           //Application.Run(new frmGroupQuery ());//启动项为组合查询窗体
           
           //Application.Run(new frmGroupOperator()); //启动项为工作记录查询
           //Application.Run(new frmOnlineQuery());  //启动项为学生上机记录查询，组合查询
           //Application.Run(new frmStudentGroupQ()); //启动 学生基本信息维护，组合查询
           //Application.Run(new frmCheckOut());  //启动 结账
           // Application.Run(new frmBill()); //启动结账
           // Application.Run(new frmStudent()); //启动学生窗体
           // Application.Run(new frmOnlineRecord()); //启动项为学生上机记录
           // Application.Run(new frmChargeRecord ());//启动项为添加卡片窗体
           
           //Application.Run (new frmAddStudent()); //启动项为添加学生信息
           // Application.Run(new frmCharge()); //启动充值和退卡表
           // Application.Run(new frmQueryRMoney()); //启动项为查询退卡金额
           // Application.Run(new frmQueryMoney ()); //启动项为查询退卡金额
           //  Application.Run(new frmOnlineStatus()); //启动为学生上机状态查看
           // Application.Run(new FrmaddUser()); //启动 增加，删除用户
           // Application.Run(new frmAddUer()); //启动， 添加用户小窗体
           // Application.Run(new frmBasicDate()); //启动，基本数据
           // Application.Run(new frmBill()); //启动，账单
           // Application.Run(new frmModifyPWD()); //修改密码

        }
    }
}
