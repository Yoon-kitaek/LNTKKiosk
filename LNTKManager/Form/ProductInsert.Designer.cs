namespace LNTKManager
{
    partial class ProductInsert
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
            this.cbbCategoryId = new System.Windows.Forms.ComboBox();
            this.bdsCategory = new System.Windows.Forms.BindingSource(this.components);
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txePrice = new DevExpress.XtraEditors.TextEdit();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txePath = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbCategoryId);
            this.layoutControl1.Controls.Add(this.txeName);
            this.layoutControl1.Controls.Add(this.txbDescription);
            this.layoutControl1.Controls.Add(this.txePrice);
            this.layoutControl1.Controls.Add(this.pcbImage);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.txePath);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(637, 398);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbCategoryId
            // 
            this.cbbCategoryId.DataSource = this.bdsCategory;
            this.cbbCategoryId.DisplayMember = "Item";
            this.cbbCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryId.FormattingEnabled = true;
            this.cbbCategoryId.Location = new System.Drawing.Point(67, 326);
            this.cbbCategoryId.Name = "cbbCategoryId";
            this.cbbCategoryId.Size = new System.Drawing.Size(270, 23);
            this.cbbCategoryId.TabIndex = 14;
            this.cbbCategoryId.ValueMember = "CodeCategoryId";
            // 
            // bdsCategory
            // 
            this.bdsCategory.DataSource = typeof(LNTKKiosk.Data.CodeCategory);
            // 
            // txeName
            // 
            this.txeName.Location = new System.Drawing.Point(67, 12);
            this.txeName.Margin = new System.Windows.Forms.Padding(4);
            this.txeName.Name = "txeName";
            this.txeName.Size = new System.Drawing.Size(270, 24);
            this.txeName.StyleController = this.layoutControl1;
            this.txeName.TabIndex = 13;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(67, 40);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(270, 225);
            this.txbDescription.TabIndex = 12;
            this.txbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDescription_KeyPress);
            // 
            // txePrice
            // 
            this.txePrice.Location = new System.Drawing.Point(67, 298);
            this.txePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txePrice.Name = "txePrice";
            this.txePrice.Size = new System.Drawing.Size(270, 24);
            this.txePrice.StyleController = this.layoutControl1;
            this.txePrice.TabIndex = 10;
            this.txePrice.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txePrice_EditValueChanging);
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(341, 12);
            this.pcbImage.MinimumSize = new System.Drawing.Size(260, 260);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(284, 340);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 8;
            this.pcbImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(341, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "저장(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "찾기(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txePath
            // 
            this.txePath.Location = new System.Drawing.Point(67, 269);
            this.txePath.Margin = new System.Windows.Forms.Padding(4);
            this.txePath.Name = "txePath";
            this.txePath.Size = new System.Drawing.Size(134, 24);
            this.txePath.StyleController = this.layoutControl1;
            this.txePath.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem10,
            this.layoutControlItem7,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(637, 398);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnClose;
            this.layoutControlItem3.Location = new System.Drawing.Point(473, 344);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(329, 344);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pcbImage;
            this.layoutControlItem5.Location = new System.Drawing.Point(329, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(288, 344);
            this.layoutControlItem5.Text = "미리보기";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txbDescription;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(329, 229);
            this.layoutControlItem9.Text = "상품설명";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txeName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(329, 28);
            this.layoutControlItem6.Text = "상품명";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txePath;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 257);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(193, 29);
            this.layoutControlItem1.Text = "파일경로";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(193, 257);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(136, 29);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(136, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(136, 29);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cbbCategoryId;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 314);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(329, 30);
            this.layoutControlItem10.Text = "분류";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txePrice;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 286);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(329, 28);
            this.layoutControlItem7.Text = "가격";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 344);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(329, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 398);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInsert";
            this.Load += new System.EventHandler(this.ProductInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.TextEdit txePath;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txePrice;
        private System.Windows.Forms.PictureBox pcbImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.TextBox txbDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.ComboBox cbbCategoryId;
        private System.Windows.Forms.BindingSource bdsCategory;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}