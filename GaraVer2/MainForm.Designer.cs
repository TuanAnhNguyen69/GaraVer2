namespace GaraVer2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navBarControl_Task = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup_CarReceiving = new DevExpress.XtraNavBar.NavBarGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.radio_carBrand = new System.Windows.Forms.RadioButton();
            this.radio_carplateNumber = new System.Windows.Forms.RadioButton();
            this.radio_carownerName = new System.Windows.Forms.RadioButton();
            this.Button_Search = new DevExpress.XtraEditors.SimpleButton();
            this.dropDown_CarPart = new DevExpress.XtraEditors.DropDownButton();
            this.dropDown_CarBrand = new DevExpress.XtraEditors.DropDownButton();
            this.date_Search = new DevExpress.XtraEditors.DateEdit();
            this.textEdit_plateSearch = new DevExpress.XtraEditors.TextEdit();
            this.radio_carPart = new System.Windows.Forms.RadioButton();
            this.radio_Date = new System.Windows.Forms.RadioButton();
            this.textEdit_ownerSearch = new DevExpress.XtraEditors.TextEdit();
            this.Button_Login = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_Password = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Acount = new DevExpress.XtraEditors.TextEdit();
            this.checkBox_AccRemember = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.Button_Infor = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Setting = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.navBarGroup_Receipt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup_Report = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_CarReceive = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Receipt_Fixing = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Report_Sale = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Receipt_Money = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_Report_Inventory = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_Task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Search.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_plateSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ownerSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Acount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1350, 142);
            this.panelControl1.TabIndex = 0;
            // 
            // navBarControl_Task
            // 
            this.navBarControl_Task.ActiveGroup = this.navBarGroup_CarReceiving;
            this.navBarControl_Task.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl_Task.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup_CarReceiving,
            this.navBarGroup_Receipt,
            this.navBarGroup_Report});
            this.navBarControl_Task.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_CarReceive,
            this.navBarItem_Receipt_Fixing,
            this.navBarItem_Report_Sale,
            this.navBarItem_Receipt_Money,
            this.navBarItem_Report_Inventory});
            this.navBarControl_Task.Location = new System.Drawing.Point(0, 142);
            this.navBarControl_Task.Name = "navBarControl_Task";
            this.navBarControl_Task.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl_Task.Size = new System.Drawing.Size(243, 587);
            this.navBarControl_Task.TabIndex = 1;
            this.navBarControl_Task.Text = "navBarControl1";
            // 
            // navBarGroup_CarReceiving
            // 
            this.navBarGroup_CarReceiving.Caption = "Tiếp nhận xe";
            this.navBarGroup_CarReceiving.Expanded = true;
            this.navBarGroup_CarReceiving.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_CarReceive)});
            this.navBarGroup_CarReceiving.Name = "navBarGroup_CarReceiving";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(243, 142);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1107, 587);
            this.panelControl2.TabIndex = 2;
            // 
            // radio_carBrand
            // 
            this.radio_carBrand.Location = new System.Drawing.Point(10, 82);
            this.radio_carBrand.Name = "radio_carBrand";
            this.radio_carBrand.Size = new System.Drawing.Size(85, 25);
            this.radio_carBrand.TabIndex = 15;
            this.radio_carBrand.TabStop = true;
            this.radio_carBrand.Text = "Hiệu xe";
            this.radio_carBrand.UseVisualStyleBackColor = true;
            // 
            // radio_carplateNumber
            // 
            this.radio_carplateNumber.Location = new System.Drawing.Point(10, 51);
            this.radio_carplateNumber.Name = "radio_carplateNumber";
            this.radio_carplateNumber.Size = new System.Drawing.Size(85, 25);
            this.radio_carplateNumber.TabIndex = 14;
            this.radio_carplateNumber.TabStop = true;
            this.radio_carplateNumber.Text = "Biển số xe";
            this.radio_carplateNumber.UseVisualStyleBackColor = true;
            // 
            // radio_carownerName
            // 
            this.radio_carownerName.Location = new System.Drawing.Point(10, 10);
            this.radio_carownerName.Name = "radio_carownerName";
            this.radio_carownerName.Size = new System.Drawing.Size(85, 35);
            this.radio_carownerName.TabIndex = 12;
            this.radio_carownerName.TabStop = true;
            this.radio_carownerName.Text = "Tên chủ xe";
            this.radio_carownerName.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Image = ((System.Drawing.Image)(resources.GetObject("Button_Search.Image")));
            this.Button_Search.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Button_Search.Location = new System.Drawing.Point(581, 15);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(104, 95);
            this.Button_Search.TabIndex = 22;
            this.Button_Search.Text = "Tìm kiếm";
            // 
            // dropDown_CarPart
            // 
            this.dropDown_CarPart.Location = new System.Drawing.Point(384, 51);
            this.dropDown_CarPart.Name = "dropDown_CarPart";
            this.dropDown_CarPart.Size = new System.Drawing.Size(180, 23);
            this.dropDown_CarPart.TabIndex = 21;
            this.dropDown_CarPart.Text = "Chọn hãng phụ tùng";
            // 
            // dropDown_CarBrand
            // 
            this.dropDown_CarBrand.Location = new System.Drawing.Point(101, 84);
            this.dropDown_CarBrand.Name = "dropDown_CarBrand";
            this.dropDown_CarBrand.Size = new System.Drawing.Size(180, 23);
            this.dropDown_CarBrand.TabIndex = 20;
            this.dropDown_CarBrand.Text = "Chọn hiệu xe";
            // 
            // date_Search
            // 
            this.date_Search.EditValue = null;
            this.date_Search.Location = new System.Drawing.Point(384, 18);
            this.date_Search.Name = "date_Search";
            this.date_Search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Search.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Search.Size = new System.Drawing.Size(180, 20);
            this.date_Search.TabIndex = 19;
            // 
            // textEdit_plateSearch
            // 
            this.textEdit_plateSearch.Location = new System.Drawing.Point(101, 54);
            this.textEdit_plateSearch.Name = "textEdit_plateSearch";
            this.textEdit_plateSearch.Size = new System.Drawing.Size(180, 20);
            this.textEdit_plateSearch.TabIndex = 18;
            // 
            // radio_carPart
            // 
            this.radio_carPart.Location = new System.Drawing.Point(302, 51);
            this.radio_carPart.Name = "radio_carPart";
            this.radio_carPart.Size = new System.Drawing.Size(76, 25);
            this.radio_carPart.TabIndex = 17;
            this.radio_carPart.TabStop = true;
            this.radio_carPart.Text = "Phụ tùng";
            this.radio_carPart.UseVisualStyleBackColor = true;
            // 
            // radio_Date
            // 
            this.radio_Date.Location = new System.Drawing.Point(302, 15);
            this.radio_Date.Name = "radio_Date";
            this.radio_Date.Size = new System.Drawing.Size(76, 25);
            this.radio_Date.TabIndex = 16;
            this.radio_Date.TabStop = true;
            this.radio_Date.Text = "Ngày";
            this.radio_Date.UseVisualStyleBackColor = true;
            // 
            // textEdit_ownerSearch
            // 
            this.textEdit_ownerSearch.Location = new System.Drawing.Point(101, 18);
            this.textEdit_ownerSearch.Name = "textEdit_ownerSearch";
            this.textEdit_ownerSearch.Size = new System.Drawing.Size(180, 20);
            this.textEdit_ownerSearch.TabIndex = 13;
            // 
            // Button_Login
            // 
            this.Button_Login.Image = ((System.Drawing.Image)(resources.GetObject("Button_Login.Image")));
            this.Button_Login.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Button_Login.Location = new System.Drawing.Point(300, 15);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(104, 95);
            this.Button_Login.TabIndex = 28;
            this.Button_Login.Text = "Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textEdit_Password
            // 
            this.textEdit_Password.Location = new System.Drawing.Point(105, 48);
            this.textEdit_Password.Name = "textEdit_Password";
            this.textEdit_Password.Size = new System.Drawing.Size(180, 20);
            this.textEdit_Password.TabIndex = 24;
            // 
            // textEdit_Acount
            // 
            this.textEdit_Acount.Location = new System.Drawing.Point(105, 18);
            this.textEdit_Acount.Name = "textEdit_Acount";
            this.textEdit_Acount.Size = new System.Drawing.Size(180, 20);
            this.textEdit_Acount.TabIndex = 23;
            // 
            // checkBox_AccRemember
            // 
            this.checkBox_AccRemember.AutoSize = true;
            this.checkBox_AccRemember.Location = new System.Drawing.Point(105, 78);
            this.checkBox_AccRemember.Name = "checkBox_AccRemember";
            this.checkBox_AccRemember.Size = new System.Drawing.Size(67, 17);
            this.checkBox_AccRemember.TabIndex = 27;
            this.checkBox_AccRemember.Text = "Ghi nhớ?";
            this.checkBox_AccRemember.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl3.Controls.Add(this.radio_carBrand);
            this.panelControl3.Controls.Add(this.Button_Search);
            this.panelControl3.Controls.Add(this.radio_Date);
            this.panelControl3.Controls.Add(this.radio_carplateNumber);
            this.panelControl3.Controls.Add(this.radio_carPart);
            this.panelControl3.Controls.Add(this.textEdit_ownerSearch);
            this.panelControl3.Controls.Add(this.radio_carownerName);
            this.panelControl3.Controls.Add(this.textEdit_plateSearch);
            this.panelControl3.Controls.Add(this.date_Search);
            this.panelControl3.Controls.Add(this.dropDown_CarBrand);
            this.panelControl3.Controls.Add(this.dropDown_CarPart);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(709, 138);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl4.Controls.Add(this.Button_Infor);
            this.panelControl4.Controls.Add(this.Button_Setting);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(1135, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(213, 138);
            this.panelControl4.TabIndex = 1;
            // 
            // Button_Infor
            // 
            this.Button_Infor.Image = ((System.Drawing.Image)(resources.GetObject("Button_Infor.Image")));
            this.Button_Infor.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Button_Infor.Location = new System.Drawing.Point(120, 15);
            this.Button_Infor.Name = "Button_Infor";
            this.Button_Infor.Size = new System.Drawing.Size(83, 95);
            this.Button_Infor.TabIndex = 16;
            this.Button_Infor.Text = "Thông tin";
            // 
            // Button_Setting
            // 
            this.Button_Setting.Image = ((System.Drawing.Image)(resources.GetObject("Button_Setting.Image")));
            this.Button_Setting.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.Button_Setting.Location = new System.Drawing.Point(21, 15);
            this.Button_Setting.Name = "Button_Setting";
            this.Button_Setting.Size = new System.Drawing.Size(83, 95);
            this.Button_Setting.TabIndex = 15;
            this.Button_Setting.Text = "Thiết lập";
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl5.Controls.Add(this.Button_Login);
            this.panelControl5.Controls.Add(this.label1);
            this.panelControl5.Controls.Add(this.textEdit_Acount);
            this.panelControl5.Controls.Add(this.label2);
            this.panelControl5.Controls.Add(this.checkBox_AccRemember);
            this.panelControl5.Controls.Add(this.textEdit_Password);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(711, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(424, 138);
            this.panelControl5.TabIndex = 2;
            // 
            // navBarGroup_Receipt
            // 
            this.navBarGroup_Receipt.Caption = "Hóa đơn kinh doanh";
            this.navBarGroup_Receipt.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Receipt_Fixing),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Receipt_Money)});
            this.navBarGroup_Receipt.Name = "navBarGroup_Receipt";
            // 
            // navBarGroup_Report
            // 
            this.navBarGroup_Report.Caption = "Báo cáo doanh số";
            this.navBarGroup_Report.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Report_Sale),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_Report_Inventory)});
            this.navBarGroup_Report.Name = "navBarGroup_Report";
            // 
            // navBarItem_CarReceive
            // 
            this.navBarItem_CarReceive.Caption = "Tiếp nhận xe";
            this.navBarItem_CarReceive.Name = "navBarItem_CarReceive";
            // 
            // navBarItem_Receipt_Fixing
            // 
            this.navBarItem_Receipt_Fixing.Caption = "Phiếu sửa chữa";
            this.navBarItem_Receipt_Fixing.Name = "navBarItem_Receipt_Fixing";
            // 
            // navBarItem_Report_Sale
            // 
            this.navBarItem_Report_Sale.Caption = "Báo cáo doanh số";
            this.navBarItem_Report_Sale.Name = "navBarItem_Report_Sale";
            // 
            // navBarItem_Receipt_Money
            // 
            this.navBarItem_Receipt_Money.Caption = "Phiếu thu tiền";
            this.navBarItem_Receipt_Money.Name = "navBarItem_Receipt_Money";
            // 
            // navBarItem_Report_Inventory
            // 
            this.navBarItem_Report_Inventory.Caption = "Báo cáo tồn";
            this.navBarItem_Report_Inventory.Name = "navBarItem_Report_Inventory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.navBarControl_Task);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "Quản lý Gara";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl_Task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Search.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_plateSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ownerSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Acount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl_Task;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_CarReceiving;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton Button_Login;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit_Acount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_AccRemember;
        private DevExpress.XtraEditors.TextEdit textEdit_Password;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton Button_Infor;
        private DevExpress.XtraEditors.SimpleButton Button_Setting;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.RadioButton radio_carBrand;
        private DevExpress.XtraEditors.SimpleButton Button_Search;
        private System.Windows.Forms.RadioButton radio_Date;
        private System.Windows.Forms.RadioButton radio_carplateNumber;
        private System.Windows.Forms.RadioButton radio_carPart;
        private DevExpress.XtraEditors.TextEdit textEdit_ownerSearch;
        private System.Windows.Forms.RadioButton radio_carownerName;
        private DevExpress.XtraEditors.TextEdit textEdit_plateSearch;
        private DevExpress.XtraEditors.DateEdit date_Search;
        private DevExpress.XtraEditors.DropDownButton dropDown_CarBrand;
        private DevExpress.XtraEditors.DropDownButton dropDown_CarPart;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Report;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Report_Sale;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_CarReceive;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup_Receipt;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Receipt_Fixing;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Receipt_Money;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_Report_Inventory;
    }
}