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
    public partial class frmModifyStudent : Form
    {
        public frmModifyStudent()
        {
            InitializeComponent();
        }

        private void frmModifyStudent_Load(object sender, EventArgs e)
        {
            cbsex.Items.Add("男");
            cbsex.Items.Add("女");

            Entity.Student studentinfo = new Entity.Student();
            studentinfo.StudentNo =  frmStudentGroupQ.student.StudentNo;

            //调用外观层，得到已经赋值的学生
            Facade.StudentFacade studentfacade = new Facade.StudentFacade();

            IList<Entity.Student> Student = new List<Entity.Student>();


            Student = studentfacade.studentfacade(studentinfo);
            
            
           

                //显示窗体
                txtStudentName.Text = Student[0].Name;
                 cbsex .Text = Student[0].Sex;
                txtDepartment.Text = Student[0].Department;
                txtGrade.Text = Student[0].Grade;
                txtClass.Text = Student[0].Class;
                txtNotice.Text = Student[0].Notes;
                txtStudentID.Text = frmStudentGroupQ.student.StudentNo.ToString ();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判空

            //txtStudentID.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                if (con.Text == "" && con is TextBox)
                {
                    MessageBox.Show("请填写修改内容");
                    con.Focus();
                }

                
                
            }
            

            Entity.Student student = new Entity.Student();
            student.StudentNo = Convert.ToInt16(txtStudentID.Text.Trim());
            student.Name = txtStudentName.Text.Trim();
            student.Sex = cbsex.Text.Trim();
            student.Department = txtDepartment.Text.Trim();
            student.Class = txtClass.Text.Trim();
            student.Grade = txtGrade.Text.Trim();
            student.Notes = txtNotice.Text.Trim();

            Facade.ModifyStudentinfoFacade modifyStudent = new Facade.ModifyStudentinfoFacade();
            modifyStudent.ModifyStudent(student);

            MessageBox.Show("修改成功");
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入文字！", "提示");
                e.Handled = true;
            }
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("请输入文字或数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8 && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("请输入文字或数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入文字！", "提示");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
