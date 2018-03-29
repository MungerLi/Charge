namespace UI
{
    partial class frmOnlineStatus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上机管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定学生下机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineDataSet = new UI.onlineDataSet();
            this.online_infoTableAdapter = new UI.onlineDataSetTableAdapters.online_infoTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.显示全部ToolStripMenuItem,
            this.上机管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 显示全部ToolStripMenuItem
            // 
            this.显示全部ToolStripMenuItem.Name = "显示全部ToolStripMenuItem";
            this.显示全部ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.显示全部ToolStripMenuItem.Text = "显示全部";
            this.显示全部ToolStripMenuItem.Click += new System.EventHandler(this.显示全部ToolStripMenuItem_Click);
            // 
            // 上机管理ToolStripMenuItem
            // 
            this.上机管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem,
            this.指定学生下机ToolStripMenuItem});
            this.上机管理ToolStripMenuItem.Name = "上机管理ToolStripMenuItem";
            this.上机管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.上机管理ToolStripMenuItem.Text = "上机管理";
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.全部ToolStripMenuItem.Text = "全部学生下机";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // 指定学生下机ToolStripMenuItem
            // 
            this.指定学生下机ToolStripMenuItem.Name = "指定学生下机ToolStripMenuItem";
            this.指定学生下机ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.指定学生下机ToolStripMenuItem.Text = "指定学生下机";
            this.指定学生下机ToolStripMenuItem.Click += new System.EventHandler(this.指定学生下机ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardnoDataGridViewTextBoxColumn,
            this.studentnoDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.cardTypeDataGridViewTextBoxColumn,
            this.onDateDataGridViewTextBoxColumn,
            this.onTimeDataGridViewTextBoxColumn,
            this.computerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.onlineinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(661, 463);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cardnoDataGridViewTextBoxColumn
            // 
            this.cardnoDataGridViewTextBoxColumn.DataPropertyName = "cardno";
            this.cardnoDataGridViewTextBoxColumn.HeaderText = "卡号";
            this.cardnoDataGridViewTextBoxColumn.Name = "cardnoDataGridViewTextBoxColumn";
            // 
            // studentnoDataGridViewTextBoxColumn
            // 
            this.studentnoDataGridViewTextBoxColumn.DataPropertyName = "studentno";
            this.studentnoDataGridViewTextBoxColumn.HeaderText = "学号";
            this.studentnoDataGridViewTextBoxColumn.Name = "studentnoDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "studentname";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.Width = 80;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 80;
            // 
            // cardTypeDataGridViewTextBoxColumn
            // 
            this.cardTypeDataGridViewTextBoxColumn.DataPropertyName = "cardType";
            this.cardTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.cardTypeDataGridViewTextBoxColumn.Name = "cardTypeDataGridViewTextBoxColumn";
            // 
            // onDateDataGridViewTextBoxColumn
            // 
            this.onDateDataGridViewTextBoxColumn.DataPropertyName = "onDate";
            this.onDateDataGridViewTextBoxColumn.HeaderText = "上机日期";
            this.onDateDataGridViewTextBoxColumn.Name = "onDateDataGridViewTextBoxColumn";
            this.onDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // onTimeDataGridViewTextBoxColumn
            // 
            this.onTimeDataGridViewTextBoxColumn.DataPropertyName = "onTime";
            this.onTimeDataGridViewTextBoxColumn.HeaderText = "上机时间";
            this.onTimeDataGridViewTextBoxColumn.Name = "onTimeDataGridViewTextBoxColumn";
            // 
            // computerDataGridViewTextBoxColumn
            // 
            this.computerDataGridViewTextBoxColumn.DataPropertyName = "computer";
            this.computerDataGridViewTextBoxColumn.HeaderText = "机号";
            this.computerDataGridViewTextBoxColumn.Name = "computerDataGridViewTextBoxColumn";
            this.computerDataGridViewTextBoxColumn.Width = 80;
            // 
            // onlineinfoBindingSource
            // 
            this.onlineinfoBindingSource.DataMember = "online_info";
            this.onlineinfoBindingSource.DataSource = this.onlineDataSet;
            // 
            // onlineDataSet
            // 
            this.onlineDataSet.DataSetName = "onlineDataSet";
            this.onlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // online_infoTableAdapter
            // 
            this.online_infoTableAdapter.ClearBeforeFill = true;
            // 
            // frmOnlineStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmOnlineStatus";
            this.Text = "学生上机状态查看";
            this.Load += new System.EventHandler(this.frmOnlineStatus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上机管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定学生下机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private onlineDataSet onlineDataSet;
        private System.Windows.Forms.BindingSource onlineinfoBindingSource;
        private onlineDataSetTableAdapters.online_infoTableAdapter online_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerDataGridViewTextBoxColumn;
    }
}