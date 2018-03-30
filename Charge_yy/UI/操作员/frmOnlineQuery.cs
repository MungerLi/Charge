using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmOnlineQuery : UI.frmGroupQuery
    {
        public frmOnlineQuery()
        {
            InitializeComponent();
        }

        private void frmOnlineQuery_Load(object sender, EventArgs e)
        {
            //给窗体上的控件加载可以选择的查询信息
            string[] items = new string[]{"卡号","学号","姓名","上机日期","上机时间","下机日期","下机时间","消费金额","余额"};
            ComboBox[] com = new ComboBox[] { cmbFields1, cmbFields2, cmbFields3 };

            foreach (ComboBox cb in com)
            {
                cb.Items.AddRange(items);
            }           
        }

        //重写转换成数据库认识的字符串
        public override string ToName(string combo)
        {
            //return base.ToName(combo);
            switch (combo)
            {
                case"卡号":
                    return "cardno";
                case"学号":
                    return "studentno";
                case"姓名":
                    return "studentname";
                case "上机日期":
                    return "logindate";
                case "上机时间":
                    return "logintime";
                case "下机日期":
                    return "offdate";
                case "下机时间":
                    return "offtime";
                case "消费金额":
                    return "consumeTime";
                case "余额":
                    return "Money";
                default :
                    return "";

            }
        }

        //重写查询表的名称，这里我们查询的是line ，这个没有用到，---------------------------
        protected override string Getdbtable()
        {
            //return base.Getdbtable();
            return "line";
        }
        

        private void btOk_Click(object sender, EventArgs e)
        {
            if (enGroupQuery == null)
            {
                return;
            }
            else
            {
                //调用子类的查询，返回不同的查询结果
                //IList<Entity.GroupQuery> LgroupQuery = new BindingList<Entity.GroupQuery>(); 
                DataTable LgroupQuery = new DataTable();
                Facade.GroupQueryFacade GroupQuery = new Facade.GroupQueryFacade();
                LgroupQuery = GroupQuery.GroupQuery(enGroupQuery);
                //dataGridView1.AutoGenerateColumns = false;
                if (LgroupQuery.Rows.Count > 0)
                {
                    dataGridView1.DataSource = LgroupQuery;
                    //绑定数据库的列名称
                    //dataGridView1.AutoGenerateColumns = false;
           
                    //dataGridView1.Columns[0].DataPropertyName = "cardno";
                    //dataGridView1.Columns[1].DataPropertyName = "studentNo";
                    //dataGridView1.Columns[2].DataPropertyName = "StudentName";
                    //dataGridView1.Columns[3].DataPropertyName = "loginDate";
                    //dataGridView1.Columns[4].DataPropertyName = "loginTime";
                    //dataGridView1.Columns[5].DataPropertyName = "offDate";
                    //dataGridView1.Columns[6].DataPropertyName = "offtime";
                    //dataGridView1.Columns[7].DataPropertyName = "ConsumeTime";
                    //dataGridView1.Columns[8].DataPropertyName = "Money";



                    dataGridView1.Columns[0].HeaderText = "序列号";
                    dataGridView1.Columns[1].HeaderText = "卡号";
                    dataGridView1.Columns[2].HeaderText = "类型";
                    dataGridView1.Columns[3].HeaderText = "学号";
                    dataGridView1.Columns[4].HeaderText = "姓名";
                    dataGridView1.Columns[5].HeaderText = "性别";
                    dataGridView1.Columns[6].HeaderText = "上机日期";
                    dataGridView1.Columns[7].HeaderText = "上机时间";
                    dataGridView1.Columns[8].HeaderText = "下机日期";
                    dataGridView1.Columns[9].HeaderText = "下机时间";
                    dataGridView1.Columns[10].HeaderText = "消费时间";
                    dataGridView1.Columns[11].HeaderText = "消费金额";
                    dataGridView1.Columns[12].HeaderText = "余额";
                    dataGridView1.Columns[13].HeaderText = "状态";
                    dataGridView1.Columns[14].HeaderText = "机器号";



                    

                }
                else
                {
                    MessageBox.Show("没有记录", "提示");
                }
            }
        }

        private void cmbFields1_SelectedValueChanged(object sender, EventArgs e)
        {
            //first
            switch (cmbFields1.Text)
            {
                case "上机日期":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "yyyy-MM-dd";
                    dtTime1.Text = DateTime.Now.ToString();
                    //txtContext1.Text = dtTime1.Text;
                    break;
                case "下机日期":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "yyyy-MM-dd";
                    dtTime1.Text = DateTime.Now.ToString();
                    break;
                case "上机时间":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "hh:mm:ss";
                    dtTime1.Text = DateTime.Now.ToString();
                    break;
                case "下机时间":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "hh:mm:ss";
                    dtTime1.Text = DateTime.Now.ToString();
                    break;
                default:
                    dtTime1.Visible = false;
                    break;

            }           
        }

        private void cmbFields2_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbFields2.Text)
            {
                case "上机日期":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "yyyy-MM-dd";
                    dtTime2.Text = DateTime.Now.ToString();
                    
                    break;
                case "下机日期":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "yyyy-MM-dd";
                    dtTime2.Text = DateTime.Now.ToString();
                    break;
                case "上机时间":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "hh:mm:ss";
                    dtTime2.Text = DateTime.Now.ToString();
                    break;
                case "下机时间":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "hh:mm:ss";
                    dtTime2.Text = DateTime.Now.ToString();
                    break;
                default:
                    dtTime2.Visible = false;
                    break;

            }       
        }

        private void cmbFields3_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbFields3.Text)
            {
                case "上机日期":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "yyyy-MM-dd";
                    dtTime3.Text = DateTime.Now.ToString();

                    break;
                case "下机日期":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "yyyy-MM-dd";
                    dtTime3.Text = DateTime.Now.ToString();
                    break;
                case "上机时间":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "hh:mm:ss";
                    dtTime3.Text = DateTime.Now.ToString();
                    break;
                case "下机时间":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "hh:mm:ss";
                    dtTime3.Text = DateTime.Now.ToString();
                    break;
                default:
                    dtTime3.Visible = false;
                    break;

            }       
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cmbFields1.Items.Clear();
            cmbFields2.Items.Clear();
            cmbFields3.Items.Clear();

            cmbRelation1.Items.Clear();
            cmbRelation2.Items.Clear();
            string[] items = new string[] { "卡号", "学号", "姓名", "上机日期", "上机时间", "下机日期", "下机时间", "消费金额", "余额" };
            ComboBox[] com = new ComboBox[] { cmbFields1, cmbFields2, cmbFields3 };
            foreach (ComboBox cb in com)
            {
                cb.Items.AddRange(items);
            }
            cmbRelation1.Items.Add("与");
            cmbRelation1.Items.Add("或");
            cmbRelation2.Items.Add("与");
            cmbRelation2.Items.Add("或");
        }

        private void cmbFields1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContext1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (cmbFields1.Text == "姓名")
            //{
            //    if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8)
            //    {
            //        MessageBox.Show("请输入文字！", "提示");
            //        e.Handled = true;
            //    }
            //}
            //else
            //{
            //    if (cmbFields1.Text == "卡号" || cmbFields1.Text == "学号" || cmbFields1.Text == "消费金额" || cmbFields1.Text == "余额")
            //    {
            //        if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            //        {
            //            MessageBox.Show("请输入数字！", "提示");
            //            e.Handled = true;
            //        }
            //    }
            //}
        }

    }
}
