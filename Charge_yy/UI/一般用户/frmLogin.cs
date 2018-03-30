using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial  class frmLogin : Form
    {
        public static string UserName;

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {

             UserName = txtUserName.Text.Trim(); //全局变量
            //传递用户输入的参数
             string UserID = txtUserName.Text.Trim();
           // string PWD = txtUserPWD.Text.Trim();

            //定义外观层对象
            Facade.LoginFacade loginfacade = new Facade.LoginFacade();
            Entity.User userinfo = new Entity.User();

            //将文本框的值给实体层对象，让实体层对象带上参数
            userinfo.UserID = txtUserName.Text;
            userinfo.PassWord = txtUserPWD.Text;

            string  strResult;
            strResult = loginfacade.loginfacade (userinfo);

            switch (strResult)
            {
                case "无用户": MessageBox.Show("用户不存在，请重新输入");
                    
                    break; 
                case "登录成功" ://MessageBox.Show("登录成功 ");
                    this.Visible = false;
                    //查找user的信息
                    Entity.User userInfo = new Entity.User();
                    userinfo.UserID = txtUserName.Text;
                    Facade.QueryUserFacade queryUser = new Facade.QueryUserFacade();
                    IList<Entity.User> lUser = new List<Entity.User>();
                    lUser = queryUser.QueryUser(userinfo);

                    //将正在上班的信息，传到当值 表                
                    Facade.AddWorkerFacade addonwork = new Facade.AddWorkerFacade();

                    Entity.onWork onwork = new Entity.onWork();
                    onwork.UserID = lUser[0].UserID;
                    onwork.Level = lUser[0].Level ;
                    onwork.Computer = Environment.MachineName; //获得计算机名称
                    bool flag;
                    flag = addonwork.addOnwork(onwork);

                    //传到上机记录表
                    Entity.WorkLog worklog = new Entity.WorkLog();
                    worklog.UserID = lUser[0].UserID;
                    worklog.Level = lUser[0].Level;
                    worklog.Computer = Environment.MachineName;
                    worklog.Status = "正常上机";
                    flag = addonwork.addWorkLog(worklog);

                    frmMain frmmain = new frmMain();
                    frmmain.StartPosition = FormStartPosition.CenterParent;
                    frmmain.Show();
                    break ;
                case "密码不正确": MessageBox.Show("用户密码不正确，请重新输入 ");
                    break;
            }

            




        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.isEnlish (e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("请输入文字或数字！", "提示");
                e.Handled = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtUserName, "请输入英文字符或数字！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
