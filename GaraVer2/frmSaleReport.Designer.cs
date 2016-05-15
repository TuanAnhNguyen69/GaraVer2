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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReport));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnLapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 350);
            this.panelControl2.Size = new System.Drawing.Size(979, 44);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(864, 2);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(975, 40);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Size = new System.Drawing.Size(979, 350);
            this.groupControl1.Text = "Báo cáo doanh số";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.reportViewer1);
            this.groupPanel2.Location = new System.Drawing.Point(308, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(664, 321);
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(658, 299);
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
            this.groupPanel1.Controls.Add(this.cbThang);
            this.groupPanel1.Controls.Add(this.txtNam);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(299, 321);
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
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnLapBaoCao.Image")));
            this.btnLapBaoCao.Location = new System.Drawing.Point(77, 201);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(126, 46);
            this.btnLapBaoCao.TabIndex = 36;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            // 
            // cbThang
            // 
            this.cbThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
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
            this.cbThang.Location = new System.Drawing.Point(121, 102);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(96, 26);
            this.cbThang.TabIndex = 35;
            // 
            // txtNam
            // 
            this.txtNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(121, 158);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(96, 24);
            this.txtNam.TabIndex = 34;
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
            this.labelControl1.Location = new System.Drawing.Point(46, 160);
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
            this.labelControl5.Location = new System.Drawing.Point(46, 105);
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
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 394);
            this.Name = "frmSaleReport";
            this.Text = "frmSaleReport";
            this.Load += new System.EventHandler(this.frmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.SimpleButton btnLapBaoCao;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.TextBox txtNam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Snap.SnapControl snapControl1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}