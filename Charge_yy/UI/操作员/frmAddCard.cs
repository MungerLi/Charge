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

    
    public partial class frmAddCard : Form
    {

        


        public frmAddCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtStudent 给到实体
            Entity.Student student = new Entity.Student();
            student.StudentNo = Convert.ToInt32 (txtStudentNo.Text);

            Facade.StudentFacade studentfacade = new Facade.StudentFacade();
            IList<Entity.Student> Student = new List<Entity.Student>();
            Student = studentfacade.studentfacade(student);

            if (Student.Count == 0)
            { MessageBox.Show("没有该生的信息哦，可以选择添加该生的信息~"); }
            else
            {
                txtInfo.Text = "姓名：" + Student[0].Name + "\r\n" + "性别：" + Student[0].Sex + "\r\n" + "年级：" + Student[0].Grade + "\r\n" + "班级：" + Student[0].Class + "\r\n" + "专业：" + Student[0].Department + "\r\n";
            }


        }

        private void frmAddCard_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtStudentNo, "请输入数字！");
            toolTip1.SetToolTip(txtCardNo , "请输入数字！");
            toolTip1.SetToolTip(txtMoney , "请输入数字！");
            //listbox.Items.Add ("固定用户");
            //listbox.Items.Add("临时用户");
            comboBox1.Items.Add("固定用户");
            comboBox1.Items.Add("临时用户");
            


        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //判空
            if (txtStudentNo.Text == "")
            {
                txtStudentNo.Focus();
                MessageBox.Show("请输入查询的内容~","提示");
                return;
            }

            if (txtCardNo.Text == "")
            {
                txtCardNo.Focus();
                MessageBox.Show("请输入查询的内容~", "提示");
                return;
            }

            if (txtMoney.Text == "")
            {
                txtMoney.Focus();
                MessageBox.Show("请输入查询的内容~", "提示");
                return;
            }

            if (comboBox1.Text == "")
            {
                comboBox1.Focus();
                MessageBox.Show("请输入查询的内容~", "提示");
                return;
            }

            //注册金额，不得小于最小的上机金额----------
            //的金额是否满足要求
            Entity.BasicData basicdate = new Entity.BasicData();
            Facade.QueryBasicDateFacade queryBasicDate = new Facade.QueryBasicDateFacade();
            IList<Entity.BasicData> LbasicDate = queryBasicDate.QueryBasicDate(basicdate);

            if (Convert.ToInt16(  txtMoney .Text)  < LbasicDate[0].LeastMoney)
            { 
                MessageBox.Show("您的注册余额不满足上使用条件，请修改！","提示");
                txtMoney.Focus();
                return;

            }


            //显示学生的信息，确保有学生
            //txtStudent 给到实体
            Entity.Student student = new Entity.Student();
            student.StudentNo = Convert.ToInt32(txtStudentNo.Text);

            Facade.StudentFacade studentfacade = new Facade.StudentFacade();
            IList<Entity.Student> Student = new List<Entity.Student>();
            Student = studentfacade.studentfacade(student);

            if (Student.Count == 0)
            { MessageBox.Show("没有该生的信息哦，可以选择添加该生的信息~");
            return;
            }
            else
            {
                txtInfo.Text = "姓名：" + Student[0].Name + "\r\n" + "性别：" + Student[0].Sex + "\r\n" + "年级：" + Student[0].Grade + "\r\n" + "班级：" + Student[0].Class + "\r\n" + "专业：" + Student[0].Department + "\r\n";
            }

            

            //将卡号的信息传给实体card，然后和数据库绑定
            Entity.Card card = new Entity.Card();
            
            card.StudentNo = Convert.ToInt32(txtStudentNo.Text);
            card.CardNo = Convert.ToInt32(txtCardNo.Text);
            card.Money = Convert.ToInt32(txtMoney.Text);
            //card.Type = listbox.Text .ToString();
            card.Type = comboBox1.Text.Trim();
            card.Notes = "使用";
            card.Status = "未结账";
            card.UserID = frmLogin.UserName;
            //card.UserID = "YY";

            //实体带给外观，返回该学号是否注册
            Facade.QuerIesitCardno Queryisexit = new Facade.QuerIesitCardno();
            IList<Entity.Card> QueryCardExit = new List<Entity.Card>();
            QueryCardExit = Queryisexit.QuerIsexitcardno(card);
            if (QueryCardExit.Count != 0)
            { 
                MessageBox.Show("该学生已注册，无需注册","提示");
                //获取学生已注册的信息
                card.CardNo = QueryCardExit[0].CardNo;
                Facade.StudentMoneyFacade QueryCardno = new Facade.StudentMoneyFacade();
                IList<Entity.Card> card_info = new List<Entity.Card>();                
                card_info = QueryCardno.StudentMoney(card);
                txtInfo.Clear();
               // txtInfo.Text = "姓名：" + card_info [0].StudentNo + "\r\n" + "性别：" + Student[0].Sex + "\r\n" + "年级：" + Student[0].Grade + "\r\n" + "班级：" + Student[0].Class + "\r\n" + "专业：" + Student[0].Department + "\r\n";
                txtInfo.Text = "姓名：" + Student[0].Name + "\r\n" + "性别：" + Student[0].Sex + "\r\n" + "年级：" + Student[0].Grade + "\r\n" + "班级：" + Student[0].Class + "\r\n" + "专业：" + Student[0].Department + "\r\n" + "卡号：" + card_info[0].CardNo.ToString() + "\r\n";
                txtCardNo.Text = "";
                txtMoney.Text = "";
                comboBox1.Text = "";

                return ;
            }

            else
            {
                //实体带给外观，返回是否有学号
                Facade.StudentMoneyFacade QueryCardno = new Facade.StudentMoneyFacade();
                IList<Entity.Card> card_info = new List<Entity.Card>();
                card_info = QueryCardno.StudentMoney(card);
                if (card_info.Count != 0)
                { MessageBox.Show("该卡号已被使用，请重新输入！");
                     return;
                }
                else
                {

                    //实体带参给facade,完成添加
                    Facade.addCardFacade addCard = new Facade.addCardFacade();
                    bool falg;
                    falg = addCard.addCard(card);
                    if (falg == true)
                    { MessageBox.Show("注册成功，您可以正常使用", "温馨提示"); }

                    //将注册的金额放到充值卡中
                    Entity.Charge charge = new Entity.Charge();
                    charge.CardNo = txtCardNo.Text;
                    charge.UserID = frmLogin.UserName;
                    charge.StudentNo = student.StudentNo;
                    charge.AddMoney =Convert.ToInt16( txtMoney.Text);

                    Facade.AddChargeAndReturn addMoney = new Facade.AddChargeAndReturn();
                    addMoney.addCharge(charge);
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
         
        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddstudent = new frmAddStudent();
            frmAddstudent.Show();
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
