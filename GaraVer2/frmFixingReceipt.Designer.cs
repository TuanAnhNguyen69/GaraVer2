namespace GaraVer2
{
    partial class frmFixingReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixingReceipt));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tablePhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.lbcSoLuongTon = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnQLTienCong = new DevExpress.XtraEditors.SimpleButton();
            this.btnQLVTPT = new DevExpress.XtraEditors.SimpleButton();
            this.cbNoiDung = new System.Windows.Forms.ComboBox();
            this.lbNoiDung = new DevExpress.XtraEditors.LabelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTienCong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgaySuaChua = new System.Windows.Forms.DateTimePicker();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbBienSo = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbVTPT = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 509);
            this.panelControl2.Size = new System.Drawing.Size(1096, 44);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(981, 2);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(1092, 40);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Size = new System.Drawing.Size(1096, 509);
            this.groupControl1.Text = "Phiếu sửa chữa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.84982F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.tablePhieuSuaChua);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(365, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(724, 480);
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
            this.groupPanel2.Text = "Thông tin phiếu sữa chữa";
            // 
            // tablePhieuSuaChua
            // 
            this.tablePhieuSuaChua.AllowUserToOrderColumns = true;
            this.tablePhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhieuSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.MaVT,
            this.SoLuong2,
            this.DonGia2,
            this.NoiDung2,
            this.TienCong2,
            this.ThanhTien2});
            this.tablePhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePhieuSuaChua.Location = new System.Drawing.Point(0, 0);
            this.tablePhieuSuaChua.Name = "tablePhieuSuaChua";
            this.tablePhieuSuaChua.Size = new System.Drawing.Size(718, 458);
            this.tablePhieuSuaChua.TabIndex = 1;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieuSuaChua";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // MaVT
            // 
            this.MaVT.DataPropertyName = "MaVatTuPhuTung";
            this.MaVT.HeaderText = "Mã vật tư";
            this.MaVT.Name = "MaVT";
            this.MaVT.ReadOnly = true;
            // 
            // SoLuong2
            // 
            this.SoLuong2.DataPropertyName = "SoLuong";
            this.SoLuong2.HeaderText = "Số lượng";
            this.SoLuong2.Name = "SoLuong2";
            this.SoLuong2.ReadOnly = true;
            // 
            // DonGia2
            // 
            this.DonGia2.DataPropertyName = "DonGia";
            this.DonGia2.HeaderText = "Đơn giá";
            this.DonGia2.Name = "DonGia2";
            this.DonGia2.ReadOnly = true;
            // 
            // NoiDung2
            // 
            this.NoiDung2.DataPropertyName = "NoiDungSuaChua";
            this.NoiDung2.HeaderText = "Nội dung sữa chữa";
            this.NoiDung2.Name = "NoiDung2";
            this.NoiDung2.ReadOnly = true;
            this.NoiDung2.Width = 200;
            // 
            // TienCong2
            // 
            this.TienCong2.DataPropertyName = "TienCong";
            this.TienCong2.HeaderText = "Tiền công";
            this.TienCong2.Name = "TienCong2";
            this.TienCong2.ReadOnly = true;
            this.TienCong2.Width = 150;
            // 
            // ThanhTien2
            // 
            this.ThanhTien2.DataPropertyName = "ThanhTien";
            this.ThanhTien2.HeaderText = "Thành tiền";
            this.ThanhTien2.Name = "ThanhTien2";
            this.ThanhTien2.ReadOnly = true;
            this.ThanhTien2.Width = 150;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnKho);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.lbcSoLuongTon);
            this.groupPanel1.Controls.Add(this.labelControl7);
            this.groupPanel1.Controls.Add(this.btnQLTienCong);
            this.groupPanel1.Controls.Add(this.btnQLVTPT);
            this.groupPanel1.Controls.Add(this.cbNoiDung);
            this.groupPanel1.Controls.Add(this.lbNoiDung);
            this.groupPanel1.Controls.Add(this.btnIn);
            this.groupPanel1.Controls.Add(this.btnThemMoi);
            this.groupPanel1.Controls.Add(this.btnLapPhieu);
            this.groupPanel1.Controls.Add(this.txtDonGia);
            this.groupPanel1.Controls.Add(this.txtTienCong);
            this.groupPanel1.Controls.Add(this.labelControl6);
            this.groupPanel1.Controls.Add(this.txtThanhTien);
            this.groupPanel1.Controls.Add(this.labelControl9);
            this.groupPanel1.Controls.Add(this.dtpNgaySuaChua);
            this.groupPanel1.Controls.Add(this.labelControl10);
            this.groupPanel1.Controls.Add(this.txtMaPhieu);
            this.groupPanel1.Controls.Add(this.cbBienSo);
            this.groupPanel1.Controls.Add(this.labelControl3);
            this.groupPanel1.Controls.Add(this.labelControl2);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.txtSoLuong);
            this.groupPanel1.Controls.Add(this.labelControl4);
            this.groupPanel1.Controls.Add(this.cbVTPT);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(356, 480);
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
            this.groupPanel1.Text = "Lập phiếu sửa chữa";
            // 
            // btnKho
            // 
            this.btnKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKho.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKho.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.Image")));
            this.btnKho.Location = new System.Drawing.Point(249, 63);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(65, 26);
            this.btnKho.TabIndex = 53;
            this.btnKho.Text = "Kho VT";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(243, 379);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 23);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            // 
            // lbcSoLuongTon
            // 
            this.lbcSoLuongTon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbcSoLuongTon.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcSoLuongTon.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbcSoLuongTon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbcSoLuongTon.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbcSoLuongTon.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lbcSoLuongTon.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lbcSoLuongTon.Location = new System.Drawing.Point(306, 176);
            this.lbcSoLuongTon.Name = "lbcSoLuongTon";
            this.lbcSoLuongTon.Size = new System.Drawing.Size(8, 18);
            this.lbcSoLuongTon.TabIndex = 49;
            this.lbcSoLuongTon.Text = "0";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl7.Location = new System.Drawing.Point(261, 176);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 18);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Tồn:";
            // 
            // btnQLTienCong
            // 
            this.btnQLTienCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLTienCong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTienCong.Image")));
            this.btnQLTienCong.Location = new System.Drawing.Point(222, 208);
            this.btnQLTienCong.Name = "btnQLTienCong";
            this.btnQLTienCong.Size = new System.Drawing.Size(92, 24);
            this.btnQLTienCong.TabIndex = 47;
            this.btnQLTienCong.Text = "QL Tiền công";
            // 
            // btnQLVTPT
            // 
            this.btnQLVTPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLVTPT.Image = ((System.Drawing.Image)(resources.GetObject("btnQLVTPT.Image")));
            this.btnQLVTPT.Location = new System.Drawing.Point(87, 350);
            this.btnQLVTPT.Name = "btnQLVTPT";
            this.btnQLVTPT.Size = new System.Drawing.Size(71, 52);
            this.btnQLVTPT.TabIndex = 46;
            this.btnQLVTPT.Text = "QL VTPT";
            // 
            // cbNoiDung
            // 
            this.cbNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoiDung.FormattingEnabled = true;
            this.cbNoiDung.Location = new System.Drawing.Point(96, 100);
            this.cbNoiDung.Name = "cbNoiDung";
            this.cbNoiDung.Size = new System.Drawing.Size(218, 26);
            this.cbNoiDung.TabIndex = 44;
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNoiDung.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbNoiDung.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNoiDung.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbNoiDung.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lbNoiDung.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lbNoiDung.Location = new System.Drawing.Point(11, 103);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(63, 18);
            this.lbNoiDung.TabIndex = 43;
            this.lbNoiDung.Text = "Nội dung:";
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.Enabled = false;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(164, 379);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(73, 23);
            this.btnIn.TabIndex = 42;
            this.btnIn.Text = "In";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(164, 350);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(73, 23);
            this.btnThemMoi.TabIndex = 41;
            this.btnThemMoi.Text = "Thêm mới";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.Image")));
            this.btnLapPhieu.Location = new System.Drawing.Point(243, 350);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(73, 23);
            this.btnLapPhieu.TabIndex = 40;
            this.btnLapPhieu.Text = "Lập phiếu";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(96, 282);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PreventEnterBeep = true;
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(220, 24);
            this.txtDonGia.TabIndex = 33;
            // 
            // txtTienCong
            // 
            this.txtTienCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtTienCong.Border.Class = "TextBoxBorder";
            this.txtTienCong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTienCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCong.Location = new System.Drawing.Point(96, 208);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.PreventEnterBeep = true;
            this.txtTienCong.ReadOnly = true;
            this.txtTienCong.Size = new System.Drawing.Size(117, 24);
            this.txtTienCong.TabIndex = 37;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(11, 284);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 18);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Đơn giá:\r\n";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(96, 315);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PreventEnterBeep = true;
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(220, 24);
            this.txtThanhTien.TabIndex = 39;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl9.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl9.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl9.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl9.Location = new System.Drawing.Point(11, 210);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(69, 18);
            this.labelControl9.TabIndex = 36;
            this.labelControl9.Text = "Tiền công:\r\n";
            // 
            // dtpNgaySuaChua
            // 
            this.dtpNgaySuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpNgaySuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySuaChua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySuaChua.Location = new System.Drawing.Point(96, 243);
            this.dtpNgaySuaChua.Name = "dtpNgaySuaChua";
            this.dtpNgaySuaChua.Size = new System.Drawing.Size(220, 24);
            this.dtpNgaySuaChua.TabIndex = 29;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl10.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl10.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl10.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl10.Location = new System.Drawing.Point(11, 317);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(72, 18);
            this.labelControl10.TabIndex = 38;
            this.labelControl10.Text = "Thành tiền:\r\n";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(96, 28);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PreventEnterBeep = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(218, 24);
            this.txtMaPhieu.TabIndex = 24;
            // 
            // cbBienSo
            // 
            this.cbBienSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBienSo.FormattingEnabled = true;
            this.cbBienSo.Location = new System.Drawing.Point(96, 138);
            this.cbBienSo.Name = "cbBienSo";
            this.cbBienSo.Size = new System.Drawing.Size(220, 26);
            this.cbBienSo.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl3.Location = new System.Drawing.Point(11, 248);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Ngày sửa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl2.Location = new System.Drawing.Point(11, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 18);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Mã phiếu:\r\n";
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
            this.labelControl1.Location = new System.Drawing.Point(11, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Biển số:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.txtSoLuong.Border.Class = "TextBoxBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(96, 174);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PreventEnterBeep = true;
            this.txtSoLuong.Size = new System.Drawing.Size(159, 24);
            this.txtSoLuong.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl4.Location = new System.Drawing.Point(11, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 18);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Mã Vật tư:\r\n";
            // 
            // cbVTPT
            // 
            this.cbVTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbVTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVTPT.FormattingEnabled = true;
            this.cbVTPT.Location = new System.Drawing.Point(96, 63);
            this.cbVTPT.Name = "cbVTPT";
            this.cbVTPT.Size = new System.Drawing.Size(149, 26);
            this.cbVTPT.TabIndex = 30;
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
            this.labelControl5.Location = new System.Drawing.Point(11, 176);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 18);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Số lượng:\r\n";
            // 
            // frmFixingReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 553);
            this.Name = "frmFixingReceipt";
            this.Text = "frmFixingReceipt";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuSuaChua)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.SimpleButton btnKho;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LabelControl lbcSoLuongTon;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnQLTienCong;
        private DevExpress.XtraEditors.SimpleButton btnQLVTPT;
        private System.Windows.Forms.ComboBox cbNoiDung;
        private DevExpress.XtraEditors.LabelControl lbNoiDung;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTienCong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dtpNgaySuaChua;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private System.Windows.Forms.ComboBox cbBienSo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbVTPT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.DataGridView tablePhieuSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien2;
    }
}