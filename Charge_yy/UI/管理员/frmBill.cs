using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace UI
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“billCheckOut.Bill_info”中。您可以根据需要移动或删除它。
            //this.Bill_infoTableAdapter.Fill(this.billCheckOut.Bill_info);

            this.reportViewer1.RefreshReport();
            
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            ReportDataSource billDateSource = new ReportDataSource();
            
            //设置数据源的名称
            billDateSource.Name = "DataSet1";

            //设置报表数据源实例
            billDateSource.Value = billCheckOut.Bill_info;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report1.rdlc";

            //清空存在的报表
            this.reportViewer1.LocalReport.DataSources.Clear();
            //添加数据源
            this.reportViewer1.LocalReport.DataSources.Add(billDateSource);

            //传递参数
            this.Bill_infoTableAdapter.Fill(this.billCheckOut.Bill_info, dateTMPstart.Text ,dateTMPstop.Text );

            //刷新报表
            this.reportViewer1.RefreshReport();

        }
    }
}
