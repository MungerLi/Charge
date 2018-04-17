namespace UI.一般用户
{
    partial class modifypwd
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
            this.lblOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPWD = new System.Windows.Forms.TextBox();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.txtNewPWDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOK
            // 
            this.lblOK.Location = new System.Drawing.Point(59, 175);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(75, 23);
            this.lblOK.TabIndex = 0;
            this.lblOK.Text = "确认";
            this.lblOK.UseVisualStyleBackColor = true;
            this.lblOK.Click += new System.EventHandler(this.lblOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "再次输入新密码：";
            // 
            // txtOldPWD
            // 
            this.txtOldPWD.Location = new System.Drawing.Point(176, 49);
            this.txtOldPWD.Name = "txtOldPWD";
            this.txtOldPWD.Size = new System.Drawing.Size(100, 21);
            this.txtOldPWD.TabIndex = 5;
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.Location = new System.Drawing.Point(176, 87);
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.Size = new System.Drawing.Size(100, 21);
            this.txtNewPWD.TabIndex = 6;
            // 
            // txtNewPWDT
            // 
            this.txtNewPWDT.Location = new System.Drawing.Point(176, 121);
            this.txtNewPWDT.Name = "txtNewPWDT";
            this.txtNewPWDT.Size = new System.Drawing.Size(100, 21);
            this.txtNewPWDT.TabIndex = 7;
            // 
            // modifypwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 240);
            this.Controls.Add(this.txtNewPWDT);
            this.Controls.Add(this.txtNewPWD);
            this.Controls.Add(this.txtOldPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOK);
            this.Name = "modifypwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPWD;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.TextBox txtNewPWDT;
    }
}