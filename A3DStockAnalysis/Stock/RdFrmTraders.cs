using A3DStockAnalysisBussiness.Stock;
using A3DWinUtility;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DStockAnalysis.Stock
{
    public partial class RdFrmTraders : RadForm
    {
        DataTable DtExcelData = new DataTable();
        public RdFrmTraders()
        {
            InitializeComponent();
            RdCmdBarStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            RdGrdTraders.EnableFiltering = true;
            RdGrdTraders.MasterTemplate.EnableFiltering = true;
            RdGrdTraders.ShowFilteringRow = true;
            RdGrdTraders.ShowHeaderCellButtons = true;
            RdTxtExcelFile.Enabled = false;
        }

        private void RdFrmTraders_Load(object sender, EventArgs e)
        {

        }

        private void RdCmdBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RdCmdBtnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (RadOpenFileDialog OpenDlg = new RadOpenFileDialog())
                {

                    
                    DtExcelData = new DataTable();
                    RdGrdTraders.DataSource = null;
                    RdGrdTraders.DataSource = null;
                    RdGrdTraders.Rows.Clear();
                    RdGrdTraders.Rows.Clear();
                    RdTxtExcelFile.Text = string.Empty;
                    RdDdExcelSheet.Items.Clear();
                    RdDdExcelSheet.Text = string.Empty;
                    

                    OpenDlg.DefaultExt = ".xlsx";
                    OpenDlg.Filter = "Excel File(*.xlsx)|*.xlsx";
                    OpenDlg.MultiSelect = false;
                    OpenDlg.InitialDirectory = Path.GetFullPath(Environment.SpecialFolder.Desktop.ToString());
                    if (OpenDlg.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;

                        RdTxtExcelFile.Text = OpenDlg.FileName;
                        GetExcelSheet(RdTxtExcelFile.Text.Trim());
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
                Cursor = Cursors.Default;
            }
        }
        private void GetExcelSheet(string StrExcelFile)
        {
            try
            {
                var lstsheet = ClsTraders._IClsTraders.GetExcelSheet(StrExcelFile);
                RdDdExcelSheet.Items.Clear();
                foreach (var item in lstsheet)
                {
                    RdDdExcelSheet.Items.Add(item);
                }
                RdDdExcelSheet.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
