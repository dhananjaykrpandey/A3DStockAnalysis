using System;
using System.Diagnostics;
using Telerik.WinControls.UI;

namespace A3DStockAnalysis.Common.Forms
{
    public partial class RdFrmAboutUs : RadForm
    {
        public RdFrmAboutUs()
        {
            InitializeComponent();
            RbLblCompany.Text = "© Arnika Technologies -2020";
       
        }

        private void RbLblCompany_Click(object sender, EventArgs e)
        {
            Process.Start("Http://www.arnikainfotech.com");
        }

        private void RdFrmAboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
