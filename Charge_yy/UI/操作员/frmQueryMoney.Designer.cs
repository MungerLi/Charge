namespace UI
{
    partial class frmQueryMoney
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
            System.Windows.Forms.Button btCharge;
            System.Windows.Forms.Button button1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CardNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chargeMoneyDateSet = new UI.chargeMoneyDateSet();
            this.chargeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charge_info = new UI.Charge_info();
            this.charge_infoTableAdapter = new UI.Charge_infoTableAdapters.Charge_infoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtPicker2 = new System.Windows.Forms.DateTimePicker();
            this.queryToolStrip = new System.Windows.Forms.ToolStrip();
            this.startTimeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.startTimeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.stopTimeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stopTimeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.queryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.charge_infoTableAdapter1 = new UI.chargeMoneyDateSetTableAdapters.Charge_infoTableAdapter();
            this.cardNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            btCharge = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeMoneyDateSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge_info)).BeginInit();
            this.queryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCharge
            // 
            btCharge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btCharge.Location = new System.Drawing.Point(774, 56);
            btCharge.Name = "btCharge";
            btCharge.Size = new System.Drawing.Size(150, 34);
            btCharge.TabIndex = 6;
            btCharge.Text = "查询充值";
            btCharge.UseVisualStyleBackColor = true;
            btCharge.Click += new System.EventHandler(this.btCharge_Click);
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.Location = new System.Drawing.Point(774, 112);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 34);
            button1.TabIndex = 9;
            button1.Text = "导出为Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardNo1,
            this.StudentNo,
            this.AddMoney,
            this.Date,
            this.Time,
            this.IsCheck,
            this.cardNo1DataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.addMoneyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.isCheckDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chargeinfoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(891, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CardNo1
            // 
            this.CardNo1.DataPropertyName = "CardNo1";
            this.CardNo1.Frozen = true;
            this.CardNo1.HeaderText = "卡号";
            this.CardNo1.Name = "CardNo1";
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.Frozen = true;
            this.StudentNo.HeaderText = "学号";
            this.StudentNo.Name = "StudentNo";
            // 
            // AddMoney
            // 
            this.AddMoney.DataPropertyName = "AddMoney";
            this.AddMoney.Frozen = true;
            this.AddMoney.HeaderText = "充值金额";
            this.AddMoney.Name = "AddMoney";
            this.AddMoney.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.Frozen = true;
            this.Date.HeaderText = "充值日期";
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.Frozen = true;
            this.Time.HeaderText = "充值时间";
            this.Time.Name = "Time";
            this.Time.Width = 120;
            // 
            // IsCheck
            // 
            this.IsCheck.DataPropertyName = "IsCheck";
            this.IsCheck.Frozen = true;
            this.IsCheck.HeaderText = "结账状态";
            this.IsCheck.Name = "IsCheck";
            this.IsCheck.Width = 120;
            // 
            // chargeinfoBindingSource1
            // 
            this.chargeinfoBindingSource1.DataMember = "Charge_info";
            this.chargeinfoBindingSource1.DataSource = this.chargeMoneyDateSet;
            // 
            // chargeMoneyDateSet
            // 
            this.chargeMoneyDateSet.DataSetName = "chargeMoneyDateSet";
            this.chargeMoneyDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chargeinfoBindingSource
            // 
            this.chargeinfoBindingSource.DataMember = "Charge_info";
            this.chargeinfoBindingSource.DataSource = this.charge_info;
            // 
            // charge_info
            // 
            this.charge_info.DataSetName = "Charge_info";
            this.charge_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charge_infoTableAdapter
            // 
            this.charge_infoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "终止日期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtPicker1
            // 
            this.dtPicker1.CustomFormat = "yyyy-MM-dd";
            this.dtPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker1.Location = new System.Drawing.Point(185, 61);
            this.dtPicker1.Name = "dtPicker1";
            this.dtPicker1.Size = new System.Drawing.Size(166, 29);
            this.dtPicker1.TabIndex = 7;
            this.dtPicker1.Value = new System.DateTime(2017, 1, 5, 0, 0, 0, 0);
            this.dtPicker1.ValueChanged += new System.EventHandler(this.dtPicker1_ValueChanged);
            // 
            // dtPicker2
            // 
            this.dtPicker2.CustomFormat = "yyyy-MM-dd";
            this.dtPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker2.Location = new System.Drawing.Point(503, 60);
            this.dtPicker2.Name = "dtPicker2";
            this.dtPicker2.Size = new System.Drawing.Size(184, 29);
            this.dtPicker2.TabIndex = 8;
            this.dtPicker2.Value = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            this.dtPicker2.ValueChanged += new System.EventHandler(this.dtPicker2_ValueChanged);
            // 
            // queryToolStrip
            // 
            this.queryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTimeToolStripLabel,
            this.startTimeToolStripTextBox,
            this.stopTimeToolStripLabel,
            this.stopTimeToolStripTextBox,
            this.queryToolStripButton});
            this.queryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.queryToolStrip.Name = "queryToolStrip";
            this.queryToolStrip.Size = new System.Drawing.Size(1004, 25);
            this.queryToolStrip.TabIndex = 10;
            this.queryToolStrip.Text = "queryToolStrip";
            this.queryToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.queryToolStrip_ItemClicked);
            // 
            // startTimeToolStripLabel
            // 
            this.startTimeToolStripLabel.Name = "startTimeToolStripLabel";
            this.startTimeToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.startTimeToolStripLabel.Text = "startTime:";
            // 
            // startTimeToolStripTextBox
            // 
            this.startTimeToolStripTextBox.Name = "startTimeToolStripTextBox";
            this.startTimeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // stopTimeToolStripLabel
            // 
            this.stopTimeToolStripLabel.Name = "stopTimeToolStripLabel";
            this.stopTimeToolStripLabel.Size = new System.Drawing.Size(66, 22);
            this.stopTimeToolStripLabel.Text = "StopTime:";
            // 
            // stopTimeToolStripTextBox
            // 
            this.stopTimeToolStripTextBox.Name = "stopTimeToolStripTextBox";
            this.stopTimeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // queryToolStripButton
            // 
            this.queryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.queryToolStripButton.Name = "queryToolStripButton";
            this.queryToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.queryToolStripButton.Text = "query";
            this.queryToolStripButton.Click += new System.EventHandler(this.queryToolStripButton_Click);
            // 
            // charge_infoTableAdapter1
            // 
            this.charge_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // cardNo1DataGridViewTextBoxColumn
            // 
            this.cardNo1DataGridViewTextBoxColumn.DataPropertyName = "CardNo1";
            this.cardNo1DataGridViewTextBoxColumn.HeaderText = "CardNo1";
            this.cardNo1DataGridViewTextBoxColumn.Name = "cardNo1DataGridViewTextBoxColumn";
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "StudentNo";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
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
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "queryToolStrip1";
            // 
            // frmQueryMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.queryToolStrip);
            this.Controls.Add(button1);
            this.Controls.Add(this.dtPicker2);
            this.Controls.Add(this.dtPicker1);
            this.Controls.Add(btCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmQueryMoney";
            this.Text = "收取金额查询";
            this.Load += new System.EventHandler(this.frmQueryMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeMoneyDateSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge_info)).EndInit();
            this.queryToolStrip.ResumeLayout(false);
            this.queryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Charge_info charge_info;
        private System.Windows.Forms.BindingSource chargeinfoBindingSource;
        private Charge_infoTableAdapters.Charge_infoTableAdapter charge_infoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPicker1;
        private System.Windows.Forms.DateTimePicker dtPicker2;
        private chargeMoneyDateSet chargeMoneyDateSet;
        private System.Windows.Forms.BindingSource chargeinfoBindingSource1;
        private chargeMoneyDateSetTableAdapters.Charge_infoTableAdapter charge_infoTableAdapter1;
        private System.Windows.Forms.ToolStrip queryToolStrip;
        private System.Windows.Forms.ToolStripLabel startTimeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox startTimeToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel stopTimeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox stopTimeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton queryToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}