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
    public partial class frmQueryRMoney : Form
    {
        public frmQueryRMoney()
        {
            InitializeComponent();
        }

        private void frmQueryRMoney_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“returnMoney.ReturnCard_info”中。您可以根据需要移动或删除它。
            //this.returnCard_infoTableAdapter.Fill(this.returnMoney.ReturnCard_info);
            this.fillByToolStrip.Hide();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.returnCard_infoTableAdapter.FillBy(this.returnMoney.ReturnCard_info, date1ToolStripTextBox.Text, date2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1ToolStripTextBox.Text = (DateTime.Parse(dateTimePicker1.Value.ToString())).ToString();
            date2ToolStripTextBox.Text = (DateTime.Parse(dateTimePicker2.Value.ToString())).ToString();
            try
            {
                this.returnCard_infoTableAdapter.FillBy(this.returnMoney.ReturnCard_info, date1ToolStripTextBox.Text, date2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("没有查询到内容！", "提示");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyUI.Excel excel = new EmptyUI.Excel();
            excel.RExcel("YY", dataGridView1);
        }
    }
}
