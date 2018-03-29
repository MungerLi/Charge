using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using System.Runtime.InteropServices;


namespace UI
{
    
    

    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.StartPosition = FormStartPosition.CenterScreen;
            
            frmOn frmon = new frmOn();
            frmon.MdiParent = this;
            frmon.StartPosition = FormStartPosition.CenterParent;
            frmon.WindowState = this.WindowState;
            frmon.Show();
            this.skinEngine1.SkinFile = "Skins\\MidsummerColor1.ssk";
            //this.skinEngine1.SkinFile = "Skins\\WaveColor2.ssk";
            //this.skinEngine1.SkinFile = "Skins\\XPOrange.ssk";
           
            

        }

        //public extern int Setparent( Form frmChild, Form frmParent)
        //{
        //    //    [DllImport("user32")];
        //    //    frmAddCard frmadd = new frmAddCard();
        //    //    frmadd.MdiParent = this;
        //    //    frmadd.Show ();
        //    //Setparent ((int)frmChild.Handle (int)frmParent .Handle,frmChild );
        //    Setparent(frmChild.Handle, frmParent.Handle);
        //}

        
           


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 查看学生上机状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineRecord frmonlinerecord = new frmOnlineRecord();
            frmonlinerecord.MdiParent = this;
            frmonlinerecord.StartPosition = FormStartPosition.CenterScreen;
            frmonlinerecord.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //查询权限，显示toolstrip
            Entity.User user = new Entity.User();
            user.UserID = frmLogin.UserName;
            IList<Entity.User> Luser = new List<Entity.User>();
            Facade.QueryUserFacade QueryUserfacade = new Facade.QueryUserFacade();
            Luser = QueryUserfacade.QueryUser(user);
            if (Luser[0].Level == "一般用户")
            {
                操作员ToolStripMenuItem.Enabled = false;

                管理员ToolStripMenuItem.Enabled = false;
            }
            if (Luser[0].Level == "操作员")
            {

                管理员ToolStripMenuItem.Enabled = false;
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyPWD frm_Modifypwd = new frmModifyPWD();
            frm_Modifypwd.MdiParent = this;
            frm_Modifypwd.StartPosition = FormStartPosition.CenterScreen;
            frm_Modifypwd.Show();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 学生查看余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent frmQueryMoney = new frmStudent();
            frmQueryMoney.MdiParent = this;
            frmQueryMoney.StartPosition = FormStartPosition.CenterParent;
            frmQueryMoney.Show();
        }

        private void 查看学生余额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoney frmstudentMoney = new frmMoney();
            frmstudentMoney.MdiParent = this;
            frmstudentMoney.StartPosition = FormStartPosition.CenterScreen;
            frmstudentMoney.Show();
        }

        private void 查询学生充值记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChargeRecord frm_chargeRecord = new frmChargeRecord();
            frm_chargeRecord.MdiParent = this;
            frm_chargeRecord.StartPosition = FormStartPosition.CenterScreen;
            frm_chargeRecord.Show();
        }

        private void 查询金额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueryMoney frm_queryMoney = new frmQueryMoney();
            frm_queryMoney.MdiParent = this;
            frm_queryMoney.StartPosition = FormStartPosition.CenterScreen;
            frm_queryMoney.Show();

        }

        private void 查询学生上机状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineStatus frmOnline = new frmOnlineStatus();
            frmOnline.MdiParent = this;
            frmOnline.StartPosition = FormStartPosition.CenterScreen;
            frmOnline.Show();
        }

        private void 查询退卡金额ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueryRMoney frm_ReturnMoney = new frmQueryRMoney();
            frm_ReturnMoney.MdiParent = this;
            frm_ReturnMoney.StartPosition = FormStartPosition.CenterScreen;
            frm_ReturnMoney.Show();
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //[DllImport("user32")]
            //public static extern int  Setparent(int hWndChild, int hWndNewParent);
            //frmAddCard frm_addCard = frmAddCard .getin
            frmAddCard frm_addCard = new frmAddCard();
            frm_addCard.MdiParent = this;
           
            frm_addCard.StartPosition = FormStartPosition.CenterScreen;
            frm_addCard.Show();

            
        
            

        }

        private void 操作员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCharge frmcharge = new frmCharge();
            frmcharge.MdiParent = this;
            frmcharge.StartPosition = FormStartPosition.CenterScreen;
            frmcharge.Show();
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddstudent = new frmAddStudent();
            frmAddstudent.MdiParent = this;
            frmAddstudent.StartPosition = FormStartPosition.CenterScreen;
            frmAddstudent.Show();
        }

        private void 退卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学生上机状态查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineQuery frmOnlinequery = new frmOnlineQuery();
            frmOnlinequery.MdiParent = this;
            frmOnlinequery.StartPosition = FormStartPosition.CenterScreen;
            frmOnlinequery.Show();
        }

        private void 学生基本信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentGroupQ frmstudentGroup = new frmStudentGroupQ();
            frmstudentGroup.MdiParent = this;
            frmstudentGroup.StartPosition = FormStartPosition.CenterScreen;
            frmstudentGroup.Show();
        }

        private void 查询操作员工作记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupOperator frmOperWolk = new frmGroupOperator();
            frmOperWolk.MdiParent = this;
            frmOperWolk.StartPosition = FormStartPosition.CenterScreen;
            frmOperWolk.Show();
        }

        private void 删除添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUer frmadduser = new frmAddUer();
            frmadduser.MdiParent = this;
            frmadduser.StartPosition = FormStartPosition.CenterScreen;
            frmadduser.Show();
        }

        private void 设定基本数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasicDate frmbasicDate = new frmBasicDate();
            frmbasicDate .MdiParent = this;
            frmbasicDate .StartPosition = FormStartPosition .CenterScreen ;
            frmbasicDate.Show ();
        }

        private void 结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckOut frmCheckout = new frmCheckOut();
            frmCheckout.MdiParent = this;
            frmCheckout.StartPosition = FormStartPosition.CenterScreen;
            frmCheckout.Show();

        }

        private void 周结账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 日结账单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill frmbill = new frmBill();
            frmbill.MdiParent = this;
            frmbill.StartPosition = FormStartPosition.CenterScreen;
            frmbill.Show();
        }

        private void menuStrip1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //补充完整值班记录

                Entity.onWork onwork = new Entity.onWork();
                onwork.UserID = frmLogin.UserName;

                //查询onwork表
                Facade.QueryOnworkFac queryOnwork = new Facade.QueryOnworkFac();
                IList<Entity.onWork> lonwork = new List<Entity.onWork>();
                lonwork = queryOnwork.queryOnwork(onwork);
                //补充完整值班记录
                Entity.WorkLog worklog = new Entity.WorkLog();
                worklog.UserID = lonwork[0].UserID;
                worklog.Level = lonwork[0].Level;
                worklog.LogDate = lonwork[0].logindate;
                worklog.LogTime = lonwork[0].logintime;
                worklog.Computer = lonwork[0].Computer;
                
                Facade.AddWorkerFacade addworkerlog = new Facade.AddWorkerFacade();
                addworkerlog.addWorkLogTime(worklog);


                //删除正在值班教师
                Facade.AddWorkerFacade delOnwork = new Facade.AddWorkerFacade();
                delOnwork.delonWorkFac(onwork);



                this.FormClosing -= new FormClosingEventHandler(this.frmMain_FormClosing); //为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                Application.Exit(); //退出整个程序

            }
            else
            {
                e.Cancel = true;  //取消关闭事件
            }
        }

        private void skinEngine1_CurrentSkinChanged(object sender, Sunisoft.IrisSkin.SkinChangedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
