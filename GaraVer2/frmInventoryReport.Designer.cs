namespace GaraVer2
{
    partial class frmInventoryReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryReport));
            this.bAOCAOTONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new GaraVer2.DataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnLapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.combobox_BaoCaoTon_Thang = new System.Windows.Forms.ComboBox();
            this.textbox_BaoCaoTon_Nam = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.InventorybindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bAOCAOTONTableAdapter = new GaraVer2.DataSet1TableAdapters.BAOCAOTONTableAdapter();
            this.DataSet1 = new GaraVer2.DataSet1();
            this.BAOCAOTONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAOTONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventorybindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOTONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 314);
            this.panelControl2.Size = new System.Drawing.Size(1302, 44);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(1187, 2);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(1298, 40);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Size = new System.Drawing.Size(1302, 314);
            this.groupControl1.Text = "Báo cáo tồn kho";
            // 
            // bAOCAOTONBindingSource1
            // 
            this.bAOCAOTONBindingSource1.DataMember = "BAOCAOTON";
            this.bAOCAOTONBindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.04762F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.reportViewer1);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(404, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(891, 285);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "Chi tiết báo cáo tồn vật tư phụ tùng";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bAOCAOTONBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GaraVer2.BaoCaoTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(885, 263);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnLapBaoCao);
            this.groupPanel1.Controls.Add(this.combobox_BaoCaoTon_Thang);
            this.groupPanel1.Controls.Add(this.textbox_BaoCaoTon_Nam);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(395, 285);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Lập báo cáo tồn vật tư phụ tùng";
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnLapBaoCao.Image")));
            this.btnLapBaoCao.Location = new System.Drawing.Point(82, 236);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(126, 46);
            this.btnLapBaoCao.TabIndex = 36;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            // 
            // combobox_BaoCaoTon_Thang
            // 
            this.combobox_BaoCaoTon_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combobox_BaoCaoTon_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_BaoCaoTon_Thang.FormattingEnabled = true;
            this.combobox_BaoCaoTon_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combobox_BaoCaoTon_Thang.Location = new System.Drawing.Point(136, 102);
            this.combobox_BaoCaoTon_Thang.Name = "combobox_BaoCaoTon_Thang";
            this.combobox_BaoCaoTon_Thang.Size = new System.Drawing.Size(96, 26);
            this.combobox_BaoCaoTon_Thang.TabIndex = 35;
            // 
            // textbox_BaoCaoTon_Nam
            // 
            this.textbox_BaoCaoTon_Nam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textbox_BaoCaoTon_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_BaoCaoTon_Nam.Location = new System.Drawing.Point(136, 158);
            this.textbox_BaoCaoTon_Nam.Name = "textbox_BaoCaoTon_Nam";
            this.textbox_BaoCaoTon_Nam.Size = new System.Drawing.Size(96, 24);
            this.textbox_BaoCaoTon_Nam.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(61, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 18);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Năm:\r\n";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(61, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Tháng:\r\n";
            // 
            // InventorybindingSource1
            // 
            this.InventorybindingSource1.DataMember = "BAOCAOTON";
            this.InventorybindingSource1.DataSource = this.dataSet11;
            // 
            // bAOCAOTONTableAdapter
            // 
            this.bAOCAOTONTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BAOCAOTONBindingSource
            // 
            this.BAOCAOTONBindingSource.DataMember = "BAOCAOTON";
            this.BAOCAOTONBindingSource.DataSource = this.DataSet1;
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 358);
            this.Name = "frmInventoryReport";
            this.Text = "frmInventoryReport";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAOTONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventorybindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BAOCAOTONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.SimpleButton btnLapBaoCao;
        private System.Windows.Forms.ComboBox combobox_BaoCaoTon_Thang;
        private System.Windows.Forms.TextBox textbox_BaoCaoTon_Nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource InventorybindingSource1;
        private DataSet1TableAdapters.BAOCAOTONTableAdapter bAOCAOTONTableAdapter;
        private System.Windows.Forms.BindingSource BAOCAOTONBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource bAOCAOTONBindingSource1;
        
    }
}