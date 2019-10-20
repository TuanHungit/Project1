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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsTextDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnShowForm = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnViewFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCategoryFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendMail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCateogry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupStatictis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsTextDate);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 558);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1173, 34);
            // 
            // bsTextDate
            // 
            this.bsTextDate.Caption = "barStaticItem1";
            this.bsTextDate.Id = 12;
            this.bsTextDate.Name = "bsTextDate";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShowForm,
            this.barSubItem1,
            this.btnViewFood,
            this.btnViewCategoryFood,
            this.btnViewTable,
            this.btnAccountInfo,
            this.btnLogOut,
            this.btnViewAccount,
            this.btnViewBill,
            this.btnStatistic,
            this.bsTextDate,
            this.ribbonGalleryBarItem1,
            this.btnBackup,
            this.btnRestore,
            this.btnLog,
            this.btnSendMail});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPageManager});
            this.ribbon.Size = new System.Drawing.Size(1173, 176);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnShowForm
            // 
            this.btnShowForm.Caption = "Tác vụ";
            this.btnShowForm.Id = 2;
            this.btnShowForm.ImageOptions.Image = global::Cafe_Management.Properties.Resources.icon_developer_icon;
            this.btnShowForm.LargeWidth = 75;
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowForm_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnViewFood
            // 
            this.btnViewFood.Caption = "Thực đơn";
            this.btnViewFood.Id = 4;
            this.btnViewFood.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Food_Coffee_icon;
            this.btnViewFood.LargeWidth = 75;
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnViewCategoryFood
            // 
            this.btnViewCategoryFood.Caption = "Danh mục";
            this.btnViewCategoryFood.Id = 5;
            this.btnViewCategoryFood.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Ecommerce_Bill_icon;
            this.btnViewCategoryFood.LargeWidth = 75;
            this.btnViewCategoryFood.Name = "btnViewCategoryFood";
            this.btnViewCategoryFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Caption = "Bàn";
            this.btnViewTable.Id = 6;
            this.btnViewTable.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Household_Table_icon;
            this.btnViewTable.LargeWidth = 75;
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Caption = "Thông tin tài khoản";
            this.btnAccountInfo.Id = 7;
            this.btnAccountInfo.ImageOptions.Image = global::Cafe_Management.Properties.Resources.user_info_icon;
            this.btnAccountInfo.LargeWidth = 75;
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 8;
            this.btnLogOut.ImageOptions.Image = global::Cafe_Management.Properties.Resources.logout_icon;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Caption = "Tài khoản";
            this.btnViewAccount.Id = 9;
            this.btnViewAccount.ImageOptions.Image = global::Cafe_Management.Properties.Resources.User_Group_icon;
            this.btnViewAccount.LargeWidth = 75;
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Caption = "Doanh thu";
            this.btnViewBill.Id = 10;
            this.btnViewBill.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Cash_icon;
            this.btnViewBill.LargeWidth = 75;
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Caption = "Thống kê";
            this.btnStatistic.Id = 11;
            this.btnStatistic.ImageOptions.Image = global::Cafe_Management.Properties.Resources.Presentation_icon;
            this.btnStatistic.LargeWidth = 75;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 13;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao Lưu";
            this.btnBackup.Id = 14;
            this.btnBackup.LargeWidth = 75;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 15;
            this.btnRestore.LargeWidth = 75;
            this.btnRestore.Name = "btnRestore";
            // 
            // btnLog
            // 
            this.btnLog.Caption = "Nhật ký hệ thống";
            this.btnLog.Id = 16;
            this.btnLog.LargeWidth = 75;
            this.btnLog.Name = "btnLog";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Caption = "Gửi báo cáo";
            this.btnSendMail.Id = 17;
            this.btnSendMail.LargeWidth = 75;
            this.btnSendMail.Name = "btnSendMail";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroupSystem,
            this.ribbonPageGroup2});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowForm);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroupSystem
            // 
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnAccountInfo);
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroupSystem.Name = "ribbonPageGroupSystem";
            this.ribbonPageGroupSystem.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ribbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // ribbonPageManager
            // 
            this.ribbonPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCateogry,
            this.ribbonPageGroupStatictis});
            this.ribbonPageManager.Name = "ribbonPageManager";
            this.ribbonPageManager.Text = "Quản lý";
            // 
            // ribbonPageGroupCateogry
            // 
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewFood);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewCategoryFood);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewTable);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewAccount);
            this.ribbonPageGroupCateogry.Name = "ribbonPageGroupCateogry";
            this.ribbonPageGroupCateogry.Text = "Danh mục";
            // 
            // ribbonPageGroupStatictis
            // 
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.btnViewBill);
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.btnStatistic);
            this.ribbonPageGroupStatictis.Name = "ribbonPageGroupStatictis";
            this.ribbonPageGroupStatictis.Text = "Thống kê";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 592);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frMain";
            this.Text = "frMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsTextDate;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnShowForm;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewFood;
        private DevExpress.XtraBars.BarButtonItem btnViewCategoryFood;
        private DevExpress.XtraBars.BarButtonItem btnViewTable;
        private DevExpress.XtraBars.BarButtonItem btnAccountInfo;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnViewAccount;
        private DevExpress.XtraBars.BarButtonItem btnViewBill;
        private DevExpress.XtraBars.BarButtonItem btnStatistic;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnLog;
        private DevExpress.XtraBars.BarButtonItem btnSendMail;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCateogry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatictis;
    }
}