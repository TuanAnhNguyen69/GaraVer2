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

        private void navBarItem_CarReceive_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCarReceive carRecive = new frmCarReceive { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Add(carRecive);
            carRecive.Show();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            frmSearchResult SearchResult= new frmSearchResult { TopLevel = false, Dock = DockStyle.Fill, StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen };
            this.panelControl_WorkSection.Controls.Add(SearchResult);
            SearchResult.Show();
        }

    }
}
