namespace CafeManagement.GUI
{
    partial class frManage
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
            this.cbDanhMuc = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelCheckBan = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBan = new DevExpress.XtraEditors.PanelControl();
            this.panelBan = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listviewMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.btnChuyenBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongCong = new DevExpress.XtraEditors.TextEdit();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBan)).BeginInit();
            this.pnlBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDanhMuc.Location = new System.Drawing.Point(3, 43);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.Properties.Appearance.Options.UseFont = true;
            this.cbDanhMuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDanhMuc.Properties.NullText = "                           -- Chọn danh mục --";
            this.cbDanhMuc.Size = new System.Drawing.Size(497, 30);
            this.cbDanhMuc.TabIndex = 31;
            this.cbDanhMuc.EditValueChanged += new System.EventHandler(this.cbDanhMuc_EditValueChanged_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gcBill);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 650);
            this.panel1.TabIndex = 31;
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcBill.Location = new System.Drawing.Point(-5, 8);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(496, 642);
            this.gcBill.TabIndex = 44;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            this.gcBill.Click += new System.EventHandler(this.gcBill_Click);
            // 
            // gvBill
            // 
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsView.ShowGroupPanel = false;
            // 
            // panelCheckBan
            // 
            this.panelCheckBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCheckBan.BackgroundImage = global::CafeManagement.Properties.Resources.Check_2_icon;
            this.panelCheckBan.Location = new System.Drawing.Point(148, 37);
            this.panelCheckBan.Name = "panelCheckBan";
            this.panelCheckBan.Size = new System.Drawing.Size(25, 25);
            this.panelCheckBan.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(5, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Bàn đang chọn: ";
            // 
            // pnlBan
            // 
            this.pnlBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.pnlBan.Controls.Add(this.panelBan);
            this.pnlBan.Location = new System.Drawing.Point(12, 10);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(457, 676);
            this.pnlBan.TabIndex = 1;
            // 
            // panelBan
            // 
            this.panelBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBan.AutoScroll = true;
            this.panelBan.Location = new System.Drawing.Point(14, 16);
            this.panelBan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelBan.Name = "panelBan";
            this.panelBan.Size = new System.Drawing.Size(430, 650);
            this.panelBan.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(27, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh mục bàn";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(1002, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(520, 676);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.TabStop = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl2.Controls.Add(this.panel2);
            this.panelControl2.Location = new System.Drawing.Point(479, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(517, 457);
            this.panelControl2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listviewMenu);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtTenSanPham);
            this.panel2.Controls.Add(this.cbDanhMuc);
            this.panel2.Location = new System.Drawing.Point(6, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 438);
            this.panel2.TabIndex = 4;
            // 
            // listviewMenu
            // 
            this.listviewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewMenu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewMenu.GridLines = true;
            this.listviewMenu.HideSelection = false;
            this.listviewMenu.Location = new System.Drawing.Point(0, 76);
            this.listviewMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.Size = new System.Drawing.Size(500, 361);
            this.listviewMenu.TabIndex = 43;
            this.listviewMenu.UseCompatibleStateImageBehavior = false;
            this.listviewMenu.View = System.Windows.Forms.View.Details;
            this.listviewMenu.Click += new System.EventHandler(this.listviewMenu_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 165;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = global::CafeManagement.Properties.Resources.search_icon__1_;
            this.btnSearch.Location = new System.Drawing.Point(412, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 33);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSanPham.Location = new System.Drawing.Point(188, 9);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.txtTenSanPham.Properties.NullText = "   -- Tên Sản Phẩm --";
            this.txtTenSanPham.Size = new System.Drawing.Size(218, 30);
            this.txtTenSanPham.TabIndex = 35;
            this.txtTenSanPham.Click += new System.EventHandler(this.txtTenSanPham_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(1013, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Danh mục hóa đơn";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(494, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Danh mục Menu";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(125, 76);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.AutoHeight = false;
            this.txtThanhTien.Size = new System.Drawing.Size(205, 31);
            this.txtThanhTien.TabIndex = 39;
            // 
            // spDiscount
            // 
            this.spDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDiscount.Location = new System.Drawing.Point(124, 111);
            this.spDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spDiscount.Name = "spDiscount";
            this.spDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spDiscount.Properties.Appearance.Options.UseFont = true;
            this.spDiscount.Properties.AutoHeight = false;
            this.spDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDiscount.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spDiscount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spDiscount.Size = new System.Drawing.Size(206, 26);
            this.spDiscount.TabIndex = 36;
            this.spDiscount.EditValueChanged += new System.EventHandler(this.spDiscount_EditValueChanged);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuyenBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Appearance.Options.UseFont = true;
            this.btnChuyenBan.ImageOptions.Image = global::CafeManagement.Properties.Resources._switch;
            this.btnChuyenBan.Location = new System.Drawing.Point(224, 20);
            this.btnChuyenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(106, 52);
            this.btnChuyenBan.TabIndex = 33;
            this.btnChuyenBan.Text = "Chuyển";
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Appearance.Options.UseFont = true;
            this.btnThemMon.Appearance.Options.UseForeColor = true;
            this.btnThemMon.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemMon.Location = new System.Drawing.Point(340, 20);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(157, 52);
            this.btnThemMon.TabIndex = 35;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 112);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 23);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Giảm giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 21);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Thành tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 23);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Tổng cộng";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Location = new System.Drawing.Point(124, 140);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.Properties.Appearance.Options.UseFont = true;
            this.txtTongCong.Properties.AutoHeight = false;
            this.txtTongCong.Size = new System.Drawing.Size(206, 31);
            this.txtTongCong.TabIndex = 46;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ImageOptions.Image = global::CafeManagement.Properties.Resources.payment_method__1_;
            this.btnThanhToan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(340, 83);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(157, 91);
            this.btnThanhToan.TabIndex = 34;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.labelBan);
            this.panelControl3.Controls.Add(this.btnThemMon);
            this.panelControl3.Controls.Add(this.panelCheckBan);
            this.panelControl3.Controls.Add(this.btnThanhToan);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.txtTongCong);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btnChuyenBan);
            this.panelControl3.Controls.Add(this.spDiscount);
            this.panelControl3.Controls.Add(this.txtThanhTien);
            this.panelControl3.Location = new System.Drawing.Point(479, 485);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(517, 198);
            this.panelControl3.TabIndex = 48;
            // 
            // labelBan
            // 
            this.labelBan.Location = new System.Drawing.Point(176, 38);
            this.labelBan.Name = "labelBan";
            this.labelBan.Size = new System.Drawing.Size(44, 23);
            this.labelBan.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(487, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Danh mục tác vụ";
            // 
            // frManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 695);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlBan);
            this.Name = "frManage";
            this.Text = "Trang bán hàng";
            this.Load += new System.EventHandler(this.frManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBan)).EndInit();
            this.pnlBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit cbDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraEditors.PanelControl pnlBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelBan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.SpinEdit spDiscount;
        private DevExpress.XtraEditors.SimpleButton btnChuyenBan;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTongCong;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listviewMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panelCheckBan;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private System.Windows.Forms.TextBox labelBan;
    }
}