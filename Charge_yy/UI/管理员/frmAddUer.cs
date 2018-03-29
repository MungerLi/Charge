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
    public partial class frmAddUer : Form
    {
        public frmAddUer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判空
            foreach (Control con in this.Controls)
            {
                if (con.Text == "")
                {
                    MessageBox.Show("请将内容补充完整", "提示");
                    con.Focus();
                    return;
                }
            }
            //查询是否有该用户，
            Entity.User user = new Entity.User();
            user.UserID = txtUserID.Text.Trim();
            user.UserName = txtName.Text.Trim();
            user.PassWord = txtPWD.Text.Trim();
            user.Level = CBlevel.Text;
            user.Head = frmLogin.UserName;//------------------------------------------
            //user.Head = "YY";

            Facade.QueryUserFacade QueryUser = new Facade.QueryUserFacade();
            IList<Entity.User> luser = new List<Entity.User>();
            luser = QueryUser.QueryUser(user);

            if (luser.Count != 0)
            {
                MessageBox.Show("该用户ID已注册，请更换ID", "提示");
                txtUserID.Text = "";
                txtUserID.Focus();
                return;
            }
            else
            //存在，添加
            {
                Facade.AddVSdelUserFacade addUser = new Facade.AddVSdelUserFacade();
                bool flag;
                flag = addUser.addUser(user);
                if (flag == true)
                {
                    MessageBox.Show("添加成功", "提示");
                    return;
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && EmptyUI.isEnlish(e.KeyChar.ToString()) == false)
            {
                MessageBox.Show("请输入文字！", "提示");
                e.Handled = true;
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && EmptyUI.isEnlish(e.KeyChar.ToString()) == false )
            {
                MessageBox.Show("请输入数字或英文字符！", "提示");
                e.Handled = true;
            }
        }

        private void frmAddUer_Load(object sender, EventArgs e)
        {
            CBlevel.Items.Add("一般用户");
            CBlevel.Items.Add("操作员");
            CBlevel.Items.Add("管理员");
            CBlevel.Text = "一般用户";

        }
    }
}
