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
    public partial class frmInventoryReport : Abstract
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.BAOCAOTON' table. You can move, or remove it, as needed.
            this.bAOCAOTONTableAdapter.Fill(this.dataSet11.BAOCAOTON);

        }

       
    }
}
