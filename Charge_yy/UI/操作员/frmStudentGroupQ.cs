using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class frmStudentGroupQ : UI.frmGroupQuery
    {
        public static  Entity.Student student; //声明一个公共字段，方便另一个窗体的访问
        public frmStudentGroupQ()
        {
            InitializeComponent();
        }

        private void frmStudentGroupQ_Load(object sender, EventArgs e)
        {
            string[] items = new string[] {"学号","姓名","性别","专业","年级","班级" };
            ComboBox[] com = new ComboBox[] { cmbFields1, cmbFields2, cmbFields3 };

            foreach (ComboBox cb in com)
            {
                cb.Items.AddRange(items);

            }
        }

        //重写转换成数据库表识别的列名称的方法
        public override string ToName(string combo)
        {
            //return base.ToName(combo);
            switch (combo)
            {
                case "学号":
                    return "studentno";
                case "姓名":
                    return "name";
                case "性别":
                    return "sex";
                case "专业":
                    return "department";
                case "年级":
                    return "grade";
                case "班级":
                    return "class";
                default :
                    return "";
                

            }
        }

        //重写查询表的名称
        protected override string Getdbtable()
        {
            //return base.Getdbtable();
            return "Student";
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
                    dataGridView1.Columns[0].HeaderText = "学号";
                    dataGridView1.Columns[1].HeaderText = "姓名";
                    dataGridView1.Columns[2].HeaderText = "性别";
                    dataGridView1.Columns[3].HeaderText = "专业";
                    dataGridView1.Columns[4].HeaderText = "年级";
                    dataGridView1.Columns[5].HeaderText = "班级";
                    dataGridView1.Columns[6].HeaderText = "备注";
                    
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
            cmbFields3.Items.Clear();

            cmbRelation1.Items.Clear();
            cmbRelation2.Items.Clear();
            string[] items = new string[] { "学号", "姓名", "性别", "专业", "年级", "班级" };
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

        private void dtTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbFields1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFields2_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

       private void cmbFields3_SelectedValueChanged(object sender, EventArgs e)
        {
             
           
        }

       private void button1_Click(object sender, EventArgs e)
       {
          student = new Entity.Student ();

           

          student.StudentNo = Convert .ToInt16 ( dataGridView1.CurrentRow.Cells[0].Value.ToString ());


           //将输入的信息给到实体学生的学号上
           //Entity.Student student = new Entity.Student();
           //student.StudentNo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

           frmModifyStudent frmModifystudent = new frmModifyStudent();
           frmModifystudent.Show();

           
       }

       private void button2_Click(object sender, EventArgs e)
       {
           this.Dispose();
       }

        
    }
}
