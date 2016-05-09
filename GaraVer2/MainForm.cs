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

        #region LinkClicked
        //for navbar link click handler
        
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

        

        private void navBarItem_Receipt_Money_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMoneyReceipt MoneyReceipt = new frmMoneyReceipt { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(MoneyReceipt);
            MoneyReceipt.Show();
        }

        private void navBarItem_Receipt_Fixing_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFixingReceipt FixingReceipt = new frmFixingReceipt { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(FixingReceipt);
            FixingReceipt.Show();
        }

        private void navBarItem_Report_Sale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSaleReport SaleReport = new frmSaleReport { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SaleReport);
            SaleReport.Show();
        }

        private void navBarItem_Report_Inventory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInventoryReport InventoryReport = new frmInventoryReport { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(InventoryReport);
            InventoryReport.Show();
        }

        #endregion

        #region ButtonClicked
        //for button click handler
        private void Button_Search_Click(object sender, EventArgs e)
        {
            frmSearchResult SearchResult = new frmSearchResult { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Clear();
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();

        }

        

        private void Button_Manage_Click(object sender, EventArgs e)
        {
            frmMangement Mangement = new frmMangement { TopLevel = true, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            Mangement.ShowDialog();
        }
        #endregion
    }
}
