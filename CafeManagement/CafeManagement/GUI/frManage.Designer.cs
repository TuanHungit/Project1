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
            this.btnMergeTable = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkedPickTable = new DevExpress.XtraEditors.LookUpEdit();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.spSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.btnChangeTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.cbDanhMuc = new DevExpress.XtraEditors.LookUpEdit();
            this.cbSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.panelListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeTable.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTable.Appearance.Options.UseFont = true;
            this.btnMergeTable.Location = new System.Drawing.Point(464, 11);
            this.btnMergeTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(77, 42);
            this.btnMergeTable.TabIndex = 43;
            this.btnMergeTable.Text = "Gộp";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(16, 550);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 23);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Đang chọn";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImage = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.Location = new System.Drawing.Point(16, 593);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 23);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Có người";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(159, 577);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 23);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Giảm giá";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(328, 569);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(180, 36);
            this.txtTotalPrice.TabIndex = 39;
            // 
            // lkedPickTable
            // 
            this.lkedPickTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickTable.Location = new System.Drawing.Point(464, 60);
            this.lkedPickTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkedPickTable.Name = "lkedPickTable";
            this.lkedPickTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickTable.Properties.Appearance.Options.UseFont = true;
            this.lkedPickTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickTable.Properties.NullText = "-- Chọn bàn --";
            this.lkedPickTable.Size = new System.Drawing.Size(166, 30);
            this.lkedPickTable.TabIndex = 38;
            // 
            // spDiscount
            // 
            this.spDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDiscount.Location = new System.Drawing.Point(231, 573);
            this.spDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spDiscount.Name = "spDiscount";
            this.spDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spDiscount.Properties.Appearance.Options.UseFont = true;
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
            this.spDiscount.Size = new System.Drawing.Size(79, 30);
            this.spDiscount.TabIndex = 36;
            // 
            // spSoLuong
            // 
            this.spSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spSoLuong.Location = new System.Drawing.Point(390, 38);
            this.spSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spSoLuong.Name = "spSoLuong";
            this.spSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spSoLuong.Properties.Appearance.Options.UseFont = true;
            this.spSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoLuong.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spSoLuong.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spSoLuong.Size = new System.Drawing.Size(57, 30);
            this.spSoLuong.TabIndex = 37;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTable.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTable.Appearance.Options.UseFont = true;
            this.btnChangeTable.Location = new System.Drawing.Point(553, 11);
            this.btnChangeTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(77, 42);
            this.btnChangeTable.TabIndex = 33;
            this.btnChangeTable.Text = "Chuyển";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Location = new System.Drawing.Point(525, 548);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(105, 79);
            this.btnThanhToan.TabIndex = 34;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Appearance.Options.UseFont = true;
            this.btnThemMon.Appearance.Options.UseForeColor = true;
            this.btnThemMon.Location = new System.Drawing.Point(250, 26);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(133, 53);
            this.btnThemMon.TabIndex = 35;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDanhMuc.Location = new System.Drawing.Point(16, 17);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.Properties.Appearance.Options.UseFont = true;
            this.cbDanhMuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDanhMuc.Properties.NullText = "-- Chọn danh mục --";
            this.cbDanhMuc.Size = new System.Drawing.Size(220, 30);
            this.cbDanhMuc.TabIndex = 31;
            this.cbDanhMuc.EditValueChanged += new System.EventHandler(this.cbDanhMuc_EditValueChanged_1);
            // 
            // cbSanPham
            // 
            this.cbSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSanPham.Location = new System.Drawing.Point(16, 65);
            this.cbSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanPham.Properties.Appearance.Options.UseFont = true;
            this.cbSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSanPham.Properties.NullText = "-- Chọn món --";
            this.cbSanPham.Size = new System.Drawing.Size(220, 30);
            this.cbSanPham.TabIndex = 32;
            // 
            // panelListTable
            // 
            this.panelListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListTable.AutoScroll = true;
            this.panelListTable.Location = new System.Drawing.Point(29, 30);
            this.panelListTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelListTable.Name = "panelListTable";
            this.panelListTable.Size = new System.Drawing.Size(486, 596);
            this.panelListTable.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gcBill);
            this.panel1.Controls.Add(this.btnMergeTable);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.lkedPickTable);
            this.panel1.Controls.Add(this.spDiscount);
            this.panel1.Controls.Add(this.spSoLuong);
            this.panel1.Controls.Add(this.btnChangeTable);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.cbDanhMuc);
            this.panel1.Controls.Add(this.cbSanPham);
            this.panel1.Location = new System.Drawing.Point(535, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 637);
            this.panel1.TabIndex = 31;
            // 
            // gcBill
            // 
            this.gcBill.Location = new System.Drawing.Point(16, 118);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(614, 396);
            this.gcBill.TabIndex = 44;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsView.ShowGroupPanel = false;
            // 
            // frManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListTable);
            this.Name = "frManage";
            this.Text = "Trang bán hàng";
            this.Load += new System.EventHandler(this.frManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSanPham.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnMergeTable;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.LookUpEdit lkedPickTable;
        private DevExpress.XtraEditors.SpinEdit spDiscount;
        private DevExpress.XtraEditors.SpinEdit spSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnChangeTable;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private DevExpress.XtraEditors.LookUpEdit cbDanhMuc;
        private DevExpress.XtraEditors.LookUpEdit cbSanPham;
        private System.Windows.Forms.FlowLayoutPanel panelListTable;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
    }
}