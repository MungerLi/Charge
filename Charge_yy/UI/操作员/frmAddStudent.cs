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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            cbSex.Items.Add("男");
            cbSex.Items.Add("女");
            toolTip1.SetToolTip(txtStudentID, "请输入数字！");

            toolTip1.SetToolTip(txtStudentName , "请输入文字！");
            toolTip1.SetToolTip(txtGrade , "请输入数字或文字！");
            toolTip1.SetToolTip(txtGrade, "请输入数字或文字！");
            toolTip1.SetToolTip(txtDepartment , "请输入文字！");
            toolTip1.SetToolTip(txtNotice , "此处不能为空！");
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EmptyUI.IsChinese(e.KeyChar.ToString()) == false && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入文字！", "提示");
                e.Handled = true;
            }
        }

        private void txtStudentName_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            //if (EmptyUI.IsChinese(txtStudentName.Text) == false)
            //{
            //    MessageBox.Show("请输入文字！", "提示");
            //    //e.Handled = true;
            //}
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            //判空
            foreach (Control con in this.Controls )
            {
                if (con.Text == "")
                {
                    MessageBox.Show("请将内容补充完整", "提示");
                    con.Focus();
                    return;
                }
            }

            foreach (Control contxt in this.groupBox1.Controls)
            {
                if (contxt.Text == "")
                {
                    MessageBox.Show("请将内容补充完整", "提示");
                    contxt.Focus();
                    return;
                }
            }

           //查找学号，如果没有该学号，则将信息添加到学生库中
            Entity.Student student = new Entity.Student();
            student.StudentNo = Convert.ToInt16(txtStudentID.Text);
            student.Name = txtStudentName.Text;
            student.Grade = txtGrade.Text;
            student.Class = txtClass.Text;
            student.Sex = cbSex.Text;
            student.Department = txtDepartment.Text;
            student.Notes = txtNotice.Text;

            
            //调用外观层，得到已经赋值的学生
            Facade.StudentFacade studentfacade = new Facade.StudentFacade();

            IList<Entity.Student> Student = new List<Entity.Student>();

          
            Student  = studentfacade.studentfacade(student);
            if (Student.Count == 0) //该学号没有使用可以使用
            {
                Facade.AddStudentFacade addStudentFacade = new Facade.AddStudentFacade();
                bool flag;
                flag = addStudentFacade.addStudent(student);
                if (flag == true)
                {
                    MessageBox.Show("添加成功", "提示");
                    txtStudentID.Text = "";
                    txtStudentName.Text = "";
                    txtGrade.Text = "";
                    cbSex.Text = "";
                    txtDepartment.Text ="";
                    txtNotice.Text = "";
                    txtClass.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("该学号已占用，请重新输入学号！", "提示");
                txtStudentID.Text = "";
                txtStudentID.Focus();
                return;
            }


        }
    }
}
