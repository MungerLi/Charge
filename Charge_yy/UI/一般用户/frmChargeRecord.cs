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
    public partial class frmChargeRecord : Form
    {
        public frmChargeRecord()
        {
            InitializeComponent();
        }

        private void frmChargeRecord_Load(object sender, EventArgs e)
        {
            if (cardnoToolStripTextBox1.Text == "")
            {

            }
            // TODO: 这行代码将数据加载到表“chargeMoneyDataSet.Charge_info”中。您可以根据需要移动或删除它。
           // this.charge_infoTableAdapter1.Fill(this.chargeMoneyDataSet.Charge_info);
            // TODO: 这行代码将数据加载到表“chargeDataSet2.Charge_info”中。您可以根据需要移动或删除它。
           // this.charge_infoTableAdapter.Fill(this.chargeDataSet2.Charge_info);

        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter.Query(this.chargeDataSet2.Charge_info, cardNoToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            if (cardnoToolStripTextBox1.Text == "")
            {
                if (cardnoToolStripTextBox1.Text == "")
                {
                    MessageBox.Show("请输入查询的内容！", "提示");
                    cardnoToolStripTextBox1.Focus();
                    return;
                }
            }
            try
            {
                this.charge_infoTableAdapter1.FillBy(this.chargeMoneyDataSet.Charge_info, cardnoToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("没有查询到内容！", "提示");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyUI.Excel ex = new EmptyUI.Excel();
            ex.RExcel("SweetyoYY", dataGridView1);
        }

        private void cardnoToolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }
    }
}
