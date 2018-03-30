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
    public partial class frmOnlineStatus : Form
    {
        public frmOnlineStatus()
        {
            InitializeComponent();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineQuery frmOnline = new frmOnlineQuery();
            frmOnline.Show ();
        }

        private void frmOnlineStatus_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“onlineDataSet.online_info”中。您可以根据需要移动或删除它。
           // this.online_infoTableAdapter.Fill(this.onlineDataSet.online_info);

        }

        private void 显示全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.online_infoTableAdapter.Fill(this.onlineDataSet.online_info);
            if (dataGridView1.RowCount < 0)
            {
                MessageBox.Show ("当前没有人员上机！","提示");
            }
        }

        private void 指定学生下机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("当前没有人员上机！", "提示");
            }
            else
            {
                //根据卡号，找到正在上机的卡号,给line实体赋值
                Entity.online online = new Entity.online();
                online.CardNo = Convert.ToInt16(dataGridView1.CurrentRow.Cells [0].Value );
                Facade.IsOnlineFacade Isonline = new Facade.IsOnlineFacade();
                IList<Entity.online> lonline = new List<Entity.online>();
                lonline = Isonline.IsOnline(online);

                //将line实体的值补全
                Entity.line line = new Entity.line();
                line.CardNo = lonline[0].CardNo; //之前line表有的一些参数,根据这些信息找到缺失信息的表
                line.LoginDate = lonline[0].ondate;
                line.LoginTime = lonline[0].ontime;
                line.Status = "强制下机";

                Facade.AddLineFacade addLineOff = new Facade.AddLineFacade();
                addLineOff.addLineOff(line);
               
                
                //计算金额，显示消费时间和金额
                Facade.CountMoneyFacade countMoneyfacade = new Facade.CountMoneyFacade();
                IList<Entity.line> LineAll = new List<Entity.line>();
                LineAll = countMoneyfacade.CountMoney(line);

                //将正在上机表下机
                Facade.deleteFacade deleteOnlineFacade = new Facade.deleteFacade();
                deleteOnlineFacade.DeleteOnline(online);


                MessageBox.Show("下机成功！", "提示");
                this.online_infoTableAdapter.Fill(this.onlineDataSet.online_info);

            }
        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("当前没有人员上机！", "提示");
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    //根据卡号，找到正在上机的卡号,给line实体赋值
                    Entity.online online = new Entity.online();
                    online.CardNo = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                    Facade.IsOnlineFacade Isonline = new Facade.IsOnlineFacade();
                    IList<Entity.online> lonline = new List<Entity.online>();
                    lonline = Isonline.IsOnline(online);

                    //将line实体的值补全
                    Entity.line line = new Entity.line();
                    line.CardNo = lonline[0].CardNo; //之前line表有的一些参数,根据这些信息找到缺失信息的表
                    line.LoginDate = lonline[0].ondate;
                    line.LoginTime = lonline[0].ontime;
                    line.Status = "强制下机";

                    Facade.AddLineFacade addLineOff = new Facade.AddLineFacade();
                    addLineOff.addLineOff(line);


                    //计算金额，显示消费时间和金额
                    Facade.CountMoneyFacade countMoneyfacade = new Facade.CountMoneyFacade();
                    IList<Entity.line> LineAll = new List<Entity.line>();
                    LineAll = countMoneyfacade.CountMoney(line);

                    //将正在上机表下机
                    Facade.deleteFacade deleteOnlineFacade = new Facade.deleteFacade();
                    deleteOnlineFacade.DeleteOnline(online);
                }

                MessageBox.Show("下机成功！", "提示");
                this.online_infoTableAdapter.Fill(this.onlineDataSet.online_info);

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
