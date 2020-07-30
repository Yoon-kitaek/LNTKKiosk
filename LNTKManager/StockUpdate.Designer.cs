namespace LNTKManager
{
    partial class StockUpdate
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txeExhustedDate = new DevExpress.XtraEditors.TextEdit();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txeStockId = new DevExpress.XtraEditors.TextEdit();
            this.cbbGroceryId = new System.Windows.Forms.ComboBox();
            this.bdsGrocery = new System.Windows.Forms.BindingSource(this.components);
            this.txeReceivedDate = new DevExpress.XtraEditors.TextEdit();
            this.txeExpirationDate = new DevExpress.XtraEditors.TextEdit();
            this.txePrice = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeExhustedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeReceivedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txeExhustedDate);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txeStockId);
            this.layoutControl1.Controls.Add(this.cbbGroceryId);
            this.layoutControl1.Controls.Add(this.txeReceivedDate);
            this.layoutControl1.Controls.Add(this.txeExpirationDate);
            this.layoutControl1.Controls.Add(this.txePrice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(387, 248);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txeExhustedDate
            // 
            this.txeExhustedDate.Location = new System.Drawing.Point(67, 126);
            this.txeExhustedDate.Name = "txeExhustedDate";
            this.txeExhustedDate.Size = new System.Drawing.Size(308, 24);
            this.txeExhustedDate.StyleController = this.layoutControl1;
            this.txeExhustedDate.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txeStockId
            // 
            this.txeStockId.Location = new System.Drawing.Point(67, 12);
            this.txeStockId.Name = "txeStockId";
            this.txeStockId.Size = new System.Drawing.Size(308, 24);
            this.txeStockId.StyleController = this.layoutControl1;
            this.txeStockId.TabIndex = 4;
            // 
            // cbbGroceryId
            // 
            this.cbbGroceryId.DataSource = this.bdsGrocery;
            this.cbbGroceryId.DisplayMember = "Item";
            this.cbbGroceryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroceryId.FormattingEnabled = true;
            this.cbbGroceryId.Location = new System.Drawing.Point(67, 40);
            this.cbbGroceryId.Name = "cbbGroceryId";
            this.cbbGroceryId.Size = new System.Drawing.Size(308, 23);
            this.cbbGroceryId.TabIndex = 4;
            this.cbbGroceryId.ValueMember = "GroceryId";
            // 
            // bdsGrocery
            // 
            this.bdsGrocery.DataSource = typeof(LNTKKiosk.Data.Grocery);
            // 
            // txeReceivedDate
            // 
            this.txeReceivedDate.Location = new System.Drawing.Point(67, 70);
            this.txeReceivedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txeReceivedDate.Name = "txeReceivedDate";
            this.txeReceivedDate.Size = new System.Drawing.Size(308, 24);
            this.txeReceivedDate.StyleController = this.layoutControl1;
            this.txeReceivedDate.TabIndex = 5;
            // 
            // txeExpirationDate
            // 
            this.txeExpirationDate.Location = new System.Drawing.Point(67, 98);
            this.txeExpirationDate.Margin = new System.Windows.Forms.Padding(4);
            this.txeExpirationDate.Name = "txeExpirationDate";
            this.txeExpirationDate.Size = new System.Drawing.Size(308, 24);
            this.txeExpirationDate.StyleController = this.layoutControl1;
            this.txeExpirationDate.TabIndex = 6;
            // 
            // txePrice
            // 
            this.txePrice.Location = new System.Drawing.Point(67, 154);
            this.txePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txePrice.Name = "txePrice";
            this.txePrice.Size = new System.Drawing.Size(308, 24);
            this.txePrice.StyleController = this.layoutControl1;
            this.txePrice.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(387, 248);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeStockId;
            this.layoutControlItem1.Enabled = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem1.Text = "재고ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbGroceryId;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "식재료명";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(367, 30);
            this.layoutControlItem2.Text = "식재료명";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeReceivedDate;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "입고날짜";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem3.Text = "입고날짜";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txeExpirationDate;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "유효기간";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem4.Text = "유효기간";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txePrice;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "가격";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem5.Text = "가격";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(367, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(223, 194);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnUpdate;
            this.layoutControlItem7.Location = new System.Drawing.Point(79, 194);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 194);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(79, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txeExhustedDate;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem8.Text = "소진날짜";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 18);
            // 
            // StockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 248);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StockUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "재고수정";
            this.Load += new System.EventHandler(this.StockUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeExhustedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeReceivedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txeStockId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ComboBox cbbGroceryId;
        private DevExpress.XtraEditors.TextEdit txeReceivedDate;
        private DevExpress.XtraEditors.TextEdit txeExpirationDate;
        private DevExpress.XtraEditors.TextEdit txePrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource bdsGrocery;
        private DevExpress.XtraEditors.TextEdit txeExhustedDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}