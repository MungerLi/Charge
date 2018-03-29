namespace UI
{
    partial class frmChargeRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chargeMoneyDataSet = new UI.chargeMoneyDataSet();
            this.chargeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chargeDataSet2 = new UI.chargeDataSet2();
            this.charge_infoTableAdapter = new UI.chargeDataSet2TableAdapters.Charge_infoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.cardnoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cardnoToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.charge_infoTableAdapter1 = new UI.chargeMoneyDataSetTableAdapters.Charge_infoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.cardNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeMoneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.AddMoney,
            this.Date,
            this.Time,
            this.IsCheck,
            this.UserID,
            this.cardNo1DataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.addMoneyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.isCheckDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chargeinfoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(969, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CardNo1";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "卡号";
            this.Column1.Name = "Column1";
            // 
            // AddMoney
            // 
            this.AddMoney.DataPropertyName = "AddMoney";
            this.AddMoney.Frozen = true;
            this.AddMoney.HeaderText = "充值金额";
            this.AddMoney.Name = "AddMoney";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.Frozen = true;
            this.Date.HeaderText = "充值日期";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.Frozen = true;
            this.Time.HeaderText = "充值时间";
            this.Time.Name = "Time";
            // 
            // IsCheck
            // 
            this.IsCheck.DataPropertyName = "IsCheck";
            this.IsCheck.Frozen = true;
            this.IsCheck.HeaderText = "结账状态";
            this.IsCheck.Name = "IsCheck";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.Frozen = true;
            this.UserID.HeaderText = "工作员";
            this.UserID.Name = "UserID";
            // 
            // chargeinfoBindingSource1
            // 
            this.chargeinfoBindingSource1.DataMember = "Charge_info";
            this.chargeinfoBindingSource1.DataSource = this.chargeMoneyDataSet;
            // 
            // chargeMoneyDataSet
            // 
            this.chargeMoneyDataSet.DataSetName = "chargeMoneyDataSet";
            this.chargeMoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chargeinfoBindingSource
            // 
            this.chargeinfoBindingSource.DataMember = "Charge_info";
            this.chargeinfoBindingSource.DataSource = this.chargeDataSet2;
            // 
            // chargeDataSet2
            // 
            this.chargeDataSet2.DataSetName = "chargeDataSet2";
            this.chargeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charge_infoTableAdapter
            // 
            this.charge_infoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardnoToolStripLabel1,
            this.cardnoToolStripTextBox1,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(16, 40);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(446, 32);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // cardnoToolStripLabel1
            // 
            this.cardnoToolStripLabel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardnoToolStripLabel1.Name = "cardnoToolStripLabel1";
            this.cardnoToolStripLabel1.Size = new System.Drawing.Size(129, 29);
            this.cardnoToolStripLabel1.Text = "请输入卡号：";
            // 
            // cardnoToolStripTextBox1
            // 
            this.cardnoToolStripTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardnoToolStripTextBox1.MaxLength = 10;
            this.cardnoToolStripTextBox1.Name = "cardnoToolStripTextBox1";
            this.cardnoToolStripTextBox1.Size = new System.Drawing.Size(150, 32);
            this.cardnoToolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardnoToolStripTextBox1_KeyPress);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fillByToolStripButton.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(53, 29);
            this.fillByToolStripButton.Text = "查询";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // charge_infoTableAdapter1
            // 
            this.charge_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(632, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "导出为Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cardNo1DataGridViewTextBoxColumn
            // 
            this.cardNo1DataGridViewTextBoxColumn.DataPropertyName = "CardNo1";
            this.cardNo1DataGridViewTextBoxColumn.HeaderText = "CardNo1";
            this.cardNo1DataGridViewTextBoxColumn.Name = "cardNo1DataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // addMoneyDataGridViewTextBoxColumn
            // 
            this.addMoneyDataGridViewTextBoxColumn.DataPropertyName = "AddMoney";
            this.addMoneyDataGridViewTextBoxColumn.HeaderText = "AddMoney";
            this.addMoneyDataGridViewTextBoxColumn.Name = "addMoneyDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // isCheckDataGridViewTextBoxColumn
            // 
            this.isCheckDataGridViewTextBoxColumn.DataPropertyName = "IsCheck";
            this.isCheckDataGridViewTextBoxColumn.HeaderText = "IsCheck";
            this.isCheckDataGridViewTextBoxColumn.Name = "isCheckDataGridViewTextBoxColumn";
            // 
            // frmChargeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmChargeRecord";
            this.Text = "学生充值记录查询";
            this.Load += new System.EventHandler(this.frmChargeRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeMoneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private chargeDataSet2 chargeDataSet2;
        private System.Windows.Forms.BindingSource chargeinfoBindingSource;
        private chargeDataSet2TableAdapters.Charge_infoTableAdapter charge_infoTableAdapter;
        private chargeMoneyDataSet chargeMoneyDataSet;
        private System.Windows.Forms.BindingSource chargeinfoBindingSource1;
        private chargeMoneyDataSetTableAdapters.Charge_infoTableAdapter charge_infoTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel cardnoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox cardnoToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCheckDataGridViewTextBoxColumn;
    }
}