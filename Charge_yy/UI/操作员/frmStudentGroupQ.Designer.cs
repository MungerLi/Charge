namespace UI
{
    partial class frmStudentGroupQ
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFields1
            // 
            this.cmbFields1.SelectedValueChanged += new System.EventHandler(this.cmbFields1_SelectedValueChanged);
            // 
            // cmbFields2
            // 
            this.cmbFields2.SelectedValueChanged += new System.EventHandler(this.cmbFields2_SelectedValueChanged);
            // 
            // cmbFields3
            // 
            this.cmbFields3.SelectedValueChanged += new System.EventHandler(this.cmbFields3_SelectedValueChanged);
            // 
            // dtTime1
            // 
            this.dtTime1.ValueChanged += new System.EventHandler(this.dtTime1_ValueChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(904, 106);
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(904, 161);
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(904, 216);
            // 
            // cmbRelation2
            // 
            this.cmbRelation2.Items.AddRange(new object[] {
            "与",
            "或",
            "与",
            "或",
            "与",
            "或",
            "与",
            "或"});
            // 
            // cmbRelation1
            // 
            this.cmbRelation1.Items.AddRange(new object[] {
            "与",
            "或",
            "与",
            "或",
            "与",
            "或",
            "与",
            "或"});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(250, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(736, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmStudentGroupQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1074, 713);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmStudentGroupQ";
            this.Text = "学生基本信息维护";
            this.Load += new System.EventHandler(this.frmStudentGroupQ_Load);
            this.Controls.SetChildIndex(this.btOk, 0);
            this.Controls.SetChildIndex(this.btClear, 0);
            this.Controls.SetChildIndex(this.btCancel, 0);
            this.Controls.SetChildIndex(this.cmbFields1, 0);
            this.Controls.SetChildIndex(this.cmbFields2, 0);
            this.Controls.SetChildIndex(this.cmbFields3, 0);
            this.Controls.SetChildIndex(this.cmbRelation1, 0);
            this.Controls.SetChildIndex(this.cmbRelation2, 0);
            this.Controls.SetChildIndex(this.txtContext1, 0);
            this.Controls.SetChildIndex(this.txtContext2, 0);
            this.Controls.SetChildIndex(this.txtContext3, 0);
            this.Controls.SetChildIndex(this.dtTime1, 0);
            this.Controls.SetChildIndex(this.dtTime2, 0);
            this.Controls.SetChildIndex(this.dtTime3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
