namespace UI
{
    partial class frmOnlineQuery
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
            this.SuspendLayout();
            // 
            // cmbFields1
            // 
            this.cmbFields1.SelectedIndexChanged += new System.EventHandler(this.cmbFields1_SelectedIndexChanged);
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
            // txtContext1
            // 
            this.txtContext1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContext1_KeyPress);
            // 
            // btOk
            // 
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btClear
            // 
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(903, 186);
            this.btCancel.Size = new System.Drawing.Size(95, 27);
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
            // frmOnlineQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1074, 628);
            this.Name = "frmOnlineQuery";
            this.Text = "学生上机统计信息";
            this.Load += new System.EventHandler(this.frmOnlineQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
