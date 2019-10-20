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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMergeTable = new DevExpress.XtraEditors.SimpleButton();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.lkedPickTable = new DevExpress.XtraEditors.LookUpEdit();
            this.spDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.spAmount = new DevExpress.XtraEditors.SpinEdit();
            this.btnChangeTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddFood = new DevExpress.XtraEditors.SimpleButton();
            this.lkedPickCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lkedPickFood = new DevExpress.XtraEditors.LookUpEdit();
            this.flpListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickFood.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnMergeTable);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.lkedPickTable);
            this.panel1.Controls.Add(this.spDiscount);
            this.panel1.Controls.Add(this.spAmount);
            this.panel1.Controls.Add(this.btnChangeTable);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.lkedPickCategory);
            this.panel1.Controls.Add(this.lkedPickFood);
            this.panel1.Location = new System.Drawing.Point(458, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 588);
            this.panel1.TabIndex = 31;
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
            // lsvBill
            // 
            this.lsvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(16, 113);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(614, 380);
            this.lsvBill.TabIndex = 42;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 134;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImage = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.Location = new System.Drawing.Point(16, 501);
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
            this.labelControl2.Location = new System.Drawing.Point(16, 544);
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
            this.labelControl1.Location = new System.Drawing.Point(159, 528);
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
            this.txtTotalPrice.Location = new System.Drawing.Point(328, 520);
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
            this.spDiscount.Location = new System.Drawing.Point(231, 524);
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
            // spAmount
            // 
            this.spAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spAmount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spAmount.Location = new System.Drawing.Point(390, 38);
            this.spAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spAmount.Name = "spAmount";
            this.spAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spAmount.Properties.Appearance.Options.UseFont = true;
            this.spAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spAmount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spAmount.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spAmount.Size = new System.Drawing.Size(57, 30);
            this.spAmount.TabIndex = 37;
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
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Appearance.Options.UseFont = true;
            this.btnCheck.Location = new System.Drawing.Point(525, 499);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(105, 79);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Thanh toán";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Appearance.Options.UseFont = true;
            this.btnAddFood.Location = new System.Drawing.Point(250, 26);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(133, 53);
            this.btnAddFood.TabIndex = 35;
            this.btnAddFood.Text = "Thêm món";
            // 
            // lkedPickCategory
            // 
            this.lkedPickCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickCategory.Location = new System.Drawing.Point(16, 17);
            this.lkedPickCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkedPickCategory.Name = "lkedPickCategory";
            this.lkedPickCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickCategory.Properties.Appearance.Options.UseFont = true;
            this.lkedPickCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickCategory.Properties.NullText = "-- Chọn danh mục --";
            this.lkedPickCategory.Size = new System.Drawing.Size(220, 30);
            this.lkedPickCategory.TabIndex = 31;
            // 
            // lkedPickFood
            // 
            this.lkedPickFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkedPickFood.Location = new System.Drawing.Point(16, 65);
            this.lkedPickFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkedPickFood.Name = "lkedPickFood";
            this.lkedPickFood.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkedPickFood.Properties.Appearance.Options.UseFont = true;
            this.lkedPickFood.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkedPickFood.Properties.NullText = "-- Chọn món --";
            this.lkedPickFood.Size = new System.Drawing.Size(220, 30);
            this.lkedPickFood.TabIndex = 32;
            // 
            // flpListTable
            // 
            this.flpListTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListTable.AutoScroll = true;
            this.flpListTable.Location = new System.Drawing.Point(12, 10);
            this.flpListTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpListTable.Name = "flpListTable";
            this.flpListTable.Size = new System.Drawing.Size(440, 588);
            this.flpListTable.TabIndex = 32;
            // 
            // frManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpListTable);
            this.Name = "frManage";
            this.Text = "frManage";
            this.Load += new System.EventHandler(this.frManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkedPickFood.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnMergeTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.LookUpEdit lkedPickTable;
        private DevExpress.XtraEditors.SpinEdit spDiscount;
        private DevExpress.XtraEditors.SpinEdit spAmount;
        private DevExpress.XtraEditors.SimpleButton btnChangeTable;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
        private DevExpress.XtraEditors.SimpleButton btnAddFood;
        private DevExpress.XtraEditors.LookUpEdit lkedPickCategory;
        private DevExpress.XtraEditors.LookUpEdit lkedPickFood;
        private System.Windows.Forms.FlowLayoutPanel flpListTable;
       
    }
}