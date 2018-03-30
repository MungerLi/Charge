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
    public partial class frmOn : Form
    {
        public frmOn()
        {
            InitializeComponent();
            
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 上机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Card card = new Entity.Card();
            //卡号
            card.CardNo = Convert .ToInt16 (txtCardno.Text.Trim());
           // Facade.QuerIesitCardno queryExitCardno = new Facade.QuerIesitCardno();
            Facade.QueyExitCardno queryExitCardno = new Facade.QueyExitCardno();
            IList<Entity.Card> lCard = new List<Entity.Card>();
            lCard = queryExitCardno.queryExitCardno(card);

            if (lCard.Count == 0)
            {
                MessageBox.Show("请确定该卡号是否可用！");
                
                txtCardno.Text = "";


            }
            else
            {
                //判断上机的金额是否满足要求
                Entity.BasicData basicdate = new Entity.BasicData();
                Facade.QueryBasicDateFacade queryBasicDate = new Facade.QueryBasicDateFacade();
                IList<Entity.BasicData> LbasicDate = queryBasicDate.QueryBasicDate(basicdate);

                if (lCard[0].Money < LbasicDate[0].LeastMoney)
                { MessageBox.Show("您的余额不满足上机条件，请充值！"); }
                else
                {
                    //正在上机不符合条件--2017.01.20
                    Entity.online online = new Entity.online();
                    online.CardNo = Convert.ToInt16(txtCardno.Text.Trim());
                    Facade.IsOnlineFacade IsOnline = new Facade.IsOnlineFacade();
                    IList<Entity.online> lonline = new List<Entity.online>();
                    lonline = IsOnline.IsOnline(online);
                    if (lonline.Count != 0)
                    {
                        MessageBox.Show("该卡号正在上机，请重新选择卡号！");

                    }

                    else
                    {
                        Entity.Student student = new Entity.Student();
                        student.StudentNo = lCard[0].StudentNo;
                        Facade.StudentFacade studentinfo = new Facade.StudentFacade();
                        IList<Entity.Student> lstudent = new List<Entity.Student>();
                        lstudent = studentinfo.studentfacade(student);

                        txtStudentNo.Text = lstudent[0].StudentNo.ToString();
                        txtName.Text = lstudent[0].Name;
                        txtSex.Text = lstudent[0].Sex.ToString();
                        txtType.Text = lstudent[0].Notes.ToString();





                        //将正在上机的信息读入onlie表
                        // Entity.online online = new Entity.online();

                        online.CardNo = lCard[0].CardNo;
                        online.StudentNo = lCard[0].StudentNo;
                        online.studentname = txtName.Text;
                        online.studentsex = txtSex.Text;



                        online.cardType = lCard[0].Type;
                        online.Computer = Environment.MachineName;

                        Facade.addOnlineFacade addOnline = new Facade.addOnlineFacade();
                        addOnline.addOnline(online);

                        //获得数据库的当前时间
                        Facade.IsOnlineFacade Online = new Facade.IsOnlineFacade();
                        IList<Entity.online> Lonline = new List<Entity.online>();
                        Lonline = IsOnline.IsOnline(online);
                        txtONdate.Text = Lonline[0].ondate.ToString();
                        txtOntime.Text = Lonline[0].ontime.ToString();

                        //将正在上机的信息读入line表
                        Entity.line line = new Entity.line();

                        line.CardNo = lCard[0].CardNo;
                        //line.UserID = frmLogin.UserName;
                        line.LoginDate = Convert.ToDateTime(txtONdate.Text);
                        line.LoginTime = TimeSpan.Parse(txtOntime.Text);
                        line.Status = "正常上机";
                        line.StudentNo = lCard[0].StudentNo;
                        line.StudentName = txtName.Text;
                        line.Computer = Environment.MachineName;
                        line.sex = txtSex.Text;
                        Facade.AddLineFacade addLine = new Facade.AddLineFacade();
                        addLine.addLine(line);

                        MessageBox.Show("上机成功，感谢使用！");


                    }
                }
            }

        }

        private void frmOn_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();

            //将online实体中可以访问到的总数显示
            Entity.online online = new Entity.online();
            Facade.IsOnlineFacade IsOnline = new Facade.IsOnlineFacade();
            IList<Entity.online> lonline = new List<Entity.online>();
            lonline = IsOnline.IsOnline(online);
            lbCount.Text = lonline.Count.ToString();

        }
        
        /// <summary>
        /// 下机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //给实体online装参数--正在上机才可以下机
            Entity.online online = new Entity.online();
            online.CardNo = Convert.ToInt16(txtCardno.Text);
            Facade.IsOnlineFacade Isonline = new Facade.IsOnlineFacade();
            IList<Entity.online> lonline = new List<Entity.online>();
            lonline = Isonline.IsOnline(online);

            if (lonline.Count == 0)
            {
                MessageBox.Show("该卡号下没有学生上机，请选择正在上机的卡号！");
                txtCardno.Text = "";
                txtCardno.Focus();
            
            }
            else 
            {
                //将剩余参数带给line实体
                    //补充，这里给line传入金额--2017-02-11
                        Entity.Card card = new Entity.Card();
                        //卡号
                        card.CardNo = Convert.ToInt16(txtCardno.Text.Trim());
                        // Facade.QuerIesitCardno queryExitCardno = new Facade.QuerIesitCardno();
                        Facade.QueyExitCardno queryExitCardno = new Facade.QueyExitCardno();
                        IList<Entity.Card> lCard = new List<Entity.Card>();
                        lCard = queryExitCardno.queryExitCardno(card);
                Entity.line line = new Entity.line();
                //line.OffDate =Convert .ToDateTime (DateTime.Now.Date.ToShortDateString ());
                //line.OffTime = TimeSpan.Parse(DateTime.Now.ToLongTimeString());
                //line.ConsumeTime =Convert.ToInt16 (lbConsumer.Text);  //不合理，为啥，因为可以让好多人上机，但是呢？只能显示最后一个上机的人的时间
                
                line.CardNo = lonline[0].CardNo; //之前line表有的一些参数,根据这些信息找到缺失信息的表
                line.LoginDate = lonline[0].ondate;
                line.LoginTime = lonline[0].ontime;
                line.Money = lCard[0].Money;
                line.Status = "正常下机";
                
                Facade.AddLineFacade addLineOff = new Facade.AddLineFacade();
                addLineOff.addLineOff(line);

                //计算金额，显示消费时间和金额
                Facade.CountMoneyFacade countMoneyfacade = new Facade.CountMoneyFacade();
                IList<Entity.line> LineAll = new List<Entity.line>();
                LineAll = countMoneyfacade.CountMoney(line);
                
                txtConsumeMoney.Text = LineAll[0].ConsumeMoney.ToString();
                txtConsumeTime.Text = LineAll[0].ConsumeTime.ToString();
                txtName.Text = LineAll[0].StudentName;
                txtoffDate.Text = LineAll[0].OffDate.ToString();
                txtoffTime.Text = LineAll[0].OffTime.ToString ();
                txtONdate.Text = LineAll[0].OffDate.ToString();
                txtOntime.Text = LineAll[0].LoginTime.ToString();
                txtSex.Text = LineAll[0].sex;
                txtStudentNo.Text = LineAll[0].StudentNo.ToString() ;
                txtType.Text = LineAll[0].Status;

                //从card实体中获得消费的剩余金额,同时更新card表
                Entity.Card Card = new Entity.Card();
                Card.CardNo = Convert.ToInt16(txtCardno.Text);
                IList<Entity.Card> LCard = new List<Entity.Card>();

                Facade.StudentMoneyFacade CardMoney = new Facade.StudentMoneyFacade();
                LCard = CardMoney.StudentMoney(Card);

                    //余额的填充
                txtMoney.Text = (Convert.ToInt16(LCard[0].Money ) - Convert.ToInt16(LineAll[0].ConsumeMoney)).ToString();//////
                

                //更新表card
                Card.Money = Convert.ToInt16(txtMoney.Text);
                Facade.UpdateMoneyFacade UpdateMoney = new Facade.UpdateMoneyFacade();
                UpdateMoney.UpdateMoney(Card);
                
                    //判断余额，如果余额花完的话需要充点钱
                IList<Entity.Card> IfCardmomey = new List<Entity.Card>();
                IfCardmomey = CardMoney.StudentMoney(Card);
                if (IfCardmomey[0].Money < 0)
                {
                    MessageBox.Show("您需要充值现金"+IfCardmomey[0].Money.ToString()+"元！");
                }
                txtMoney.Text = IfCardmomey[0].Money.ToString();

                //将正在上机表下机
                Facade.deleteFacade deleteOnlineFacade = new Facade.deleteFacade();
                deleteOnlineFacade.DeleteOnline(online);

            }


        }

        private void timConsumer_Tick(object sender, EventArgs e)
        {


         
            
        }

        private void txtCardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }
    }
}
