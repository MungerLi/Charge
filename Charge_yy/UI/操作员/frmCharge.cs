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
    public partial class frmCharge : Form
    {
        public frmCharge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判空
            if (txtcardno.Text == "")
            {
                MessageBox.Show("请输入卡号", "提示");
                txtcardno.Focus();
                return;
            }

            if (txtMoney.Text == "")
            {
                MessageBox.Show("请输入金额", "提示");
                txtMoney.Focus();
                return;
            }
            //金额是否满足充值条件
            //的金额是否满足要求
            Entity.BasicData basicdate = new Entity.BasicData();
            Facade.QueryBasicDateFacade queryBasicDate = new Facade.QueryBasicDateFacade();
            IList<Entity.BasicData> LbasicDate = queryBasicDate.QueryBasicDate(basicdate);

            if (Convert.ToInt16(txtMoney.Text) < LbasicDate[0].LeastMoney)
            {
                MessageBox.Show("你的充值金额太少，请修改！", "提示");
                txtMoney.Focus();
                return;

            }
            //查询卡号是否存在，可以使用
            Entity.Card card = new Entity.Card();
            card.CardNo =Convert.ToInt16( txtcardno.Text);

            Facade.QuerIesitCardno Queryisexit = new Facade.QuerIesitCardno();
            IList<Entity.Card> QueryCardExit = new List<Entity.Card>();
            QueryCardExit = Queryisexit.QuerIsexitcardno(card);
            if (QueryCardExit.Count == 0)
            {
                MessageBox.Show("没有该卡号，请核对后充值！", "提示");
                txtcardno.Text = "";
                txtMoney.Text = "";
                txtcardno.Focus();
                return;
            }
            //可以充值，并在b层做逻辑判断，更新cardno中的money
            else
            {
                Entity.Charge charge = new Entity.Charge();
                charge.CardNo = txtcardno.Text;
                charge.StudentNo = QueryCardExit[0].StudentNo;
                charge.UserID = frmLogin.UserName; //----------------------------
                //charge.UserID = "YY";
                charge.AddMoney =Convert.ToInt16(txtMoney.Text);

                Facade.AddChargeAndReturn addCharge = new Facade.AddChargeAndReturn();
                bool flag;
                flag = addCharge.addCharge(charge);
                if (flag == true)
                {
                    MessageBox.Show("充值成功！", "提示");
                    
                    //txt.Text = "姓名：" + Student[0].Name + "\r\n" + "性别：" + Student[0].Sex + "\r\n" + "年级：" + Student[0].Grade + "\r\n" + "班级：" + Student[0].Class + "\r\n" + "专业：" + Student[0].Department + "\r\n";
                    //txt.Text ="学号："+ QueryCardExit[0].StudentNo +"\r\n"+"卡号:"+QueryCardExit[0].CardNo +"\r\n"+
                    return;
                }

            }
        }

        private void frmCharge_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            //判空
            if (txtReturnCardno.Text == "")
            {
                MessageBox.Show("请输入退卡卡号", "提示");
                txtReturnCardno.Focus();
                return;
            }
            //正在上机的卡不可退
            Entity.online online = new Entity.online();
            online.CardNo =Convert.ToInt16( txtReturnCardno.Text);
            Facade.IsOnlineFacade onlineFac = new Facade.IsOnlineFacade();
            IList<Entity.online> lonline = onlineFac.IsOnline(online);
            if (lonline.Count > 0)
            {
                MessageBox.Show("该卡正在上机，下机后可退卡！", "提示");
                return;
            }
            else
            {

                //有卡，正在使用可以退，退的意思修改使用状态
                Entity.Card card = new Entity.Card();
                card.CardNo = Convert.ToInt16(txtReturnCardno.Text);

                Facade.QuerIesitCardno Queryisexit = new Facade.QuerIesitCardno();
                IList<Entity.Card> QueryCardExit = new List<Entity.Card>();
                QueryCardExit = Queryisexit.QuerIsexitcardno(card);
                if (QueryCardExit.Count == 0)
                {
                    MessageBox.Show("没有该卡号，请核对后退卡！", "提示");
                    txtReturnCardno.Text = "";
                    txtReturnCardno.Focus();
                    return;
                }
                else
                {
                    //将退卡的信息，给到实体returncard,添加
                    Entity.ReturnCard returnCard = new Entity.ReturnCard();
                    returnCard.CardNo = QueryCardExit[0].CardNo;
                    returnCard.UserID = QueryCardExit[0].UserID;
                    returnCard.ReturnMoney = QueryCardExit[0].Money;
                    returnCard.IsCheck = "未结账";

                    Facade.AddChargeAndReturn addReturn = new Facade.AddChargeAndReturn();
                    addReturn.addReturn(returnCard);

                    //设置卡号为未使用
                    Facade.UpdateMoneyFacade modifyState = new Facade.UpdateMoneyFacade();
                    modifyState.ModifyState(card);

                    MessageBox.Show("退卡成功！", "提示");
                    txtReturnMoney.Text = QueryCardExit[0].Money.ToString();
                    return;
                }
            }
        }

        private void txtcardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }

        private void txtReturnCardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                MessageBox.Show("请输入数字！", "提示");
                e.Handled = true;
            }
        }
    }
}
