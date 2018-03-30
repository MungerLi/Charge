namespace UI
{
    partial class frmBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Bill_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billCheckOut = new UI.billCheckOut();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTMPstart = new System.Windows.Forms.DateTimePicker();
            this.dateTMPstop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuery = new System.Windows.Forms.Button();
            this.Bill_infoTableAdapter = new UI.billCheckOutTableAdapters.Bill_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Bill_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // Bill_infoBindingSource
            // 
            this.Bill_infoBindingSource.DataMember = "Bill_info";
            this.Bill_infoBindingSource.DataSource = this.billCheckOut;
            // 
            // billCheckOut
            // 
            this.billCheckOut.DataSetName = "billCheckOut";
            this.billCheckOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Bill_infoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 99);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(758, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTMPstart
            // 
            this.dateTMPstart.CustomFormat = "yyyy-MM-dd";
            this.dateTMPstart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTMPstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTMPstart.Location = new System.Drawing.Point(65, 39);
            this.dateTMPstart.Name = "dateTMPstart";
            this.dateTMPstart.Size = new System.Drawing.Size(144, 29);
            this.dateTMPstart.TabIndex = 1;
            this.dateTMPstart.Value = new System.DateTime(2017, 2, 10, 0, 0, 0, 0);
            // 
            // dateTMPstop
            // 
            this.dateTMPstop.CustomFormat = "yyyy-MM-dd";
            this.dateTMPstop.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTMPstop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTMPstop.Location = new System.Drawing.Point(315, 39);
            this.dateTMPstop.Name = "dateTMPstop";
            this.dateTMPstop.Size = new System.Drawing.Size(144, 29);
            this.dateTMPstop.TabIndex = 2;
            this.dateTMPstop.Value = new System.DateTime(2017, 2, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(248, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "至";
            // 
            // btQuery
            // 
            this.btQuery.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery.Location = new System.Drawing.Point(631, 37);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(124, 28);
            this.btQuery.TabIndex = 4;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // Bill_infoTableAdapter
            // 
            this.Bill_infoTableAdapter.ClearBeforeFill = true;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 529);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTMPstop);
            this.Controls.Add(this.dateTMPstart);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBill";
            this.Text = "账单查询";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bill_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Bill_infoBindingSource;
        private billCheckOut billCheckOut;
        private billCheckOutTableAdapters.Bill_infoTableAdapter Bill_infoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTMPstart;
        private System.Windows.Forms.DateTimePicker dateTMPstop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuery;
    }
}