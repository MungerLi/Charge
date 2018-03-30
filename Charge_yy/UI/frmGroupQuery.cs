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
    public partial class frmGroupQuery : Form
    {
        public Entity.GroupQuery enGroupQuery;
        public frmGroupQuery()
        {
            InitializeComponent();
        }

        private void frmGroupQuery_Load(object sender, EventArgs e)
        {
            cmbRelation1.Items.Clear();
            cmbRelation2.Items.Clear();
            cmbRelation1.Items.Add("与");
            cmbRelation1.Items.Add("或");
            cmbRelation2.Items.Add("与");
            cmbRelation2.Items.Add("或");

            string[] items = new string[] { "=", "<", ">", "<>" };
            ComboBox[] combs = new ComboBox[] { cmbOperator1, cmbOperator2, cmbOperator3 };
            //遍历
            foreach (ComboBox com in combs)
            {
                //com.Items.Add(items);
                com.Items.AddRange(items);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            string name = "文件YY";
            EmptyUI.Excel ex = new EmptyUI.Excel();
            ex.RExcel(name, dataGridView1);
        }

        #region 虚方法
        //通过实体，将不同的内容显示在各个窗体中
        protected virtual void toDateGridView(Entity.GroupQuery Groupquery)
        {

        }

        //将查询的内容转换成数据库中的列名称
        public virtual string ToName(string combo)
        {
            return "";
        }
        
        //获得数据库名称
        protected virtual   string Getdbtable()
        {
            return "";
        }

        
        #endregion


        private void btOk_Click(object sender, EventArgs e)
        {
            
                
            //每次点击按钮前先清空dgv
            dataGridView1.DataSource = null;

            //1 没有组合的查询判空
            //限制输入不能为空
            if (cmbRelation1.Text == "")
            {
                Control[] arrcontrol = new Control[3];
                arrcontrol[0] = cmbFields1;
                arrcontrol[1] = cmbOperator1;
                arrcontrol[2] = txtContext1;

                //调用函数判断控件中的内容是否为空
                
                //EmptyUI.ISsomeEmpty(arrcontrol);
                bool falg;
                falg = EmptyUI.ISsomeEmpty(arrcontrol);
                if (falg == true)
                {
                    MessageBox.Show("内容填写不完整，请核对后再查询！");
                    enGroupQuery = null;
                    return;
                }
                
            }
            else
            {
                if (cmbRelation2.Text == "")
                {
                    
                    //2 开始第一个组合的查询判空
                    Control[] arrcontrol2 = new Control[6];
                    arrcontrol2[0] = cmbFields1;
                    arrcontrol2[1] = cmbOperator1;
                    arrcontrol2[2] = txtContext1;
                    arrcontrol2[3] = cmbFields2;
                    arrcontrol2[4] = cmbOperator2;
                    arrcontrol2[5] = txtContext2;

                    bool falg;
                    falg = EmptyUI.ISsomeEmpty(arrcontrol2);
                    if (falg == true)
                    {
                        MessageBox.Show("内容填写不完整，请核对后再查询！");
                        enGroupQuery = null;
                        return;
                    }
                }


                else 
                {   //开始第三个条件的组合查询
                    Control[] arrcontrol3 = new Control[9];
                    arrcontrol3[0] = cmbFields1;
                    arrcontrol3[1] = cmbOperator1;
                    arrcontrol3[2] = txtContext1;
                   
                    arrcontrol3[3] = cmbFields2;
                    arrcontrol3[4] = cmbOperator2;
                    arrcontrol3[5] = txtContext2;
                    
                    arrcontrol3[6] = cmbFields3;
                    arrcontrol3[7] = cmbOperator3;
                    arrcontrol3[8] = txtContext3;

                    //EmptyUI.ISsomeEmpty(arrcontrol3);
                    bool falg;
                    falg = EmptyUI.ISsomeEmpty(arrcontrol3);
                    if (falg == true)
                    {
                        MessageBox.Show("内容填写不完整，请核对后再查询！");
                        enGroupQuery = null;
                        return;
                    }                                 
                }

               
            }
            //将参数传递给实体
            //Entity.GroupQuery enGroupQuery = new Entity.GroupQuery();
            enGroupQuery = new Entity.GroupQuery();
            enGroupQuery.fileds1 = ToName(cmbFields1.Text);
            enGroupQuery.fileds2 = ToName(cmbFields2.Text);
            enGroupQuery.fileds3 = ToName(cmbFields3.Text);

            enGroupQuery.Operator1 = cmbOperator1.Text;
            enGroupQuery.Operator2 = cmbOperator2.Text;
            enGroupQuery.Operator3 = cmbOperator3.Text;

            enGroupQuery.Context1 = txtContext1.Text.Trim();
            enGroupQuery.Context2 = txtContext2.Text.Trim();
            enGroupQuery.Context3 = txtContext3.Text.Trim();

            enGroupQuery.Relation1 = ToName(cmbRelation1.Text);
            enGroupQuery.Relation2 = ToName(cmbRelation2.Text);

            enGroupQuery.table = Getdbtable();

            ////调用子类的查询，返回不同的查询结果
            ////IList<Entity.GroupQuery> LgroupQuery = new BindingList<Entity.GroupQuery>(); 
            //DataTable LgroupQuery = new DataTable();
            //Facade.GroupQueryFacade GroupQuery = new Facade.GroupQueryFacade();
            //LgroupQuery = GroupQuery.GroupQuery(enGroupQuery);
            ////dataGridView1.AutoGenerateColumns = false;
            //if (LgroupQuery.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = LgroupQuery;
            //}
           
        }

        
        private void btClear_Click(object sender, EventArgs e)
        {

            
            //清空dtpicker的内容
            dtTime1.Visible = false;
            dtTime2.Visible = false;
            dtTime3.Visible = false;
            dataGridView1.DataSource = null;
            cmbOperator1.Items.Clear();
            cmbOperator2.Items.Clear();
            cmbOperator3.Items.Clear();
            string[] items = new string[] { "=", "<", ">", "<>" };
            ComboBox[] combs = new ComboBox[] { cmbOperator1, cmbOperator2, cmbOperator3 };
            //遍历
            foreach (ComboBox com in combs)
            {
                //com.Items.Add(items);
                com.Items.AddRange(items);
            }

            foreach (Control con in this.Controls)
            {
                if (con is TextBox && con.Text !="")
                {
                    ((TextBox)(con)).Text = "";
                }

                
                                
            }
        }

        private void cmbFields1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFields1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbFields1.Text == "0上机日期" || cmbFields1.Text == "下机日期" || cmbFields1.Text == "上机时间" || cmbFields1.Text == "上机时间")
            {
                //txtContext1.Text = "";
            }
            else
            {
                txtContext1.Text = "";
            }
            
        }

        private void cmbFields1_SelectedValueChanged(object sender, EventArgs e)
        {
            //first
            switch (cmbFields1.Text )
            {
                case "上机日期":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "yyyy-MM-dd";
                    //txtContext1.Text = dtTime1.Text;
                    break;
                case "下机日期":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "yyyy-MM-dd";
                    break;
                case "上机时间":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "hh:mm:ss";
                    break;
                case "下机时间":
                    dtTime1.Visible = true;
                    dtTime1.CustomFormat = "hh:mm:ss";
                    break;
                default :
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
                    break;
                case "下机日期":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "yyyy-MM-dd";
                    break;
                case "上机时间":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "hh:mm:ss";
                    break;
                case "下机时间":
                    dtTime2.Visible = true;
                    dtTime2.CustomFormat = "hh:mm:ss";
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
                    break;
                case "下机日期":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "yyyy-MM-dd";
                    break;
                case "上机时间":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "hh:mm:ss";
                    break;
                case "下机时间":
                    dtTime3.Visible = true;
                    dtTime3.CustomFormat = "hh:mm:ss";
                    break;
                default:
                    dtTime3.Visible = false;
                    break;

            }       
        }

        private void dtTime1_ValueChanged(object sender, EventArgs e)
        {
            txtContext1.Text = dtTime1.Text.ToString() ;
        }

        private void dtTime2_ValueChanged(object sender, EventArgs e)
        {
            txtContext2.Text = dtTime2.Text.ToString();
        }

        private void dtTime3_ValueChanged(object sender, EventArgs e)
        {
            txtContext3.Text = dtTime3.Text.ToString();
        }

        private void txtContext1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFields1.Text == "年级" || cmbFields1.Text == "班级")
            {
                if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
                {
                    MessageBox.Show("请输入文字或数字！", "提示");
                    e.Handled = true;
                }
            }
            else
            {
                if (cmbFields1.Text == "卡号" || cmbFields1.Text == "学号" || cmbFields1.Text == "消费金额" || cmbFields1.Text == "余额")
                {
                    if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    {
                        MessageBox.Show("请输入数字！", "提示");
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtContext2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFields2.Text == "年级" || cmbFields2.Text == "班级")
            {
                if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
                {
                    MessageBox.Show("请输入文字或数字！", "提示");
                    e.Handled = true;
                }
            }
            else
            {
                if (cmbFields2.Text == "卡号" || cmbFields2.Text == "学号" || cmbFields2.Text == "消费金额" || cmbFields2.Text == "余额")
                {
                    if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    {
                        MessageBox.Show("请输入数字！", "提示");
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtContext3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFields3.Text == "年级" || cmbFields3.Text == "班级")
            {
                if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
                {
                    MessageBox.Show("请输入文字或数字！", "提示");
                    e.Handled = true;
                }
            }
            else
            {
                if (cmbFields3.Text == "卡号" || cmbFields3.Text == "学号" || cmbFields3.Text == "消费金额" || cmbFields3.Text == "余额")
                {
                    if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    {
                        MessageBox.Show("请输入数字！", "提示");
                        e.Handled = true;
                    }
                }
            }
        }

        
    }
}
