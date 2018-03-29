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
    public partial class frmQueryMoney : Form
    {
        public frmQueryMoney()
        {
            InitializeComponent();
        }

        private void frmQueryMoney_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“chargeMoneyDateSet.Charge_info”中。您可以根据需要移动或删除它。
            //this.charge_infoTableAdapter1.Fill(this.chargeMoneyDateSet.Charge_info);
            
            // TODO: 这行代码将数据加载到表“charge_info._Charge_info”中。您可以根据需要移动或删除它。
            //this.charge_infoTableAdapter.Fill(this.charge_info._Charge_info);
            //将tool隐藏
            //this.fillByToolStrip.Hide();
            this.queryToolStrip.Hide();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter.FillBy(this.charge_info._Charge_info, para1ToolStripTextBox.Text, para2ToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btCharge_Click(object sender, EventArgs e)
        {
            startTimeToolStripTextBox.Text = (DateTime.Parse(dtPicker1.Value.ToString())).ToString();
            stopTimeToolStripTextBox.Text = (DateTime.Parse(dtPicker2.Value.ToString())).ToString();


            try
            {
                this.charge_infoTableAdapter1.query(this.chargeMoneyDateSet.Charge_info, startTimeToolStripTextBox.Text, stopTimeToolStripTextBox.Text);
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

        private void dtPicker1_ValueChanged(object sender, EventArgs e)
        {
            //para1ToolStripTextBox.Text = (DateTime.Parse(dtPicker1.Value.ToString ())).ToString ();
        }

        private void dtPicker2_ValueChanged(object sender, EventArgs e)
        {
            //para2ToolStripTextBox.Text = (DateTime.Parse(dtPicker2.Value.ToString())).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyUI.Excel excel = new EmptyUI.Excel();
            excel.RExcel("YY", dataGridView1);
        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter1.query(this.chargeMoneyDateSet.Charge_info, startTimeToolStripTextBox.Text, stopTimeToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void queryToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
