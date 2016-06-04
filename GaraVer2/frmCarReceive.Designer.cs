namespace GaraVer2
{
    partial class frmCarReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarReceive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TiepNhan_MaTiepNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_TiepNhan_LamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TiepNhan_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TiepNhan_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TiepNhan_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TiepNhan_Email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TiepNhan_DienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TiepNhan_DiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_TiepNhan_TenChuXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_TiepNhan_HieuXe = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TiepNhan_BienSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.date_TiepNhan_NgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_TiepNhan_DanhSach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlygaraoto1 = new GaraVer2.QUANLYGARAOTO();
            this.TiepNhan_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_TiepNhan_DSTheoNgayTableAdapter = new GaraVer2.QUANLYGARAOTOTableAdapters.sp_TiepNhan_DSTheoNgayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiepNhan_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlygaraoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhan_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Location = new System.Drawing.Point(0, 327);
            this.panelControl2.Size = new System.Drawing.Size(1302, 46);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(1187, 2);
            this.panelControl4.Size = new System.Drawing.Size(113, 42);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(25, 5);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(113, 42);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(1298, 42);
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(0, 509);
            this.groupControl1.Size = new System.Drawing.Size(1302, 0);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.groupControl2.Controls.Add(this.tableLayoutPanel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1302, 509);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Tiếp nhận xe";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.89011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.10989F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 486F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelControl8);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_MaTiepNhan);
            this.groupPanel1.Controls.Add(this.btn_TiepNhan_LamMoi);
            this.groupPanel1.Controls.Add(this.btn_TiepNhan_Xoa);
            this.groupPanel1.Controls.Add(this.btn_TiepNhan_ThemMoi);
            this.groupPanel1.Controls.Add(this.btn_TiepNhan_CapNhat);
            this.groupPanel1.Controls.Add(this.labelControl7);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_Email);
            this.groupPanel1.Controls.Add(this.labelControl6);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_DienThoai);
            this.groupPanel1.Controls.Add(this.labelControl5);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_DiaChi);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_TenChuXe);
            this.groupPanel1.Controls.Add(this.labelControl3);
            this.groupPanel1.Controls.Add(this.labelControl2);
            this.groupPanel1.Controls.Add(this.labelControl4);
            this.groupPanel1.Controls.Add(this.cbox_TiepNhan_HieuXe);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.txt_TiepNhan_BienSo);
            this.groupPanel1.Controls.Add(this.date_TiepNhan_NgayTiepNhan);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(446, 480);
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
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "Nhập thông tin ";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl8.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl8.Location = new System.Drawing.Point(56, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 18);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Mã tiếp nhận: ";
            // 
            // txt_TiepNhan_MaTiepNhan
            // 
            this.txt_TiepNhan_MaTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_MaTiepNhan.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_MaTiepNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_MaTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_MaTiepNhan.Location = new System.Drawing.Point(168, 3);
            this.txt_TiepNhan_MaTiepNhan.Name = "txt_TiepNhan_MaTiepNhan";
            this.txt_TiepNhan_MaTiepNhan.PreventEnterBeep = true;
            this.txt_TiepNhan_MaTiepNhan.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_MaTiepNhan.TabIndex = 21;
            // 
            // btn_TiepNhan_LamMoi
            // 
            this.btn_TiepNhan_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TiepNhan_LamMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_TiepNhan_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhan_LamMoi.Image")));
            this.btn_TiepNhan_LamMoi.Location = new System.Drawing.Point(141, 350);
            this.btn_TiepNhan_LamMoi.Name = "btn_TiepNhan_LamMoi";
            this.btn_TiepNhan_LamMoi.Size = new System.Drawing.Size(76, 29);
            this.btn_TiepNhan_LamMoi.TabIndex = 20;
            this.btn_TiepNhan_LamMoi.Text = "Làm mới";
            this.btn_TiepNhan_LamMoi.Click += new System.EventHandler(this.btn_TiepNhan_LamMoi_Click);
            // 
            // btn_TiepNhan_Xoa
            // 
            this.btn_TiepNhan_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TiepNhan_Xoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_TiepNhan_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhan_Xoa.Image")));
            this.btn_TiepNhan_Xoa.Location = new System.Drawing.Point(346, 385);
            this.btn_TiepNhan_Xoa.Name = "btn_TiepNhan_Xoa";
            this.btn_TiepNhan_Xoa.Size = new System.Drawing.Size(79, 29);
            this.btn_TiepNhan_Xoa.TabIndex = 19;
            this.btn_TiepNhan_Xoa.Text = "Xóa";
            this.btn_TiepNhan_Xoa.Click += new System.EventHandler(this.btn_TiepNhan_Xoa_Click);
            // 
            // btn_TiepNhan_ThemMoi
            // 
            this.btn_TiepNhan_ThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TiepNhan_ThemMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_TiepNhan_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhan_ThemMoi.Image")));
            this.btn_TiepNhan_ThemMoi.Location = new System.Drawing.Point(264, 385);
            this.btn_TiepNhan_ThemMoi.Name = "btn_TiepNhan_ThemMoi";
            this.btn_TiepNhan_ThemMoi.Size = new System.Drawing.Size(76, 29);
            this.btn_TiepNhan_ThemMoi.TabIndex = 17;
            this.btn_TiepNhan_ThemMoi.Text = "Thêm mới";
            this.btn_TiepNhan_ThemMoi.Click += new System.EventHandler(this.btn_TiepNhan_ThemMoi_Click);
            // 
            // btn_TiepNhan_CapNhat
            // 
            this.btn_TiepNhan_CapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TiepNhan_CapNhat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_TiepNhan_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhan_CapNhat.Image")));
            this.btn_TiepNhan_CapNhat.Location = new System.Drawing.Point(182, 385);
            this.btn_TiepNhan_CapNhat.Name = "btn_TiepNhan_CapNhat";
            this.btn_TiepNhan_CapNhat.Size = new System.Drawing.Size(76, 29);
            this.btn_TiepNhan_CapNhat.TabIndex = 4;
            this.btn_TiepNhan_CapNhat.Text = "Cập Nhật";
            this.btn_TiepNhan_CapNhat.Click += new System.EventHandler(this.btn_TiepNhan_CapNhat_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl7.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl7.Location = new System.Drawing.Point(56, 175);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Ngày tiếp nhận:";
            // 
            // txt_TiepNhan_Email
            // 
            this.txt_TiepNhan_Email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_Email.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_Email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_Email.Location = new System.Drawing.Point(168, 322);
            this.txt_TiepNhan_Email.Name = "txt_TiepNhan_Email";
            this.txt_TiepNhan_Email.PreventEnterBeep = true;
            this.txt_TiepNhan_Email.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_Email.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl6.Location = new System.Drawing.Point(56, 324);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 18);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Email:";
            // 
            // txt_TiepNhan_DienThoai
            // 
            this.txt_TiepNhan_DienThoai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_DienThoai.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_DienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_DienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_DienThoai.Location = new System.Drawing.Point(168, 270);
            this.txt_TiepNhan_DienThoai.Name = "txt_TiepNhan_DienThoai";
            this.txt_TiepNhan_DienThoai.PreventEnterBeep = true;
            this.txt_TiepNhan_DienThoai.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_DienThoai.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl5.Location = new System.Drawing.Point(56, 272);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 18);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // txt_TiepNhan_DiaChi
            // 
            this.txt_TiepNhan_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_DiaChi.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_DiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_DiaChi.Location = new System.Drawing.Point(168, 129);
            this.txt_TiepNhan_DiaChi.Name = "txt_TiepNhan_DiaChi";
            this.txt_TiepNhan_DiaChi.PreventEnterBeep = true;
            this.txt_TiepNhan_DiaChi.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_DiaChi.TabIndex = 11;
            // 
            // txt_TiepNhan_TenChuXe
            // 
            this.txt_TiepNhan_TenChuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_TenChuXe.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_TenChuXe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_TenChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_TenChuXe.Location = new System.Drawing.Point(168, 81);
            this.txt_TiepNhan_TenChuXe.Name = "txt_TiepNhan_TenChuXe";
            this.txt_TiepNhan_TenChuXe.PreventEnterBeep = true;
            this.txt_TiepNhan_TenChuXe.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_TenChuXe.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl3.Location = new System.Drawing.Point(56, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Địa chỉ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl2.Location = new System.Drawing.Point(56, 224);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Hiệu xe:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl4.Location = new System.Drawing.Point(56, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tên chủ xe:";
            // 
            // cbox_TiepNhan_HieuXe
            // 
            this.cbox_TiepNhan_HieuXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbox_TiepNhan_HieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_TiepNhan_HieuXe.FormattingEnabled = true;
            this.cbox_TiepNhan_HieuXe.Location = new System.Drawing.Point(168, 221);
            this.cbox_TiepNhan_HieuXe.Name = "cbox_TiepNhan_HieuXe";
            this.cbox_TiepNhan_HieuXe.Size = new System.Drawing.Size(222, 26);
            this.cbox_TiepNhan_HieuXe.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(56, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Biển số:";
            // 
            // txt_TiepNhan_BienSo
            // 
            this.txt_TiepNhan_BienSo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txt_TiepNhan_BienSo.Border.Class = "TextBoxBorder";
            this.txt_TiepNhan_BienSo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TiepNhan_BienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiepNhan_BienSo.Location = new System.Drawing.Point(168, 35);
            this.txt_TiepNhan_BienSo.Name = "txt_TiepNhan_BienSo";
            this.txt_TiepNhan_BienSo.PreventEnterBeep = true;
            this.txt_TiepNhan_BienSo.Size = new System.Drawing.Size(222, 24);
            this.txt_TiepNhan_BienSo.TabIndex = 2;
            this.txt_TiepNhan_BienSo.TextChanged += new System.EventHandler(this.txt_TiepNhan_TenChuXe_TextChanged_1);
            // 
            // date_TiepNhan_NgayTiepNhan
            // 
            this.date_TiepNhan_NgayTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.date_TiepNhan_NgayTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_TiepNhan_NgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TiepNhan_NgayTiepNhan.Location = new System.Drawing.Point(168, 175);
            this.date_TiepNhan_NgayTiepNhan.Name = "date_TiepNhan_NgayTiepNhan";
            this.date_TiepNhan_NgayTiepNhan.Size = new System.Drawing.Size(222, 24);
            this.date_TiepNhan_NgayTiepNhan.TabIndex = 0;
            this.date_TiepNhan_NgayTiepNhan.ValueChanged += new System.EventHandler(this.date_TiepNhan_NgayTiepNhan_ValueChanged);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgv_TiepNhan_DanhSach);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(455, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(840, 480);
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
            this.groupPanel2.Text = "Danh sách xe tiếp nhận trong ngày";
            // 
            // dgv_TiepNhan_DanhSach
            // 
            this.dgv_TiepNhan_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TiepNhan_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTiepNhan,
            this.BienSo,
            this.HieuXe,
            this.Ten,
            this.SoDT,
            this.DiaChi,
            this.Email,
            this.Ngay,
            this.TienNo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TiepNhan_DanhSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TiepNhan_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TiepNhan_DanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_TiepNhan_DanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgv_TiepNhan_DanhSach.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.dgv_TiepNhan_DanhSach.Name = "dgv_TiepNhan_DanhSach";
            this.dgv_TiepNhan_DanhSach.Size = new System.Drawing.Size(834, 458);
            this.dgv_TiepNhan_DanhSach.TabIndex = 1;
            this.dgv_TiepNhan_DanhSach.Click += new System.EventHandler(this.dgv_TiepNhan_DanhSach_Click);
            // 
            // MaTiepNhan
            // 
            this.MaTiepNhan.DataPropertyName = "MaTiepNhan";
            this.MaTiepNhan.HeaderText = "Mã Tiếp Nhận";
            this.MaTiepNhan.Name = "MaTiepNhan";
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSo";
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // HieuXe
            // 
            this.HieuXe.DataPropertyName = "HieuXe";
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenChuXe";
            this.Ten.HeaderText = "Tên chủ xe";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "DienThoai";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayTiepNhan";
            this.Ngay.HeaderText = "Ngày tiếp nhận";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // TienNo
            // 
            this.TienNo.DataPropertyName = "TienNo";
            this.TienNo.HeaderText = "Tiền nợ";
            this.TienNo.Name = "TienNo";
            this.TienNo.ReadOnly = true;
            // 
            // quanlygaraoto1
            // 
            this.quanlygaraoto1.DataSetName = "QUANLYGARAOTO";
            this.quanlygaraoto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TiepNhan_bindingSource
            // 
            this.TiepNhan_bindingSource.DataMember = "sp_TiepNhan_DSTheoNgay";
            this.TiepNhan_bindingSource.DataSource = this.quanlygaraoto1;
            // 
            // sp_TiepNhan_DSTheoNgayTableAdapter
            // 
            this.sp_TiepNhan_DSTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // frmCarReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 373);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmCarReceive";
            this.Text = "frmCarReceive";
            this.Load += new System.EventHandler(this.frmCarReceive_Load);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TiepNhan_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlygaraoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiepNhan_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_TiepNhan_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_TiepNhan_ThemMoi;
        private DevExpress.XtraEditors.SimpleButton btn_TiepNhan_CapNhat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_Email;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_DienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_DiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_TenChuXe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbox_TiepNhan_HieuXe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_BienSo;
        private System.Windows.Forms.DateTimePicker date_TiepNhan_NgayTiepNhan;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private QUANLYGARAOTO quanlygaraoto1;
        private DevExpress.XtraEditors.SimpleButton btn_TiepNhan_LamMoi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TiepNhan_MaTiepNhan;
        private System.Windows.Forms.BindingSource TiepNhan_bindingSource;
        private QUANLYGARAOTOTableAdapters.sp_TiepNhan_DSTheoNgayTableAdapter sp_TiepNhan_DSTheoNgayTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_TiepNhan_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNo;

    }
}