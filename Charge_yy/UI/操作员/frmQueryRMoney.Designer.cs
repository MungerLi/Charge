namespace UI
{
    partial class frmQueryRMoney
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
            System.Windows.Forms.Button button2;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnCardinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnMoney = new UI.ReturnMoney();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.date1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.date1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.date2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.date2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.returnCard_infoTableAdapter = new UI.ReturnMoneyTableAdapters.ReturnCard_infoTableAdapter();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCardinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnMoney)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNoDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.returnMoneyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.isCheckDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.returnCardinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(973, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cardNoDataGridViewTextBoxColumn
            // 
            this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
            this.cardNoDataGridViewTextBoxColumn.HeaderText = "卡号";
            this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // returnMoneyDataGridViewTextBoxColumn
            // 
            this.returnMoneyDataGridViewTextBoxColumn.DataPropertyName = "ReturnMoney";
            this.returnMoneyDataGridViewTextBoxColumn.HeaderText = "退还金额";
            this.returnMoneyDataGridViewTextBoxColumn.Name = "returnMoneyDataGridViewTextBoxColumn";
            this.returnMoneyDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "退卡日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 120;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "退卡时间";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 120;
            // 
            // isCheckDataGridViewTextBoxColumn
            // 
            this.isCheckDataGridViewTextBoxColumn.DataPropertyName = "IsCheck";
            this.isCheckDataGridViewTextBoxColumn.HeaderText = "是否结账";
            this.isCheckDataGridViewTextBoxColumn.Name = "isCheckDataGridViewTextBoxColumn";
            this.isCheckDataGridViewTextBoxColumn.Width = 120;
            // 
            // returnCardinfoBindingSource
            // 
            this.returnCardinfoBindingSource.DataMember = "ReturnCard_info";
            this.returnCardinfoBindingSource.DataSource = this.returnMoney;
            // 
            // returnMoney
            // 
            this.returnMoney.DataSetName = "ReturnMoney";
            this.returnMoney.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date1ToolStripLabel,
            this.date1ToolStripTextBox,
            this.date2ToolStripLabel,
            this.date2ToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1027, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // date1ToolStripLabel
            // 
            this.date1ToolStripLabel.Name = "date1ToolStripLabel";
            this.date1ToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.date1ToolStripLabel.Text = "date1:";
            // 
            // date1ToolStripTextBox
            // 
            this.date1ToolStripTextBox.Name = "date1ToolStripTextBox";
            this.date1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // date2ToolStripLabel
            // 
            this.date2ToolStripLabel.Name = "date2ToolStripLabel";
            this.date2ToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.date2ToolStripLabel.Text = "date2:";
            // 
            // date2ToolStripTextBox
            // 
            this.date2ToolStripTextBox.Name = "date2ToolStripTextBox";
            this.date2ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "终止日期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(479, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnCard_infoTableAdapter
            // 
            this.returnCard_infoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button2.Location = new System.Drawing.Point(749, 112);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 34);
            button2.TabIndex = 10;
            button2.Text = "导出为Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmQueryRMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 650);
            this.Controls.Add(button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmQueryRMoney";
            this.Text = "退卡金额查询";
            this.Load += new System.EventHandler(this.frmQueryRMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnCardinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnMoney)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ReturnMoney returnMoney;
        private System.Windows.Forms.BindingSource returnCardinfoBindingSource;
        private ReturnMoneyTableAdapters.ReturnCard_infoTableAdapter returnCard_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel date1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox date1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel date2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox date2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}