using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmGroupOperator : UI.frmGroupQuery
    {
        public frmGroupOperator()
        {
            InitializeComponent();
        }

        private void frmGroupOperator_Load(object sender, EventArgs e)
        {

            //dataGridView1.Columns[0].HeaderText = "教师";
            //dataGridView1.Columns[1].HeaderText = "上班日期";
            //dataGridView1.Columns[2].HeaderText = "上班时间";
            //dataGridView1.Columns[3].HeaderText = "下班日期";
            //dataGridView1.Columns[4].HeaderText = "下班时间";
            //dataGridView1.Columns[5].HeaderText = "机器号";
            //dataGridView1.Columns[6].HeaderText = "权限";


            //frmGroupOperator frmWorklog = new frmGroupOperator();


            string[] items = new string[] { "教师", "上机日期", "上机时间", "下机日期", "下机时间" };
            ComboBox[] com = new ComboBox[] { cmbFields1, cmbFields2, cmbFields3 };
            foreach (ComboBox cb in com)
            {
                cb.Items.AddRange(items);
            }
            
                   
        }

        //重写转换成数据库表列明的需方法
        public override string ToName(string combo)
        {
           // return base.ToName(combo);
            switch (combo)
            {
                case "教师":
                    return "UserID";
                    
                case "上机日期":
                    return "logdate";
                case "上机时间":
                    return "logtime";
                case "下机日期":
                    return "offdate";
                case "下机时间":
                    return "offtime";
                case "与":
                    return "and";
                case "或":
                    return "or";
                case "权限":
                    return "Level";
                default :
                    return "";


            }
        }

        //重写查询表的名称，这里我们查询的是worklog
        protected override string Getdbtable()
        {
            //return base.GetdbName();

            return "worklog_info";
        }

        //在dategridview中显示查询的结果
        protected override void toDateGridView(Entity.GroupQuery Groupquery)
        {
           // base.toDateGridView(Groupquery);
            //IList <Entity.GroupQuery > lgroupQuery = new List<Entity.GroupQuery >();
            DataTable lgroupQuery = new DataTable();
            Facade.GroupQueryFacade  GroupQuery = new Facade.GroupQueryFacade ();
            lgroupQuery = GroupQuery.GroupQuery(Groupquery);

            dataGridView1.DataSource = lgroupQuery;
            dataGridView1.Columns[0].HeaderText = "教师";
            dataGridView1.Columns[1].HeaderText = "上班日期";
            dataGridView1.Columns[2].HeaderText = "上班时间";
            dataGridView1.Columns[3].HeaderText = "下班日期";
            dataGridView1.Columns[4].HeaderText = "下班时间";
            dataGridView1.Columns[5].HeaderText = "机器号";
            dataGridView1.Columns[6].HeaderText = "权限";
            dataGridView1.Columns[7].HeaderText = "备注";
            //dataGridView1.Columns[7].HeaderText = "";


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
                    dataGridView1.Columns[0].HeaderText = "教师";
                    dataGridView1.Columns[1].HeaderText = "上班日期";
                    dataGridView1.Columns[2].HeaderText = "上班时间";
                    dataGridView1.Columns[3].HeaderText = "下班日期";
                    dataGridView1.Columns[4].HeaderText = "下班时间";
                    dataGridView1.Columns[5].HeaderText = "机器号";
                    dataGridView1.Columns[6].HeaderText = "权限";
                    dataGridView1.Columns[7].HeaderText = "备注";
                }
                else
                {
                    MessageBox.Show("没有记录", "提示");
                }
            }
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cmbFields1.Items.Clear();
            cmbFields2.Items.Clear();

            cmbRelation1.Items.Clear();
            cmbRelation2.Items.Clear();
            string[] items = new string[] { "教师", "上班日期", "上班时间", "下班日期", "下班时间" };
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

        private void cmbFields2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dtTime1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
