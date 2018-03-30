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
    public partial   class frmModifyPWD : Form
    {
        public static string oldPWD;
        public frmModifyPWD()
        {
            InitializeComponent();
            
        }

        private void frmModifyPWD_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判空
            foreach (Control con in this.Controls)
            {
                if (con.Text == "" && con is TextBox)
                {
                    MessageBox.Show("请输入完整！", "提示");
                    con.Focus();
                    return;
                }
                if (txtNewpwd.Text != txtConfigpwd.Text)
                {
                    MessageBox.Show("修改密码不一致，请重新输入！", "提示");
                    txtConfigpwd.Text = "";
                    txtConfigpwd.Focus();
                    return;
                }
            }

               

                    oldPWD = txtOldpwd.Text.ToString();
                    //定义外观层对象
                    Facade.LoginFacade ModifyPWD = new Facade.LoginFacade();
                    Entity.User user = new Entity.User();

                   user.UserID = frmLogin.UserName;
                   // user.UserID = "1";
                    user.PassWord = oldPWD;

                    string newPWD = txtNewpwd.Text.ToString();


                    //定义外观层对象，同时将参数传递给Facade
                    Facade.ModifyFacade modifyPWD = new Facade.ModifyFacade();
                    bool flag;
                    flag = modifyPWD.CheckPWD(user, newPWD);
                    if (flag == true)
                    { MessageBox.Show("修改密码成功！"); }
                    else
                    {
                        MessageBox.Show("原密码输入有误，请重新输入！");
                        txtOldpwd.Text = "";
                        txtOldpwd.Focus();
                        return;
                    }
                           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
