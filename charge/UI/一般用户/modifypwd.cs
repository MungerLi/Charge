using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.一般用户
{
    public partial class modifypwd : Form
    {
        public modifypwd()
        {
            InitializeComponent();
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Text.Trim() == "")
                {
                    MessageBox.Show("请将信息输入完整", "提示");
                    control.Focus();
                    return;
                }
                if (txtNewPWD.Text.Trim() != txtNewPWDT.Text.Trim())
                {
                    MessageBox.Show("两次密码不一致", "提示");
                    control.Focus();
                    return;
                }
            }


        }
    }
}
