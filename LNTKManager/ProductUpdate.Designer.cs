namespace LNTKManager
{
    partial class ProductUpdate
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txeID = new DevExpress.XtraEditors.TextEdit();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txePath = new DevExpress.XtraEditors.TextEdit();
            this.cbbCategoryId = new System.Windows.Forms.ComboBox();
            this.txePrice = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bdsCategory = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.pcbImage);
            this.layoutControl1.Controls.Add(this.txbDescription);
            this.layoutControl1.Controls.Add(this.txeName);
            this.layoutControl1.Controls.Add(this.txeID);
            this.layoutControl1.Controls.Add(this.txePath);
            this.layoutControl1.Controls.Add(this.cbbCategoryId);
            this.layoutControl1.Controls.Add(this.txePrice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(637, 408);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem10,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(637, 408);
            this.Root.TextVisible = false;
            // 
            // txeID
            // 
            this.txeID.Enabled = false;
            this.txeID.Location = new System.Drawing.Point(76, 12);
            this.txeID.Margin = new System.Windows.Forms.Padding(4);
            this.txeID.Name = "txeID";
            this.txeID.Size = new System.Drawing.Size(261, 24);
            this.txeID.StyleController = this.layoutControl1;
            this.txeID.TabIndex = 13;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(76, 68);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(261, 207);
            this.txbDescription.TabIndex = 12;
            this.txbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDescription_KeyPress);
            // 
            // txeName
            // 
            this.txeName.Location = new System.Drawing.Point(76, 40);
            this.txeName.Margin = new System.Windows.Forms.Padding(4);
            this.txeName.Name = "txeName";
            this.txeName.Size = new System.Drawing.Size(261, 24);
            this.txeName.StyleController = this.layoutControl1;
            this.txeName.TabIndex = 13;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txbDescription;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "상품설명";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(329, 211);
            this.layoutControlItem9.Text = "상품설명";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txeName;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "상품명";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(329, 28);
            this.layoutControlItem6.Text = "상품명";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txeID;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "상품명";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(329, 28);
            this.layoutControlItem8.Text = "상품ID";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 18);
            // 
            // txePath
            // 
            this.txePath.Location = new System.Drawing.Point(76, 279);
            this.txePath.Margin = new System.Windows.Forms.Padding(4);
            this.txePath.Name = "txePath";
            this.txePath.Size = new System.Drawing.Size(135, 24);
            this.txePath.StyleController = this.layoutControl1;
            this.txePath.TabIndex = 4;
            // 
            // cbbCategoryId
            // 
            this.cbbCategoryId.DataSource = this.bdsCategory;
            this.cbbCategoryId.DisplayMember = "Item";
            this.cbbCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryId.FormattingEnabled = true;
            this.cbbCategoryId.Location = new System.Drawing.Point(76, 336);
            this.cbbCategoryId.Name = "cbbCategoryId";
            this.cbbCategoryId.Size = new System.Drawing.Size(261, 23);
            this.cbbCategoryId.TabIndex = 14;
            this.cbbCategoryId.ValueMember = "CodeCategoryId";
            // 
            // txePrice
            // 
            this.txePrice.Location = new System.Drawing.Point(76, 308);
            this.txePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txePrice.Name = "txePrice";
            this.txePrice.Size = new System.Drawing.Size(261, 24);
            this.txePrice.StyleController = this.layoutControl1;
            this.txePrice.TabIndex = 10;
            this.txePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txePrice_KeyPress);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txePath;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "파일경로";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 267);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(203, 29);
            this.layoutControlItem2.Text = "파일경로";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cbbCategoryId;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "분류";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 324);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(329, 30);
            this.layoutControlItem10.Text = "분류";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txePrice;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "가격";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 296);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(329, 28);
            this.layoutControlItem7.Text = "가격";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 18);
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(341, 12);
            this.pcbImage.MinimumSize = new System.Drawing.Size(260, 260);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(284, 350);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 15;
            this.pcbImage.TabStop = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pcbImage;
            this.layoutControlItem1.Location = new System.Drawing.Point(329, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(288, 354);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 279);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 25);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "찾기(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSearch;
            this.layoutControlItem3.Location = new System.Drawing.Point(203, 267);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(126, 29);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(126, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(126, 29);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnClose;
            this.layoutControlItem4.Location = new System.Drawing.Point(473, 354);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(341, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnUpdate;
            this.layoutControlItem5.Location = new System.Drawing.Point(329, 354);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 354);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(329, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bdsCategory
            // 
            this.bdsCategory.DataSource = typeof(LNTKKiosk.Data.CodeCategory);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 408);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductUpdate";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.TextBox txbDescription;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraEditors.TextEdit txeID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txePath;
        private System.Windows.Forms.ComboBox cbbCategoryId;
        private DevExpress.XtraEditors.TextEdit txePrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pcbImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bdsCategory;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}