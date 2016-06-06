namespace GaraVer2
{
    partial class frmSaleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReport));
            this.DoanhSoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GaraVer2.DataSet1();
            this.doanhSoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new GaraVer2.DataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reportViewer_BaoCaoDoanhSo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.button_BaoCaoDoanhSo_LapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.combobox_BaoCaoDoanhSo_Thang = new System.Windows.Forms.ComboBox();
            this.textbox_BaoCaoDoanhSo_Nam = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            this.SalebindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doanhSoTableAdapter = new GaraVer2.DataSet1TableAdapters.DoanhSoTableAdapter();
            this.doanhSoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhSoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhSoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalebindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhSoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 429);
            this.panelControl2.Size = new System.Drawing.Size(1127, 44);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(1012, 2);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(1123, 40);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Size = new System.Drawing.Size(1127, 429);
            this.groupControl1.Text = "Báo cáo doanh số";
            // 
            // DoanhSoBindingSource
            // 
            this.DoanhSoBindingSource.DataMember = "DoanhSo";
            this.DoanhSoBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doanhSoBindingSource1
            // 
            this.doanhSoBindingSource1.DataMember = "DoanhSo";
            this.doanhSoBindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.31868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.68132F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.reportViewer_BaoCaoDoanhSo);
            this.groupPanel2.Location = new System.Drawing.Point(354, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(766, 400);
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
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Lập báo cáo doanh số";
            // 
            // reportViewer_BaoCaoDoanhSo
            // 
            this.reportViewer_BaoCaoDoanhSo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DoanhSoBindingSource;
            this.reportViewer_BaoCaoDoanhSo.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_BaoCaoDoanhSo.LocalReport.ReportEmbeddedResource = "GaraVer2.BaoCaoDoanhSo.rdlc";
            this.reportViewer_BaoCaoDoanhSo.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_BaoCaoDoanhSo.Name = "reportViewer_BaoCaoDoanhSo";
            this.reportViewer_BaoCaoDoanhSo.Size = new System.Drawing.Size(760, 378);
            this.reportViewer_BaoCaoDoanhSo.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.button_BaoCaoDoanhSo_LapBaoCao);
            this.groupPanel1.Controls.Add(this.combobox_BaoCaoDoanhSo_Thang);
            this.groupPanel1.Controls.Add(this.textbox_BaoCaoDoanhSo_Nam);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(345, 400);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Lập báo cáo doanh số";
            // 
            // button_BaoCaoDoanhSo_LapBaoCao
            // 
            this.button_BaoCaoDoanhSo_LapBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_BaoCaoDoanhSo_LapBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("button_BaoCaoDoanhSo_LapBaoCao.Image")));
            this.button_BaoCaoDoanhSo_LapBaoCao.Location = new System.Drawing.Point(59, 201);
            this.button_BaoCaoDoanhSo_LapBaoCao.Name = "button_BaoCaoDoanhSo_LapBaoCao";
            this.button_BaoCaoDoanhSo_LapBaoCao.Size = new System.Drawing.Size(126, 46);
            this.button_BaoCaoDoanhSo_LapBaoCao.TabIndex = 36;
            this.button_BaoCaoDoanhSo_LapBaoCao.Text = "Lập báo cáo";
            this.button_BaoCaoDoanhSo_LapBaoCao.Click += new System.EventHandler(this.btn_BaoCaoDoanhSo_LapBaoCao_Click);
            // 
            // combobox_BaoCaoDoanhSo_Thang
            // 
            this.combobox_BaoCaoDoanhSo_Thang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combobox_BaoCaoDoanhSo_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_BaoCaoDoanhSo_Thang.FormattingEnabled = true;
            this.combobox_BaoCaoDoanhSo_Thang.Items.AddRange(new object[] {
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
            this.combobox_BaoCaoDoanhSo_Thang.Location = new System.Drawing.Point(103, 102);
            this.combobox_BaoCaoDoanhSo_Thang.Name = "combobox_BaoCaoDoanhSo_Thang";
            this.combobox_BaoCaoDoanhSo_Thang.Size = new System.Drawing.Size(96, 26);
            this.combobox_BaoCaoDoanhSo_Thang.TabIndex = 35;
            // 
            // textbox_BaoCaoDoanhSo_Nam
            // 
            this.textbox_BaoCaoDoanhSo_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_BaoCaoDoanhSo_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_BaoCaoDoanhSo_Nam.Location = new System.Drawing.Point(103, 158);
            this.textbox_BaoCaoDoanhSo_Nam.Name = "textbox_BaoCaoDoanhSo_Nam";
            this.textbox_BaoCaoDoanhSo_Nam.Size = new System.Drawing.Size(96, 24);
            this.textbox_BaoCaoDoanhSo_Nam.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(28, 160);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 18);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Năm:\r\n";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(28, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 18);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Tháng:\r\n";
            // 
            // snapControl1
            // 
            this.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapControl1.EnableToolTips = true;
            this.snapControl1.Location = new System.Drawing.Point(0, 0);
            this.snapControl1.Modified = true;
            this.snapControl1.Name = "snapControl1";
            this.snapControl1.Options.CopyPaste.MaintainDocumentSectionSettings = false;
            this.snapControl1.Options.Fields.EnableEmptyFieldDataAlias = true;
            this.snapControl1.Options.Fields.UpdateDocVariablesBeforeCopy = true;
            this.snapControl1.Options.Fields.UpdateDocVariablesBeforePrint = true;
            this.snapControl1.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            this.snapControl1.ReadOnly = true;
            this.snapControl1.Size = new System.Drawing.Size(517, 216);
            this.snapControl1.TabIndex = 0;
            // 
            // SalebindingSource1
            // 
            this.SalebindingSource1.DataMember = "DoanhSo";
            this.SalebindingSource1.DataSource = this.dataSet11;
            // 
            // doanhSoTableAdapter
            // 
            this.doanhSoTableAdapter.ClearBeforeFill = true;
            // 
            // doanhSoBindingSource2
            // 
            this.doanhSoBindingSource2.DataMember = "DoanhSo";
            this.doanhSoBindingSource2.DataSource = this.dataSet11;
            // 
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 473);
            this.Name = "frmSaleReport";
            this.Text = "frmSaleReport";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhSoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhSoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalebindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhSoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.SimpleButton button_BaoCaoDoanhSo_LapBaoCao;
        private System.Windows.Forms.ComboBox combobox_BaoCaoDoanhSo_Thang;
        private System.Windows.Forms.TextBox textbox_BaoCaoDoanhSo_Nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Snap.SnapControl snapControl1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_BaoCaoDoanhSo;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource SalebindingSource1;
        private DataSet1TableAdapters.DoanhSoTableAdapter doanhSoTableAdapter;
        private System.Windows.Forms.BindingSource DoanhSoBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource doanhSoBindingSource1;
        private System.Windows.Forms.BindingSource doanhSoBindingSource2;
    }
}