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
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请填写用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("请填写密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
