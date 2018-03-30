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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBtQuery_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtStudentID , "请输入数字！");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void   button1_Click(object sender, EventArgs e)
        {
            //判断为空
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("请输入查询的内容！","提示");
                txtStudentID.Focus();
                return;
            }
            //将输入的信息给到实体学生的学号上
            
            
            Entity.Student student = new Entity.Student();
            student.StudentNo = Convert .ToInt32 (txtStudentID.Text.Trim());

            //调用外观层，得到已经赋值的学生
            Facade.StudentFacade studentfacade = new Facade.StudentFacade();

            IList<Entity.Student> Student = new List<Entity.Student>();

          
            Student  = studentfacade.studentfacade(student);
            if (Student.Count == 0)
            { MessageBox.Show("没有该学生信息，请核对后再输入！");
           // this.Dispose();
            }
            else
            {
                //显示窗体
                txtStudentName.Text = Student[0].Name;
                txtSex.Text = Student[0].Sex;
                txtDepartment.Text = Student[0].Department;
                txtGrade.Text = Student[0].Grade;
                txtClass.Text = Student[0].Class;
                txtNotice.Text = Student[0].Notes;
            }

            #region 修改学生基本信息--2017-02-07



            #endregion


        }

        private void txtNotice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar !=(char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;             
            }
            
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
