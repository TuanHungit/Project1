namespace CafeManagement.GUI
{
    partial class frDanhMuc
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.txtTenDanhMuc = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = global::CafeManagement.Properties.Resources.search_icon__1_;
            this.btnSearch.Location = new System.Drawing.Point(1138, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 33);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnXoa,
            this.barButtonItem1,
            this.barButtonThem,
            this.barButtonXoa,
            this.barButtonSua,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar6;
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1454, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1454, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 463);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1454, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 463);
            // 
            // barbtnXoa
            // 
            this.barbtnXoa.Caption = "Xóa";
            this.barbtnXoa.Id = 0;
            this.barbtnXoa.ImageOptions.Image = global::CafeManagement.Properties.Resources.Close_2_icon;
            this.barbtnXoa.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.barbtnXoa.Name = "barbtnXoa";
            this.barbtnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnXoa.Size = new System.Drawing.Size(70, 0);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonThem
            // 
            this.barButtonThem.Caption = "Thêm";
            this.barButtonThem.Id = 2;
            this.barButtonThem.ImageOptions.Image = global::CafeManagement.Properties.Resources.add_icon;
            this.barButtonThem.Name = "barButtonThem";
            this.barButtonThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonXoa
            // 
            this.barButtonXoa.Caption = "Xóa";
            this.barButtonXoa.Id = 3;
            this.barButtonXoa.ImageOptions.Image = global::CafeManagement.Properties.Resources.Close_2_icon;
            this.barButtonXoa.Name = "barButtonXoa";
            this.barButtonXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonSua
            // 
            this.barButtonSua.Caption = "Sửa";
            this.barButtonSua.Id = 4;
            this.barButtonSua.ImageOptions.Image = global::CafeManagement.Properties.Resources.Reset_icon;
            this.barButtonSua.Name = "barButtonSua";
            this.barButtonSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Reset ";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = global::CafeManagement.Properties.Resources.Button_Refresh_icon;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(893, 9);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Properties.Appearance.Options.UseFont = true;
            this.txtTenDanhMuc.Properties.NullText = "   --Tìm Tên Danh Mục --";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(243, 30);
            this.txtTenDanhMuc.TabIndex = 30;
            this.txtTenDanhMuc.Click += new System.EventHandler(this.txtTenDanhMuc_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gcDanhMuc);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.txtTenDanhMuc);
            this.panelControl1.Location = new System.Drawing.Point(183, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1259, 435);
            this.panelControl1.TabIndex = 40;
            // 
            // gcDanhMuc
            // 
            this.gcDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMuc.Location = new System.Drawing.Point(9, 46);
            this.gcDanhMuc.MainView = this.gvDanhMuc;
            this.gcDanhMuc.MenuManager = this.barManager1;
            this.gcDanhMuc.Name = "gcDanhMuc";
            this.gcDanhMuc.Size = new System.Drawing.Size(1245, 384);
            this.gcDanhMuc.TabIndex = 35;
            this.gcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.GridControl = this.gcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhMuc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhMuc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhMuc.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gvDanhMuc.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvDanhMuc.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.gvDanhMuc.Click += new System.EventHandler(this.gvDanhMuc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Danh sách danh mục";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl2.Controls.Add(this.txtTen);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnSua);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Location = new System.Drawing.Point(12, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(165, 435);
            this.panelControl2.TabIndex = 46;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.ImageOptions.Image = global::CafeManagement.Properties.Resources.reload;
            this.btnRefresh.Location = new System.Drawing.Point(16, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 86);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::CafeManagement.Properties.Resources.icon;
            this.btnSua.Location = new System.Drawing.Point(16, 241);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 86);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::CafeManagement.Properties.Resources.rubbish_bin_delete_button;
            this.btnXoa.Location = new System.Drawing.Point(16, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 86);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::CafeManagement.Properties.Resources.adding1;
            this.btnThem.Location = new System.Drawing.Point(16, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 86);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Danh sách tác vụ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(16, 18);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(134, 23);
            this.txtTen.TabIndex = 35;
            // 
            // frDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frDanhMuc";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barbtnXoa;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonThem;
        private DevExpress.XtraBars.BarButtonItem barButtonXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonSua;
        private DevExpress.XtraEditors.TextEdit txtTenDanhMuc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
    }
}