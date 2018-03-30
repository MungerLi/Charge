using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel; //导出excel
using Microsoft.Office.Core;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;

using System.Text.RegularExpressions; //正则表达式

namespace UI
{
    public partial class EmptyUI : Form
    {
        public EmptyUI()
        {
            InitializeComponent();
        }

        private void EmptyUIcs_Load(object sender, EventArgs e)
        {

        }

        #region 判空的公共方法 判空的公共方法
        public static bool ISsomeEmpty(Control[] arraycontrol)
        {
            
            bool isEmpty;
            isEmpty = false;
            foreach (Control con in arraycontrol)
            {
                
                if (con.Text == "")
                {
                    //MessageBox.Show("内容填写不完整，请核对后再查询！");
                    //con.Focus();
                    //Application .Exit() ;
                    isEmpty = true; 
                }
               
               
            }
            return isEmpty;
        }
        #endregion 

        #region 导出execel
       
        public class Excel
        {
          
            public void RExcel(string name, DataGridView dgv)
            {
                //总可见列数，总可见行数
                int colCount = dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible);
                int rowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Visible);

                //如果没有数据
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("表中没有数据", "提示");
                }
                else
                {
                    //创建文件的路径
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "excel files(*.xlsx)|*.xlsx";
                    save.Title = "请选择要导出数据的位置";
                    save.FileName = name + DateTime.Now.ToLongDateString();

                   
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = save.FileName;

                        //创建excel对象                       
                        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                        if (excel == null)
                        {
                            MessageBox.Show ("Excel无法启动","提示");
                            return;
                        }

                        //创建工作簿
                        Microsoft.Office.Interop.Excel.Workbook excelBook = excel.Workbooks.Add(true);
                        Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets[1];

                        //生成字段名
                        int k = 0;
                        for (int i = 0; i < dgv.ColumnCount;i++)
                        {
                            if (dgv.Columns[i].Visible)//不导出隐藏列
                            {
                                excel.Cells[1, k + 1] = dgv.Columns[i].HeaderText;
                                k++;
                            }
                        }
                        
                        //填充数据
                        for (int i = 0; i < dgv.RowCount; i++)
                        {
                            k = 0;
                            for (int j = 0; j < dgv.ColumnCount ; j++)
                            {
                                if (dgv.Columns[j].Visible) //不导出隐藏的列
                                {
                                    if (dgv[j, i].ValueType == typeof(string))
                                    {
                                        excel.Cells[i + 2, k + 1] = "" + dgv[j, i].Value.ToString();
                                    }
                                    else
                                    {
                                        excel.Cells[i + 2, k + 1] = dgv[j, i].Value.ToString();
                                    }
                                }
                                k++;
                            }
                        }
                        try
                        {
                            excelBook.Saved = true;
                            excelBook.SaveCopyAs(fileName);
                            MessageBox.Show("导出成功！");
                        }

                        catch
                        {
                            MessageBox.Show("导出文件失败，文件可能正在使用中~~~", "提示");
                        }

                    }
                }

            }
        }
        #endregion

#region 正则表达式，判断输入为汉字
        public static  bool IsChinese(string input)
        {
            Regex regex = new Regex("^[\u4e00-\u9fa5]+$");
            return regex.IsMatch(input);
        }
#endregion

        #region 正则表达式，判断是否为英文
        public static bool isEnlish(string input)
        {
            Regex regex = new Regex("^[A-Za-z]+$");
            return regex.IsMatch(input);
        }

        #endregion
    }
}
