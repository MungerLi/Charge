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
    public partial class frmBasicDate : Form
    {
        public frmBasicDate()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //可用
            panel1.Enabled = true;
            
        }

        private void frmBasicDate_Load(object sender, EventArgs e)
        {
            //将数据库中的内容读出来
            Entity.BasicData basicDate = new Entity.BasicData();
            Facade.QueryBasicDateFacade basicDatefacade = new Facade.QueryBasicDateFacade();
            IList<Entity.BasicData> lbasicDate = new List<Entity.BasicData>();
            lbasicDate = basicDatefacade .QueryBasicDate (basicDate);

            txtFixUser.Text = lbasicDate[0].Rate.ToString();
            txtTmUser.Text = lbasicDate[0].TmpRate.ToString();
            txtLeastTime.Text = lbasicDate[0].UntilTime.ToString();
            txtReadyTime.Text = lbasicDate[0].PreparyTime.ToString();
            txtLeastMoney.Text = lbasicDate[0].LeastMoney.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //判空
            foreach (Control con in this.Controls)
            {
                if (con.Text == "" && con is TextBox)
                {
                    MessageBox.Show("请将内容填写完整", "提示");
                    con.Focus();
                    return;
                }
            }
            //改
            Entity.BasicData basicDate = new Entity.BasicData();
            basicDate.Rate = Convert.ToInt16(txtFixUser.Text);
            basicDate.TmpRate = Convert.ToInt16(txtTmUser.Text);
            basicDate.UntilTime = Convert.ToInt16(txtLeastTime.Text);
            basicDate.PreparyTime = Convert.ToInt16(txtReadyTime.Text);
            basicDate.LeastMoney = Convert.ToInt16(txtLeastMoney.Text);

            Facade.ModifyBasicDate modifyBasic = new Facade.ModifyBasicDate();
            modifyBasic.modifyBasicFacade(basicDate);

            MessageBox.Show("修改成功！", "提示");
            panel1.Enabled = false;
            return;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtFixUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtTmUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtLeastTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtReadyTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtLeastMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
