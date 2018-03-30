namespace UI
{
    partial class frmGroupQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cmbFields1 = new System.Windows.Forms.ComboBox();
            this.cmbFields2 = new System.Windows.Forms.ComboBox();
            this.cmbFields3 = new System.Windows.Forms.ComboBox();
            this.cmbOperator3 = new System.Windows.Forms.ComboBox();
            this.cmbOperator2 = new System.Windows.Forms.ComboBox();
            this.cmbOperator1 = new System.Windows.Forms.ComboBox();
            this.cmbRelation2 = new System.Windows.Forms.ComboBox();
            this.cmbRelation1 = new System.Windows.Forms.ComboBox();
            this.txtContext1 = new System.Windows.Forms.TextBox();
            this.txtContext2 = new System.Windows.Forms.TextBox();
            this.txtContext3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtTime1 = new System.Windows.Forms.DateTimePicker();
            this.dtTime2 = new System.Windows.Forms.DateTimePicker();
            this.dtTime3 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(85, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择查询内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(281, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "选择查询符号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(484, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "输入查询内容";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(682, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "选择组合关系";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(903, 60);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(95, 29);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(903, 122);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(95, 29);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "清空";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(903, 184);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 29);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "导出为excel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cmbFields1
            // 
            this.cmbFields1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFields1.FormattingEnabled = true;
            this.cmbFields1.Location = new System.Drawing.Point(75, 110);
            this.cmbFields1.Name = "cmbFields1";
            this.cmbFields1.Size = new System.Drawing.Size(139, 27);
            this.cmbFields1.TabIndex = 8;
            this.cmbFields1.SelectedIndexChanged += new System.EventHandler(this.cmbFields1_SelectedIndexChanged_1);
            this.cmbFields1.SelectedValueChanged += new System.EventHandler(this.cmbFields1_SelectedValueChanged);
            // 
            // cmbFields2
            // 
            this.cmbFields2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFields2.FormattingEnabled = true;
            this.cmbFields2.Location = new System.Drawing.Point(74, 163);
            this.cmbFields2.Name = "cmbFields2";
            this.cmbFields2.Size = new System.Drawing.Size(140, 27);
            this.cmbFields2.TabIndex = 9;
            this.cmbFields2.SelectedValueChanged += new System.EventHandler(this.cmbFields2_SelectedValueChanged);
            // 
            // cmbFields3
            // 
            this.cmbFields3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFields3.FormattingEnabled = true;
            this.cmbFields3.Location = new System.Drawing.Point(75, 215);
            this.cmbFields3.Name = "cmbFields3";
            this.cmbFields3.Size = new System.Drawing.Size(140, 27);
            this.cmbFields3.TabIndex = 10;
            this.cmbFields3.SelectedValueChanged += new System.EventHandler(this.cmbFields3_SelectedValueChanged);
            // 
            // cmbOperator3
            // 
            this.cmbOperator3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOperator3.FormattingEnabled = true;
            this.cmbOperator3.Location = new System.Drawing.Point(295, 215);
            this.cmbOperator3.Name = "cmbOperator3";
            this.cmbOperator3.Size = new System.Drawing.Size(116, 27);
            this.cmbOperator3.TabIndex = 13;
            // 
            // cmbOperator2
            // 
            this.cmbOperator2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOperator2.FormattingEnabled = true;
            this.cmbOperator2.Location = new System.Drawing.Point(295, 163);
            this.cmbOperator2.Name = "cmbOperator2";
            this.cmbOperator2.Size = new System.Drawing.Size(115, 27);
            this.cmbOperator2.TabIndex = 12;
            // 
            // cmbOperator1
            // 
            this.cmbOperator1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOperator1.FormattingEnabled = true;
            this.cmbOperator1.Location = new System.Drawing.Point(295, 108);
            this.cmbOperator1.Name = "cmbOperator1";
            this.cmbOperator1.Size = new System.Drawing.Size(115, 27);
            this.cmbOperator1.TabIndex = 11;
            // 
            // cmbRelation2
            // 
            this.cmbRelation2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelation2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRelation2.FormattingEnabled = true;
            this.cmbRelation2.Location = new System.Drawing.Point(686, 186);
            this.cmbRelation2.Name = "cmbRelation2";
            this.cmbRelation2.Size = new System.Drawing.Size(140, 27);
            this.cmbRelation2.TabIndex = 19;
            // 
            // cmbRelation1
            // 
            this.cmbRelation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelation1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRelation1.FormattingEnabled = true;
            this.cmbRelation1.Location = new System.Drawing.Point(686, 135);
            this.cmbRelation1.Name = "cmbRelation1";
            this.cmbRelation1.Size = new System.Drawing.Size(140, 27);
            this.cmbRelation1.TabIndex = 18;
            // 
            // txtContext1
            // 
            this.txtContext1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContext1.Location = new System.Drawing.Point(473, 108);
            this.txtContext1.MaxLength = 10;
            this.txtContext1.Name = "txtContext1";
            this.txtContext1.Size = new System.Drawing.Size(140, 29);
            this.txtContext1.TabIndex = 20;
            this.txtContext1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContext1_KeyPress);
            // 
            // txtContext2
            // 
            this.txtContext2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContext2.Location = new System.Drawing.Point(473, 163);
            this.txtContext2.MaxLength = 10;
            this.txtContext2.Name = "txtContext2";
            this.txtContext2.Size = new System.Drawing.Size(140, 29);
            this.txtContext2.TabIndex = 21;
            this.txtContext2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContext2_KeyPress);
            // 
            // txtContext3
            // 
            this.txtContext3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContext3.Location = new System.Drawing.Point(473, 215);
            this.txtContext3.MaxLength = 10;
            this.txtContext3.Name = "txtContext3";
            this.txtContext3.Size = new System.Drawing.Size(140, 29);
            this.txtContext3.TabIndex = 22;
            this.txtContext3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContext3_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 251);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(947, 364);
            this.dataGridView1.TabIndex = 23;
            // 
            // dtTime1
            // 
            this.dtTime1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime1.Location = new System.Drawing.Point(473, 108);
            this.dtTime1.Name = "dtTime1";
            this.dtTime1.Size = new System.Drawing.Size(140, 29);
            this.dtTime1.TabIndex = 24;
            this.dtTime1.Visible = false;
            this.dtTime1.ValueChanged += new System.EventHandler(this.dtTime1_ValueChanged);
            // 
            // dtTime2
            // 
            this.dtTime2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime2.Location = new System.Drawing.Point(473, 163);
            this.dtTime2.Name = "dtTime2";
            this.dtTime2.Size = new System.Drawing.Size(140, 29);
            this.dtTime2.TabIndex = 25;
            this.dtTime2.Visible = false;
            this.dtTime2.ValueChanged += new System.EventHandler(this.dtTime2_ValueChanged);
            // 
            // dtTime3
            // 
            this.dtTime3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtTime3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime3.Location = new System.Drawing.Point(473, 215);
            this.dtTime3.Name = "dtTime3";
            this.dtTime3.Size = new System.Drawing.Size(140, 29);
            this.dtTime3.TabIndex = 26;
            this.dtTime3.Visible = false;
            this.dtTime3.ValueChanged += new System.EventHandler(this.dtTime3_ValueChanged);
            // 
            // frmGroupQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 652);
            this.Controls.Add(this.dtTime3);
            this.Controls.Add(this.dtTime2);
            this.Controls.Add(this.dtTime1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtContext3);
            this.Controls.Add(this.txtContext2);
            this.Controls.Add(this.txtContext1);
            this.Controls.Add(this.cmbRelation2);
            this.Controls.Add(this.cmbRelation1);
            this.Controls.Add(this.cmbOperator3);
            this.Controls.Add(this.cmbOperator2);
            this.Controls.Add(this.cmbOperator1);
            this.Controls.Add(this.cmbFields3);
            this.Controls.Add(this.cmbFields2);
            this.Controls.Add(this.cmbFields1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGroupQuery";
            this.Text = "组合窗体模版";
            this.Load += new System.EventHandler(this.frmGroupQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOperator3;
        private System.Windows.Forms.ComboBox cmbOperator2;
        private System.Windows.Forms.ComboBox cmbOperator1;
        public System.Windows.Forms.ComboBox cmbFields1;
        public System.Windows.Forms.ComboBox cmbFields2;
        public System.Windows.Forms.ComboBox cmbFields3;
        public System.Windows.Forms.TextBox txtContext1;
        public System.Windows.Forms.TextBox txtContext2;
        public System.Windows.Forms.TextBox txtContext3;
        public System.Windows.Forms.DateTimePicker dtTime1;
        public System.Windows.Forms.DateTimePicker dtTime2;
        public System.Windows.Forms.DateTimePicker dtTime3;
        public System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button btOk;
        public System.Windows.Forms.Button btClear;
        public System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.ComboBox cmbRelation2;
        public System.Windows.Forms.ComboBox cmbRelation1;
    }
}