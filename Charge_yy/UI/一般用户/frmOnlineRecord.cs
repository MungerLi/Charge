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
    public partial class frmOnlineRecord : Form
    {
        public frmOnlineRecord()
        {
            InitializeComponent();
        }

        private void frmOnlineRecord_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“lineInfoDataSet.line_info”中。您可以根据需要移动或删除它。
            //this.line_infoTableAdapter1.Fill(this.lineInfoDataSet.line_info);
            // TODO: 这行代码将数据加载到表“chargeDataSet.line_info”中。您可以根据需要移动或删除它。
            //this.line_infoTableAdapter.Fill(this.chargeDataSet.line_info);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView  dataview = new DataGridView();
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.line_infoTableAdapter.FillBy(this.chargeDataSet.line_info, ((int)(System.Convert.ChangeType(cardnoToolStripTextBox.Text, typeof(int)))));

            //    this.dataGridView1.AllowUserToAddRows = false; //删除最后一个空行
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cardnoToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cardnoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            if (cardnoToolStripTextBox1.Text == "")
            {
                MessageBox.Show("请输入查询的内容！", "提示");
                cardnoToolStripTextBox1.Focus();
                return;
            }

            try
            {
                this.line_infoTableAdapter1.FillBy(this.lineInfoDataSet.line_info, ((int)(System.Convert.ChangeType(cardnoToolStripTextBox1.Text, typeof(int)))));
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

        private void cardnoToolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyUI.Excel ex = new EmptyUI.Excel();
            ex.RExcel("SweetyoYY", dataGridView1);

        }

        private void cardnoToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
