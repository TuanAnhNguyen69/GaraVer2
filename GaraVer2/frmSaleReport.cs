using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraVer2
{
    public partial class frmSaleReport : Abstract
    {
        public frmSaleReport()
        {
            InitializeComponent();
        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.DoanhSo' table. You can move, or remove it, as needed.
            this.doanhSoTableAdapter.Fill(this.dataSet11.DoanhSo);

        }

      
    }
}
