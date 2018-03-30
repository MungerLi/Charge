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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“check_returnCard.ReturnCard_info”中。您可以根据需要移动或删除它。
            this.returnCard_infoTableAdapter.Fill(this.check_returnCard.ReturnCard_info);
            // TODO: 这行代码将数据加载到表“chargeDataSet3check_chargeCard.Charge_info”中。您可以根据需要移动或删除它。
            //this.charge_infoTableAdapter1.Fill(this.chargeDataSet3check_chargeCard.Charge_info);
            // TODO: 这行代码将数据加载到表“check_buyCard.Card_info”中。您可以根据需要移动或删除它。
            //this.card_infoTableAdapter.Fill(this.check_buyCard.Card_info);
            this.queryUserIDToolStrip.Hide();
            this.queryCharge1ToolStrip.Hide();
            this.queryReturnCardToolStrip.Hide();
            //加载窗体将操作员和管理员的放入 其中
            Entity.User user = new Entity.User ();
            IList<Entity.User> Luser = new List<Entity.User>();
            Facade.QueryUserFacade QueryUser = new Facade.QueryUserFacade();
            Luser = QueryUser.QueryUser(user); 

            
            for (int i = 1; i < Luser.Count; i++)
            {
                CbUserID.Items .Add(Luser[i].UserID) ;
            }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabCancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryUserIDToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.card_infoTableAdapter.queryUserID(this.check_buyCard.Card_info, paraToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void txtregistered_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage1)
            {
                try
                {
                    this.card_infoTableAdapter.queryUserID(this.check_buyCard.Card_info, paraToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            if (e.TabPage == tabPage2)
            {
                try
                {
                    this.charge_infoTableAdapter1.queryCharge1(this.chargeDataSet3check_chargeCard.Charge_info, userIDToolStripTextBox.Text, ischeckToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
      
            }

            if (e.TabPage == tabPage3)
            {
                try
                {
                    this.returnCard_infoTableAdapter.QueryReturnCard(this.check_returnCard.ReturnCard_info, userIDToolStripTextBox1.Text, isCheckToolStripTextBox1.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

            if (e.TabPage == tabPage4)
            {
                if (CbUserID .Text =="")
                {
                    MessageBox.Show ("请选择用户名");
                    btCheckOut.Enabled = false;
                    return ;

                }
                btCheckOut.Enabled = true ;
                Facade.CheckOutFacade Checkout = new Facade.CheckOutFacade();
                //得到售卡张数
                Entity.Card card = new Entity.Card();
                card.UserID = CbUserID.Text.Trim();

                IList<Entity.Card> Lcard = new List<Entity.Card>();
                Lcard = Checkout.checkOutCard(card);
                txtSellCard.Text = Lcard.Count.ToString();
                
                
                //退卡张数
                Entity.ReturnCard returnCard = new Entity.ReturnCard();
                returnCard.UserID =CbUserID.Text.Trim ();
                IList<Entity.ReturnCard> LreturnCard = new List<Entity.ReturnCard>();
                LreturnCard = Checkout.CheckOutReturnCard(returnCard);
                txtReturnCard.Text = LreturnCard.Count.ToString();

                //总售卡数
                txtSumCount.Text = (Lcard.Count - LreturnCard.Count).ToString(); 
                
                //退卡金额
                int sumReturnMoney;
                sumReturnMoney = 0;
                for (int i = 0; i < LreturnCard.Count; i++)
                {
                    
                 sumReturnMoney += LreturnCard[i].ReturnMoney;
                    
                }
                txtReturnMoney.Text = sumReturnMoney.ToString();
                
                //充值金额
                Entity.Charge Charge = new Entity.Charge ();
                Charge.UserID = CbUserID .Text .Trim ();
                Facade.CheckOutFacade charge = new Facade.CheckOutFacade ();
                IList <Entity.Charge > LchargeMoney = new List <Entity.Charge >();
                LchargeMoney = charge.checkOutCharge (Charge);
                
                int SumChargeMoney;
                SumChargeMoney = 0;
                for (int i = 0;i<LchargeMoney.Count ;i++)
                {
                    SumChargeMoney += LchargeMoney[i].AddMoney;
                }
                txtChargeMoney.Text = SumChargeMoney.ToString();
               
                //应收金额
                txtMoney.Text = (SumChargeMoney - sumReturnMoney).ToString();

                if (e.TabPage == tabPage5)
                {
                    this.Dispose();
                }
            }
        }

        private void frmUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据用户的ID知道用户姓名
            Entity.User user = new Entity.User();
            user.UserID = CbUserID.Text;
            Facade.QueryUserFacade QueryUser = new Facade.QueryUserFacade();

            IList<Entity.User> Luser = new List<Entity.User>();
            
            Luser = QueryUser.QueryUser(user);

            txtUserName.Text = Luser[0].UserName;
            

            // 显示内容在tab1的date中
            paraToolStripTextBox.Text = CbUserID.Text;
           
            try
            {
                this.card_infoTableAdapter.queryUserID(this.check_buyCard.Card_info, paraToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //将值传给tab2，以达到传值
            userIDToolStripTextBox.Text = CbUserID.Text;
            ischeckToolStripTextBox.Text = "未结账";

            //将值传给tab3
            userIDToolStripTextBox1.Text = CbUserID.Text;
            isCheckToolStripTextBox1.Text = "未结账";
        }

        private void txtregistered_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtregistered_Click(object sender, EventArgs e)
        {
            
        }

        private void queryChargeToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter1.QueryCharge(this.chargeDataSet3check_chargeCard.Charge_info, paraToolStripTextBox1.Text, para2ToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void queryCharge1ToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter1.queryCharge1(this.chargeDataSet3check_chargeCard.Charge_info, userIDToolStripTextBox.Text, ischeckToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.charge_infoTableAdapter1.FillBy(this.chargeDataSet3check_chargeCard.Charge_info, userIDToolStripTextBox1.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void queryReturnCardToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.returnCard_infoTableAdapter.QueryReturnCard(this.check_returnCard.ReturnCard_info, userIDToolStripTextBox1.Text, isCheckToolStripTextBox1.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void queryCharge1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            string userID;
            userID = CbUserID.Text.Trim();

            Facade.CheckOutFacade modifyIsCheck = new Facade.CheckOutFacade();
            modifyIsCheck.ModifyIsCheckOut(userID);
            MessageBox.Show("结账成功！");
        }
    }
}
