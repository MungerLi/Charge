namespace UI
{
    partial class frmModifyPWD
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldpwd = new System.Windows.Forms.TextBox();
            this.txtNewpwd = new System.Windows.Forms.TextBox();
            this.txtConfigpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "旧口令：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "新口令：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认口令：";
            // 
            // txtOldpwd
            // 
            this.txtOldpwd.Location = new System.Drawing.Point(166, 34);
            this.txtOldpwd.MaxLength = 10;
            this.txtOldpwd.Name = "txtOldpwd";
            this.txtOldpwd.Size = new System.Drawing.Size(135, 21);
            this.txtOldpwd.TabIndex = 5;
            // 
            // txtNewpwd
            // 
            this.txtNewpwd.Location = new System.Drawing.Point(166, 82);
            this.txtNewpwd.MaxLength = 10;
            this.txtNewpwd.Name = "txtNewpwd";
            this.txtNewpwd.PasswordChar = '*';
            this.txtNewpwd.Size = new System.Drawing.Size(135, 21);
            this.txtNewpwd.TabIndex = 6;
            // 
            // txtConfigpwd
            // 
            this.txtConfigpwd.Location = new System.Drawing.Point(166, 128);
            this.txtConfigpwd.MaxLength = 10;
            this.txtConfigpwd.Name = "txtConfigpwd";
            this.txtConfigpwd.PasswordChar = '*';
            this.txtConfigpwd.Size = new System.Drawing.Size(135, 21);
            this.txtConfigpwd.TabIndex = 7;
            // 
            // frmModifyPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 290);
            this.Controls.Add(this.txtConfigpwd);
            this.Controls.Add(this.txtNewpwd);
            this.Controls.Add(this.txtOldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmModifyPWD";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmModifyPWD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldpwd;
        private System.Windows.Forms.TextBox txtNewpwd;
        private System.Windows.Forms.TextBox txtConfigpwd;
    }
}