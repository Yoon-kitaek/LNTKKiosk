namespace LNTKManager
{
    partial class StockInsert
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txePrice = new DevExpress.XtraEditors.TextEdit();
            this.txeExpirationDate = new DevExpress.XtraEditors.TextEdit();
            this.txeReceivedDate = new DevExpress.XtraEditors.TextEdit();
            this.cbbGroceryId = new System.Windows.Forms.ComboBox();
            this.bdsGrocery = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeReceivedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnInsert);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txePrice);
            this.layoutControl1.Controls.Add(this.txeExpirationDate);
            this.layoutControl1.Controls.Add(this.txeReceivedDate);
            this.layoutControl1.Controls.Add(this.cbbGroceryId);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(370, 213);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(74, 171);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 30);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "등록(&I)";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txePrice
            // 
            this.txePrice.Location = new System.Drawing.Point(67, 98);
            this.txePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txePrice.Name = "txePrice";
            this.txePrice.Size = new System.Drawing.Size(291, 24);
            this.txePrice.StyleController = this.layoutControl1;
            this.txePrice.TabIndex = 7;
            this.txePrice.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txePrice_EditValueChanging);
            // 
            // txeExpirationDate
            // 
            this.txeExpirationDate.Location = new System.Drawing.Point(67, 70);
            this.txeExpirationDate.Margin = new System.Windows.Forms.Padding(4);
            this.txeExpirationDate.Name = "txeExpirationDate";
            this.txeExpirationDate.Size = new System.Drawing.Size(291, 24);
            this.txeExpirationDate.StyleController = this.layoutControl1;
            this.txeExpirationDate.TabIndex = 6;
            this.txeExpirationDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txeExpirationDate_EditValueChanging);
            // 
            // txeReceivedDate
            // 
            this.txeReceivedDate.Location = new System.Drawing.Point(67, 42);
            this.txeReceivedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txeReceivedDate.Name = "txeReceivedDate";
            this.txeReceivedDate.Size = new System.Drawing.Size(291, 24);
            this.txeReceivedDate.StyleController = this.layoutControl1;
            this.txeReceivedDate.TabIndex = 5;
            this.txeReceivedDate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txeReceivedDate_EditValueChanging);
            this.txeReceivedDate.Leave += new System.EventHandler(this.txeReceivedDate_Leave);
            // 
            // cbbGroceryId
            // 
            this.cbbGroceryId.DataSource = this.bdsGrocery;
            this.cbbGroceryId.DisplayMember = "Item";
            this.cbbGroceryId.FormattingEnabled = true;
            this.cbbGroceryId.Location = new System.Drawing.Point(67, 12);
            this.cbbGroceryId.Name = "cbbGroceryId";
            this.cbbGroceryId.Size = new System.Drawing.Size(291, 23);
            this.cbbGroceryId.TabIndex = 4;
            this.cbbGroceryId.ValueMember = "GroceryId";
            // 
            // bdsGrocery
            // 
            this.bdsGrocery.DataSource = typeof(LNTKKiosk.Data.Grocery);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 213);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbGroceryId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 30);
            this.layoutControlItem1.Text = "식재료명";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(350, 45);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txeReceivedDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 28);
            this.layoutControlItem2.Text = "입고날짜";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeExpirationDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 28);
            this.layoutControlItem3.Text = "유효기간";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txePrice;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 28);
            this.layoutControlItem4.Text = "가격";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnClose;
            this.layoutControlItem5.Location = new System.Drawing.Point(206, 159);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnInsert;
            this.layoutControlItem6.Location = new System.Drawing.Point(62, 159);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 159);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(62, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // StockInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 213);
            this.Controls.Add(this.layoutControl1);
            this.Name = "StockInsert";
            this.Text = "StockInsert";
            this.Load += new System.EventHandler(this.StockInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeReceivedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.ComboBox cbbGroceryId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.TextEdit txePrice;
        private DevExpress.XtraEditors.TextEdit txeExpirationDate;
        private DevExpress.XtraEditors.TextEdit txeReceivedDate;
        private System.Windows.Forms.BindingSource bdsGrocery;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}