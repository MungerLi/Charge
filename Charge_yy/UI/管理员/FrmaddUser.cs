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
    public partial class FrmaddUser : Form
    {
        public FrmaddUser()
        {
            InitializeComponent();
        }

        private void FrmaddUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“userDateSet.User_info”中。您可以根据需要移动或删除它。
            //this.user_infoTableAdapter.Fill(this.userDateSet.User_info);
            comboBox1.Items.Add("一般用户");
            comboBox1.Items.Add("操作员");
            comboBox1.Items.Add("管理员");
           // comboBox1.Text = "一般用户";
            queryToolStrip.Hide();


        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.user_infoTableAdapter.query(this.userDateSet.User_info, levelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            levelToolStripTextBox.Text = comboBox1.Text;
            try
            {
                this.user_infoTableAdapter.query(this.userDateSet.User_info, levelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUer frmaddUser = new frmAddUer();
            frmaddUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
           if (dr == DialogResult.OK)
           {
               Entity.User user = new Entity.User();
               user.UserID = dataGridView1.CurrentRow.Cells[0].Value.ToString();

               Facade.AddVSdelUserFacade delUser = new Facade.AddVSdelUserFacade();
               bool flag;
               flag = delUser.delUser(user);
               if (flag == true)
               {
                   MessageBox.Show("删除成功！", "提示");
                   return;
               }
               else
               {
                   return;
               }
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            levelToolStripTextBox.Text = comboBox1.Text;
            try
            {
                this.user_infoTableAdapter.query(this.userDateSet.User_info, levelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void levelToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
