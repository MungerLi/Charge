namespace UI
{
    partial class frmOnlineRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lineInfoDataSet = new UI.lineInfoDataSet();
            this.lineinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chargeDataSet = new UI.chargeDataSet();
            this.line_infoTableAdapter = new UI.chargeDataSetTableAdapters.line_infoTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cardnoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cardnoToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.line_infoTableAdapter1 = new UI.lineInfoDataSetTableAdapters.line_infoTableAdapter();
            this.cardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeDataSet)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(708, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "导出为Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.studentNo,
            this.studentName,
            this.LoginDate,
            this.LoginTime,
            this.OffDate,
            this.OffTime,
            this.ConsumeTime,
            this.Money,
            this.Computer,
            this.cardNoDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.loginDateDataGridViewTextBoxColumn,
            this.loginTimeDataGridViewTextBoxColumn,
            this.offDateDataGridViewTextBoxColumn,
            this.offTimeDataGridViewTextBoxColumn,
            this.consumeTimeDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.computerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lineinfoBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(33, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(990, 434);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CardNo";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "卡号";
            this.Column1.Name = "Column1";
            // 
            // studentNo
            // 
            this.studentNo.DataPropertyName = "studentNo";
            this.studentNo.Frozen = true;
            this.studentNo.HeaderText = "学号";
            this.studentNo.Name = "studentNo";
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.Frozen = true;
            this.studentName.HeaderText = "姓名";
            this.studentName.Name = "studentName";
            this.studentName.Width = 80;
            // 
            // LoginDate
            // 
            this.LoginDate.DataPropertyName = "LoginDate";
            this.LoginDate.Frozen = true;
            this.LoginDate.HeaderText = "上机日期";
            this.LoginDate.Name = "LoginDate";
            this.LoginDate.Width = 80;
            // 
            // LoginTime
            // 
            this.LoginTime.DataPropertyName = "LoginTime";
            this.LoginTime.Frozen = true;
            this.LoginTime.HeaderText = "上机时间";
            this.LoginTime.Name = "LoginTime";
            // 
            // OffDate
            // 
            this.OffDate.DataPropertyName = "OffDate";
            this.OffDate.Frozen = true;
            this.OffDate.HeaderText = "下机日期";
            this.OffDate.Name = "OffDate";
            this.OffDate.Width = 80;
            // 
            // OffTime
            // 
            this.OffTime.DataPropertyName = "OffTime";
            this.OffTime.Frozen = true;
            this.OffTime.HeaderText = "下机时间";
            this.OffTime.Name = "OffTime";
            // 
            // ConsumeTime
            // 
            this.ConsumeTime.DataPropertyName = "ConsumeTime";
            this.ConsumeTime.Frozen = true;
            this.ConsumeTime.HeaderText = "消费时间";
            this.ConsumeTime.Name = "ConsumeTime";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.Frozen = true;
            this.Money.HeaderText = "余额";
            this.Money.Name = "Money";
            this.Money.Width = 80;
            // 
            // Computer
            // 
            this.Computer.DataPropertyName = "Computer";
            this.Computer.Frozen = true;
            this.Computer.HeaderText = "机号";
            this.Computer.Name = "Computer";
            this.Computer.Width = 80;
            // 
            // lineinfoBindingSource1
            // 
            this.lineinfoBindingSource1.DataMember = "line_info";
            this.lineinfoBindingSource1.DataSource = this.lineInfoDataSet;
            // 
            // lineInfoDataSet
            // 
            this.lineInfoDataSet.DataSetName = "lineInfoDataSet";
            this.lineInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lineinfoBindingSource
            // 
            this.lineinfoBindingSource.DataMember = "line_info";
            this.lineinfoBindingSource.DataSource = this.chargeDataSet;
            // 
            // chargeDataSet
            // 
            this.chargeDataSet.DataSetName = "chargeDataSet";
            this.chargeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // line_infoTableAdapter
            // 
            this.line_infoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardnoToolStripLabel1,
            this.cardnoToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(33, 45);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(446, 32);
            this.fillByToolStrip1.TabIndex = 6;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
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
            this.cardnoToolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardnoToolStripTextBox1_KeyDown);
            this.cardnoToolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardnoToolStripTextBox1_KeyPress);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fillByToolStripButton1.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(53, 29);
            this.fillByToolStripButton1.Text = "查询";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // line_infoTableAdapter1
            // 
            this.line_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // cardNoDataGridViewTextBoxColumn
            // 
            this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.HeaderText = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "studentNo";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "studentNo";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "studentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // loginDateDataGridViewTextBoxColumn
            // 
            this.loginDateDataGridViewTextBoxColumn.DataPropertyName = "LoginDate";
            this.loginDateDataGridViewTextBoxColumn.HeaderText = "LoginDate";
            this.loginDateDataGridViewTextBoxColumn.Name = "loginDateDataGridViewTextBoxColumn";
            // 
            // loginTimeDataGridViewTextBoxColumn
            // 
            this.loginTimeDataGridViewTextBoxColumn.DataPropertyName = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.HeaderText = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.Name = "loginTimeDataGridViewTextBoxColumn";
            // 
            // offDateDataGridViewTextBoxColumn
            // 
            this.offDateDataGridViewTextBoxColumn.DataPropertyName = "OffDate";
            this.offDateDataGridViewTextBoxColumn.HeaderText = "OffDate";
            this.offDateDataGridViewTextBoxColumn.Name = "offDateDataGridViewTextBoxColumn";
            // 
            // offTimeDataGridViewTextBoxColumn
            // 
            this.offTimeDataGridViewTextBoxColumn.DataPropertyName = "OffTime";
            this.offTimeDataGridViewTextBoxColumn.HeaderText = "OffTime";
            this.offTimeDataGridViewTextBoxColumn.Name = "offTimeDataGridViewTextBoxColumn";
            // 
            // consumeTimeDataGridViewTextBoxColumn
            // 
            this.consumeTimeDataGridViewTextBoxColumn.DataPropertyName = "ConsumeTime";
            this.consumeTimeDataGridViewTextBoxColumn.HeaderText = "ConsumeTime";
            this.consumeTimeDataGridViewTextBoxColumn.Name = "consumeTimeDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // computerDataGridViewTextBoxColumn
            // 
            this.computerDataGridViewTextBoxColumn.DataPropertyName = "Computer";
            this.computerDataGridViewTextBoxColumn.HeaderText = "Computer";
            this.computerDataGridViewTextBoxColumn.Name = "computerDataGridViewTextBoxColumn";
            // 
            // frmOnlineRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 612);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmOnlineRecord";
            this.Text = "查看学生上机记录";
            this.Load += new System.EventHandler(this.frmOnlineRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chargeDataSet)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private chargeDataSet chargeDataSet;
        private System.Windows.Forms.BindingSource lineinfoBindingSource;
        private chargeDataSetTableAdapters.line_infoTableAdapter line_infoTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private lineInfoDataSet lineInfoDataSet;
        private System.Windows.Forms.BindingSource lineinfoBindingSource1;
        private lineInfoDataSetTableAdapters.line_infoTableAdapter line_infoTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel cardnoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox cardnoToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerDataGridViewTextBoxColumn;
    }
}