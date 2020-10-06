using A3DWinUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DStockAnalysisBussiness.Stock
{
    public class ClsTraders
    {
        private static ClsTraders _iClsTraders = null;
        public ClsTraders()

        {

        }
        public static ClsTraders _IClsTraders
        {
            get
            {
                if (_iClsTraders == null)
                {
                    _iClsTraders = new ClsTraders();
                }
                return _iClsTraders;
            }

        }

        public List<string> GetExcelSheet(string StrExcelFileName)
        {
            try
            {
                return ClsExcelWork.InstanceClsExcelWork.GetExcelSheet(StrExcelFileName);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
