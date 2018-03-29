namespace UI
{
    partial class frmOn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOn));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtoffTime = new System.Windows.Forms.TextBox();
            this.txtOntime = new System.Windows.Forms.TextBox();
            this.txtoffDate = new System.Windows.Forms.TextBox();
            this.txtONdate = new System.Windows.Forms.TextBox();
            this.txtConsumeMoney = new System.Windows.Forms.TextBox();
            this.txtConsumeTime = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(268, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "上机";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(596, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "下机";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入卡号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCardno
            // 
            this.txtCardno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardno.Location = new System.Drawing.Point(242, 113);
            this.txtCardno.MaxLength = 8;
            this.txtCardno.Multiline = true;
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(154, 29);
            this.txtCardno.TabIndex = 3;
            this.txtCardno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(189, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(542, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(189, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "学号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(542, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "姓名：";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(271, 243);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(128, 29);
            this.txtType.TabIndex = 8;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStudentNo.Location = new System.Drawing.Point(271, 319);
            this.txtStudentNo.Multiline = true;
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.ReadOnly = true;
            this.txtStudentNo.Size = new System.Drawing.Size(128, 29);
            this.txtStudentNo.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(624, 311);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(128, 29);
            this.txtName.TabIndex = 10;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSex.Location = new System.Drawing.Point(624, 243);
            this.txtSex.Multiline = true;
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(128, 29);
            this.txtSex.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(542, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "上机时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(189, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "上机日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(189, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "下机日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(542, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "下机时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(189, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "余额：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(542, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "消费时间：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(542, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "消费金额：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(93, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "当前上机人数为：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(534, 638);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "当前时间为：";
            // 
            // txtoffTime
            // 
            this.txtoffTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtoffTime.Location = new System.Drawing.Point(659, 424);
            this.txtoffTime.Multiline = true;
            this.txtoffTime.Name = "txtoffTime";
            this.txtoffTime.ReadOnly = true;
            this.txtoffTime.Size = new System.Drawing.Size(128, 29);
            this.txtoffTime.TabIndex = 21;
            // 
            // txtOntime
            // 
            this.txtOntime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOntime.Location = new System.Drawing.Point(659, 367);
            this.txtOntime.Multiline = true;
            this.txtOntime.Name = "txtOntime";
            this.txtOntime.ReadOnly = true;
            this.txtOntime.Size = new System.Drawing.Size(128, 29);
            this.txtOntime.TabIndex = 22;
            // 
            // txtoffDate
            // 
            this.txtoffDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtoffDate.Location = new System.Drawing.Point(315, 448);
            this.txtoffDate.Multiline = true;
            this.txtoffDate.Name = "txtoffDate";
            this.txtoffDate.ReadOnly = true;
            this.txtoffDate.Size = new System.Drawing.Size(128, 29);
            this.txtoffDate.TabIndex = 23;
            // 
            // txtONdate
            // 
            this.txtONdate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtONdate.Location = new System.Drawing.Point(315, 393);
            this.txtONdate.Multiline = true;
            this.txtONdate.Name = "txtONdate";
            this.txtONdate.ReadOnly = true;
            this.txtONdate.Size = new System.Drawing.Size(128, 29);
            this.txtONdate.TabIndex = 24;
            // 
            // txtConsumeMoney
            // 
            this.txtConsumeMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConsumeMoney.Location = new System.Drawing.Point(659, 513);
            this.txtConsumeMoney.Multiline = true;
            this.txtConsumeMoney.Name = "txtConsumeMoney";
            this.txtConsumeMoney.ReadOnly = true;
            this.txtConsumeMoney.Size = new System.Drawing.Size(128, 29);
            this.txtConsumeMoney.TabIndex = 25;
            // 
            // txtConsumeTime
            // 
            this.txtConsumeTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConsumeTime.Location = new System.Drawing.Point(659, 465);
            this.txtConsumeTime.Multiline = true;
            this.txtConsumeTime.Name = "txtConsumeTime";
            this.txtConsumeTime.ReadOnly = true;
            this.txtConsumeTime.Size = new System.Drawing.Size(128, 29);
            this.txtConsumeTime.TabIndex = 26;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMoney.Location = new System.Drawing.Point(315, 511);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(128, 29);
            this.txtMoney.TabIndex = 27;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BackColor = System.Drawing.Color.Transparent;
            this.lbCount.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCount.Location = new System.Drawing.Point(285, 638);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(22, 21);
            this.lbCount.TabIndex = 28;
            this.lbCount.Text = "0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.Location = new System.Drawing.Point(669, 638);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(22, 21);
            this.lbTime.TabIndex = 29;
            this.lbTime.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1254, 716);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtConsumeTime);
            this.Controls.Add(this.txtConsumeMoney);
            this.Controls.Add(this.txtONdate);
            this.Controls.Add(this.txtoffDate);
            this.Controls.Add(this.txtOntime);
            this.Controls.Add(this.txtoffTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上下机";
            this.Load += new System.EventHandler(this.frmOn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtoffTime;
        private System.Windows.Forms.TextBox txtOntime;
        private System.Windows.Forms.TextBox txtoffDate;
        private System.Windows.Forms.TextBox txtONdate;
        private System.Windows.Forms.TextBox txtConsumeMoney;
        private System.Windows.Forms.TextBox txtConsumeTime;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
    }
}