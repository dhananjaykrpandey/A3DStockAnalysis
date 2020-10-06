namespace A3DStockAnalysis.Stock
{
    partial class RdFrmTraders
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            this.RdGrdTraders = new Telerik.WinControls.UI.RadGridView();
            this.RdCommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.RdCmdBarStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.RdTxtExcelFile = new Telerik.WinControls.UI.CommandBarTextBox();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
            this.RdDdExcelSheet = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.RdCmdBtnOpenFile = new Telerik.WinControls.UI.CommandBarButton();
            this.RdCmdBtnProcessFile = new Telerik.WinControls.UI.CommandBarButton();
            this.RdCmdBtnExport = new Telerik.WinControls.UI.CommandBarButton();
            this.RdCmdBtnSave = new Telerik.WinControls.UI.CommandBarButton();
            this.RdCmdBtnClose = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdTraders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdTraders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdCommandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RdGrdTraders
            // 
            this.RdGrdTraders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdGrdTraders.Location = new System.Drawing.Point(0, 55);
            // 
            // 
            // 
            this.RdGrdTraders.MasterTemplate.ViewDefinition = tableViewDefinition7;
            this.RdGrdTraders.Name = "RdGrdTraders";
            this.RdGrdTraders.Size = new System.Drawing.Size(800, 395);
            this.RdGrdTraders.TabIndex = 1;
            // 
            // RdCommandBar
            // 
            this.RdCommandBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.RdCommandBar.Location = new System.Drawing.Point(0, 0);
            this.RdCommandBar.Name = "RdCommandBar";
            this.RdCommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.RdCommandBar.Size = new System.Drawing.Size(800, 55);
            this.RdCommandBar.TabIndex = 2;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.RdCmdBarStrip});
            // 
            // RdCmdBarStrip
            // 
            this.RdCmdBarStrip.DisplayName = "commandBarStripElement1";
            this.RdCmdBarStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.RdTxtExcelFile,
            this.RdCmdBtnOpenFile,
            this.commandBarSeparator1,
            this.commandBarLabel2,
            this.RdDdExcelSheet,
            this.RdCmdBtnProcessFile,
            this.commandBarSeparator2,
            this.RdCmdBtnExport,
            this.RdCmdBtnSave,
            this.RdCmdBtnClose});
            this.RdCmdBarStrip.Name = "RdCmdBarStrip";
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.DisplayName = "commandBarLabel1";
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "Select Excel File";
            // 
            // RdTxtExcelFile
            // 
            this.RdTxtExcelFile.AutoSize = false;
            this.RdTxtExcelFile.Bounds = new System.Drawing.Rectangle(0, 0, 200, 22);
            this.RdTxtExcelFile.DisplayName = "commandBarTextBox1";
            this.RdTxtExcelFile.Name = "RdTxtExcelFile";
            this.RdTxtExcelFile.NullText = "Select Excel File";
            this.RdTxtExcelFile.Text = "";
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.Text = "";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarLabel2
            // 
            this.commandBarLabel2.DisplayName = "commandBarLabel2";
            this.commandBarLabel2.Name = "commandBarLabel2";
            this.commandBarLabel2.Text = "Select Excel Sheet";
            // 
            // RdDdExcelSheet
            // 
            this.RdDdExcelSheet.AutoSize = false;
            this.RdDdExcelSheet.Bounds = new System.Drawing.Rectangle(0, 0, 200, 22);
            this.RdDdExcelSheet.DisplayName = "commandBarDropDownList1";
            this.RdDdExcelSheet.DropDownAnimationEnabled = true;
            this.RdDdExcelSheet.MaxDropDownItems = 0;
            this.RdDdExcelSheet.Name = "RdDdExcelSheet";
            this.RdDdExcelSheet.Text = "";
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.Text = "";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // RdCmdBtnOpenFile
            // 
            this.RdCmdBtnOpenFile.DisplayName = "commandBarButton1";
            this.RdCmdBtnOpenFile.Image = global::A3DStockAnalysis.Properties.Resources.OpenFolder16X16;
            this.RdCmdBtnOpenFile.Name = "RdCmdBtnOpenFile";
            this.RdCmdBtnOpenFile.Text = "Select Excel File";
            this.RdCmdBtnOpenFile.ToolTipText = "Select Excel File";
            this.RdCmdBtnOpenFile.Click += new System.EventHandler(this.RdCmdBtnOpenFile_Click);
            // 
            // RdCmdBtnProcessFile
            // 
            this.RdCmdBtnProcessFile.DisplayName = "commandBarButton2";
            this.RdCmdBtnProcessFile.Image = global::A3DStockAnalysis.Properties.Resources.DataUpload16X16;
            this.RdCmdBtnProcessFile.Name = "RdCmdBtnProcessFile";
            this.RdCmdBtnProcessFile.Text = "Start Process Excel File";
            this.RdCmdBtnProcessFile.ToolTipText = "Start Process Excel File";
            // 
            // RdCmdBtnExport
            // 
            this.RdCmdBtnExport.DisplayName = "commandBarButton3";
            this.RdCmdBtnExport.Image = global::A3DStockAnalysis.Properties.Resources.Excel16X16;
            this.RdCmdBtnExport.Name = "RdCmdBtnExport";
            this.RdCmdBtnExport.Text = "Export Processed File";
            this.RdCmdBtnExport.ToolTipText = "Export Processed File";
            // 
            // RdCmdBtnSave
            // 
            this.RdCmdBtnSave.DisplayName = "commandBarButton4";
            this.RdCmdBtnSave.Image = global::A3DStockAnalysis.Properties.Resources.save_all;
            this.RdCmdBtnSave.Name = "RdCmdBtnSave";
            this.RdCmdBtnSave.Text = "Save Process Data";
            this.RdCmdBtnSave.ToolTipText = "Save Process Data";
            // 
            // RdCmdBtnClose
            // 
            this.RdCmdBtnClose.DisplayName = "commandBarButton5";
            this.RdCmdBtnClose.Image = global::A3DStockAnalysis.Properties.Resources.Close16X16;
            this.RdCmdBtnClose.Name = "RdCmdBtnClose";
            this.RdCmdBtnClose.Text = "Close";
            this.RdCmdBtnClose.ToolTipText = "Close";
            this.RdCmdBtnClose.Click += new System.EventHandler(this.RdCmdBtnClose_Click);
            // 
            // RdFrmTraders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RdGrdTraders);
            this.Controls.Add(this.RdCommandBar);
            this.Name = "RdFrmTraders";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Profitable Traders";
            this.Load += new System.EventHandler(this.RdFrmTraders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdTraders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdTraders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdCommandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView RdGrdTraders;
        private Telerik.WinControls.UI.RadCommandBar RdCommandBar;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement RdCmdBarStrip;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarTextBox RdTxtExcelFile;
        private Telerik.WinControls.UI.CommandBarButton RdCmdBtnOpenFile;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
        private Telerik.WinControls.UI.CommandBarDropDownList RdDdExcelSheet;
        private Telerik.WinControls.UI.CommandBarButton RdCmdBtnProcessFile;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarButton RdCmdBtnExport;
        private Telerik.WinControls.UI.CommandBarButton RdCmdBtnSave;
        private Telerik.WinControls.UI.CommandBarButton RdCmdBtnClose;
    }
}