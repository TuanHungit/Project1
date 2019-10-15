namespace Cafe_Management.GUI
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_QuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_ChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_ = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_TacVu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThucDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ban = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_ThongKe = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage_QuanLy
            // 
            this.ribbonPage_QuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage_QuanLy.Name = "ribbonPage_QuanLy";
            this.ribbonPage_QuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DoanhThu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ThongKe);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thống kê";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ThucDon);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Ban);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục";
            // 
            // ribbonPage_ChucNang
            // 
            this.ribbonPage_ChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_,
            this.ribbonPageGroup3});
            this.ribbonPage_ChucNang.Name = "ribbonPage_ChucNang";
            this.ribbonPage_ChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_ThongTinTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ thống";
            // 
            // ribbonPageGroup_
            // 
            this.ribbonPageGroup_.ItemLinks.Add(this.btn_TacVu);
            this.ribbonPageGroup_.Name = "ribbonPageGroup_";
            this.ribbonPageGroup_.Text = "Chức năng";
            // 
            // btn_TacVu
            // 
            this.btn_TacVu.Caption = "Tác vụ";
            this.btn_TacVu.Id = 1;
            this.btn_TacVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TacVu.ImageOptions.Image")));
            this.btn_TacVu.Name = "btn_TacVu";
            this.btn_TacVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_ThongTinTaiKhoan
            // 
            this.btn_ThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btn_ThongTinTaiKhoan.Id = 2;
            this.btn_ThongTinTaiKhoan.ImageOptions.Image = global::Cafe_Management.Properties.Resources.user_info_icon;
            this.btn_ThongTinTaiKhoan.Name = "btn_ThongTinTaiKhoan";
            this.btn_ThongTinTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_ThongTinTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongTinTaiKhoan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Id = 4;
            this.btn_DangXuat.ImageOptions.Image = global::Cafe_Management.Properties.Resources.logout_icon;
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_ThucDon
            // 
            this.btn_ThucDon.Caption = "Thực đơn";
            this.btn_ThucDon.Id = 5;
            this.btn_ThucDon.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Food_Coffee_icon;
            this.btn_ThucDon.Name = "btn_ThucDon";
            this.btn_ThucDon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.Caption = "Doanh Thu";
            this.btn_DoanhThu.Id = 9;
            this.btn_DoanhThu.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Cash_icon;
            this.btn_DoanhThu.Name = "btn_DoanhThu";
            this.btn_DoanhThu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_Ban
            // 
            this.btn_Ban.Caption = "Bàn";
            this.btn_Ban.Id = 10;
            this.btn_Ban.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Household_Table_icon;
            this.btn_Ban.Name = "btn_Ban";
            this.btn_Ban.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_TacVu,
            this.btn_ThongTinTaiKhoan,
            this.barButtonItem1,
            this.btn_DangXuat,
            this.btn_ThucDon,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btn_DoanhThu,
            this.btn_Ban,
            this.btn_ThongKe});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_ChucNang,
            this.ribbonPage_QuanLy});
            this.ribbonControl1.Size = new System.Drawing.Size(892, 176);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Caption = "Thống kê";
            this.btn_ThongKe.Id = 11;
            this.btn_ThongKe.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Presentation_icon;
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 611);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frMain";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ CAFE";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_QuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_ThucDon;
        private DevExpress.XtraBars.BarButtonItem btn_Ban;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_DoanhThu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_ChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_;
        private DevExpress.XtraBars.BarButtonItem btn_TacVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_ThongTinTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_ThongKe;
    }
}