namespace CafeManagement.GUI
{
    partial class frChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frChuyenBan));
            this.btnChuyenAllMon1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoadon1 = new System.Windows.Forms.TextBox();
            this.txtHoaDon2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gcBill1 = new DevExpress.XtraGrid.GridControl();
            this.gvBill1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcBill2 = new DevExpress.XtraGrid.GridControl();
            this.gvBill2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbBan1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cbBan2 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnChuyenAllMon2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChuyenAllMon1
            // 
            this.btnChuyenAllMon1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenAllMon1.ImageOptions.Image")));
            this.btnChuyenAllMon1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChuyenAllMon1.Location = new System.Drawing.Point(513, 142);
            this.btnChuyenAllMon1.Name = "btnChuyenAllMon1";
            this.btnChuyenAllMon1.Size = new System.Drawing.Size(84, 47);
            this.btnChuyenAllMon1.TabIndex = 3;
            this.btnChuyenAllMon1.Text = ">>";
            this.btnChuyenAllMon1.Click += new System.EventHandler(this.btnChuyenAllMon1_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(513, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 47);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn: ";
            // 
            // txtHoadon1
            // 
            this.txtHoadon1.Location = new System.Drawing.Point(210, 17);
            this.txtHoadon1.Multiline = true;
            this.txtHoadon1.Name = "txtHoadon1";
            this.txtHoadon1.Size = new System.Drawing.Size(133, 22);
            this.txtHoadon1.TabIndex = 2;
            // 
            // txtHoaDon2
            // 
            this.txtHoaDon2.Location = new System.Drawing.Point(827, 17);
            this.txtHoaDon2.Multiline = true;
            this.txtHoaDon2.Name = "txtHoaDon2";
            this.txtHoaDon2.Size = new System.Drawing.Size(133, 22);
            this.txtHoaDon2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bàn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // gcBill1
            // 
            this.gcBill1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcBill1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcBill1.Location = new System.Drawing.Point(11, 89);
            this.gcBill1.MainView = this.gvBill1;
            this.gcBill1.Name = "gcBill1";
            this.gcBill1.Size = new System.Drawing.Size(496, 470);
            this.gcBill1.TabIndex = 45;
            this.gcBill1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill1});
            this.gcBill1.Click += new System.EventHandler(this.gcBill1_Click);
            // 
            // gvBill1
            // 
            this.gvBill1.GridControl = this.gcBill1;
            this.gvBill1.Name = "gvBill1";
            this.gvBill1.OptionsView.ShowGroupPanel = false;
            // 
            // gcBill2
            // 
            this.gcBill2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcBill2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gcBill2.Location = new System.Drawing.Point(603, 89);
            this.gcBill2.MainView = this.gvBill2;
            this.gcBill2.Name = "gcBill2";
            this.gcBill2.Size = new System.Drawing.Size(496, 470);
            this.gcBill2.TabIndex = 46;
            this.gcBill2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill2});
            // 
            // gvBill2
            // 
            this.gvBill2.GridControl = this.gcBill2;
            this.gvBill2.Name = "gvBill2";
            this.gvBill2.OptionsView.ShowGroupPanel = false;
            // 
            // cbBan1
            // 
            this.cbBan1.Location = new System.Drawing.Point(211, 52);
            this.cbBan1.Name = "cbBan1";
            this.cbBan1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBan1.Properties.NullText = "";
            this.cbBan1.Size = new System.Drawing.Size(132, 22);
            this.cbBan1.TabIndex = 47;
            this.cbBan1.EditValueChanged += new System.EventHandler(this.cbBan1_EditValueChanged);
            // 
            // cbBan2
            // 
            this.cbBan2.Location = new System.Drawing.Point(827, 50);
            this.cbBan2.Name = "cbBan2";
            this.cbBan2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBan2.Properties.NullText = "";
            this.cbBan2.Size = new System.Drawing.Size(132, 22);
            this.cbBan2.TabIndex = 48;
            this.cbBan2.EditValueChanged += new System.EventHandler(this.cbBan2_EditValueChanged);
            // 
            // btnChuyenAllMon2
            // 
            this.btnChuyenAllMon2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenAllMon2.ImageOptions.Image")));
            this.btnChuyenAllMon2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChuyenAllMon2.Location = new System.Drawing.Point(513, 89);
            this.btnChuyenAllMon2.Name = "btnChuyenAllMon2";
            this.btnChuyenAllMon2.Size = new System.Drawing.Size(84, 47);
            this.btnChuyenAllMon2.TabIndex = 5;
            this.btnChuyenAllMon2.Click += new System.EventHandler(this.btnChuyenAllMon2_Click);
            // 
            // frChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 571);
            this.Controls.Add(this.cbBan2);
            this.Controls.Add(this.cbBan1);
            this.Controls.Add(this.gcBill2);
            this.Controls.Add(this.gcBill1);
            this.Controls.Add(this.txtHoaDon2);
            this.Controls.Add(this.btnChuyenAllMon1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChuyenAllMon2);
            this.Controls.Add(this.txtHoadon1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frChuyenBan";
            this.Text = "Chuyển bàn";
            this.Load += new System.EventHandler(this.frChuyenBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoadon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoaDon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnChuyenAllMon1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.GridControl gcBill1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill1;
        private DevExpress.XtraGrid.GridControl gcBill2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill2;
        private DevExpress.XtraEditors.LookUpEdit cbBan1;
        private DevExpress.XtraEditors.LookUpEdit cbBan2;
        private DevExpress.XtraEditors.SimpleButton btnChuyenAllMon2;
    }
}