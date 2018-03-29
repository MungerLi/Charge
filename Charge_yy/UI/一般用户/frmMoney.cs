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
    public partial class frmMoney : Form
    {
        public frmMoney()
        {
            InitializeComponent();
        }

        private void Querybt_Click(object sender, EventArgs e)
        {
            //判空
            if (txtCardNo.Text == "")
            {
                MessageBox.Show("请输入查询的内容！", "提示");
                txtCardNo.Focus();
                return;
            }
            //给card实体带上参数，传给外观
            Entity.Card card = new Entity.Card();
            card.CardNo = Convert.ToInt32 (txtCardNo.Text.ToString());
            IList<Entity.Card> Card = new List<Entity.Card>();
            Facade.StudentMoneyFacade  StudentMoney = new Facade.StudentMoneyFacade ();
            Card = StudentMoney.StudentMoney(card);
            if (Card.Count == 0)
            { MessageBox.Show("没有该卡号的相关信息，请重新输入！"); }
            else
            {
                txtStudentNo.Text = Card[0].StudentNo.ToString ();
                txtMoney.Text = Card[0].Money.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMoney_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtCardNo, "请输入数字！");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
