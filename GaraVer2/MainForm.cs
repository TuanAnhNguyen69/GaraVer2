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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool IsFormOpen(Form formType)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                    return true;
            return false;
        }

        private void navBarItem_CarReceive_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            frmCarReceive carRecive = new frmCarReceive { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            if (IsFormOpen(carRecive))
                return;
            else
            {
                this.panelControl_WorkSection.Controls.Clear();
                this.panelControl_WorkSection.Controls.Add(carRecive);
                carRecive.Show();
            }
            
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            frmSearchResult SearchResult= new frmSearchResult { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
            
        }

        private void navBarItem_Receipt_Money_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMoneyReceipt SearchResult = new frmMoneyReceipt { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
        }

        private void navBarItem_Receipt_Fixing_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFixingReceipt SearchResult = new frmFixingReceipt { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
        }

        private void navBarItem_Report_Sale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSaleReport SearchResult = new frmSaleReport { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
        }

        private void navBarItem_Report_Inventory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInventoryReport SearchResult = new frmInventoryReport { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
        }

    }
}
