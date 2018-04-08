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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("请填写密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //try
            //{
                //实例化外观
                Facade.LoginFacade FLogin = new Facade.LoginFacade();

                Entity.User_Info user = new Entity.User_Info();

                user.UserID = Convert.ToInt32(txtUserID.Text.Trim());
                user.PassWord = txtUserID.Text.Trim();

                Boolean flag = false;
                flag = FLogin.SelectUser (user);

                if (flag != false)
                {
                    this.Hide();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }

            //}
           // catch (Exception ex)
            //{
              //  Console.WriteLine(ex.Message);
                //throw new Exception ("登录失败！");
           // }
        }
    }
}
