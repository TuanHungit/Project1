namespace CafeManagement.GUI
{
    partial class frNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frNhapKho));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcNhapKho = new DevExpress.XtraGrid.GridControl();
            this.gvNhapKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbNCC = new DevExpress.XtraEditors.LookUpEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuLai = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnXuatPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditTimKiem = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTimKiem.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(348, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh sách hàng hóa nhập kho";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(20, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tác vụ";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gcNhapKho);
            this.panelControl2.Location = new System.Drawing.Point(343, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(952, 585);
            this.panelControl2.TabIndex = 7;
            // 
            // gcNhapKho
            // 
            this.gcNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNhapKho.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcNhapKho.Location = new System.Drawing.Point(5, 15);
            this.gcNhapKho.MainView = this.gvNhapKho;
            this.gcNhapKho.Name = "gcNhapKho";
            this.gcNhapKho.Size = new System.Drawing.Size(942, 565);
            this.gcNhapKho.TabIndex = 0;
            this.gcNhapKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhapKho});
            this.gcNhapKho.Click += new System.EventHandler(this.gcNhapKho_Click);
            // 
            // gvNhapKho
            // 
            this.gvNhapKho.GridControl = this.gcNhapKho;
            this.gvNhapKho.Name = "gvNhapKho";
            this.gvNhapKho.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbNCC);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnLuuLai);
            this.panelControl1.Controls.Add(this.txtDonGia);
            this.panelControl1.Controls.Add(this.txtSoLuongNhap);
            this.panelControl1.Controls.Add(this.txtDonViTinh);
            this.panelControl1.Controls.Add(this.txtTenSanPham);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(325, 280);
            this.panelControl1.TabIndex = 6;
            // 
            // cbNCC
            // 
            this.cbNCC.Location = new System.Drawing.Point(140, 185);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNCC.Properties.NullText = "";
            this.cbNCC.Size = new System.Drawing.Size(164, 22);
            this.cbNCC.TabIndex = 17;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(172, 223);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 45);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuuLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuLai.ImageOptions.Image")));
            this.btnLuuLai.Location = new System.Drawing.Point(17, 223);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(129, 45);
            this.btnLuuLai.TabIndex = 15;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(140, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(164, 23);
            this.txtDonGia.TabIndex = 13;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(140, 142);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(164, 23);
            this.txtSoLuongNhap.TabIndex = 12;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(140, 64);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(164, 23);
            this.txtDonViTinh.TabIndex = 11;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(140, 23);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(164, 23);
            this.txtTenSanPham.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(13, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nhà cung cấp: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên hàng hóa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(5, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Thời gian:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(259, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 35);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.btnXuatPhieuNhap);
            this.panelControl3.Controls.Add(this.dateEditTimKiem);
            this.panelControl3.Controls.Add(this.btnTimKiem);
            this.panelControl3.Controls.Add(this.label8);
            this.panelControl3.Location = new System.Drawing.Point(12, 308);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(325, 284);
            this.panelControl3.TabIndex = 10;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // btnXuatPhieuNhap
            // 
            this.btnXuatPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuatPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPhieuNhap.ImageOptions.Image")));
            this.btnXuatPhieuNhap.Location = new System.Drawing.Point(85, 57);
            this.btnXuatPhieuNhap.Name = "btnXuatPhieuNhap";
            this.btnXuatPhieuNhap.Size = new System.Drawing.Size(168, 45);
            this.btnXuatPhieuNhap.TabIndex = 21;
            this.btnXuatPhieuNhap.Text = "Xuất phiếu nhập";
            this.btnXuatPhieuNhap.Click += new System.EventHandler(this.btnXuatPhieuNhap_Click);
            // 
            // dateEditTimKiem
            // 
            this.dateEditTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEditTimKiem.EditValue = null;
            this.dateEditTimKiem.Location = new System.Drawing.Point(85, 20);
            this.dateEditTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEditTimKiem.Name = "dateEditTimKiem";
            this.dateEditTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditTimKiem.Properties.Appearance.Options.UseFont = true;
            this.dateEditTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTimKiem.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTimKiem.Size = new System.Drawing.Size(168, 30);
            this.dateEditTimKiem.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(17, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tìm kiếm";
            // 
            // frNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frNhapKho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTimKiem.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcNhapKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhapKho;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuuLai;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnXuatPhieuNhap;
        private DevExpress.XtraEditors.DateEdit dateEditTimKiem;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.LookUpEdit cbNCC;
    }
}