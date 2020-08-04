namespace LNTKManager
{
    partial class RecipeUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbbProductId = new System.Windows.Forms.ComboBox();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.cbbGroceryId = new System.Windows.Forms.ComboBox();
            this.bdsGrocery = new System.Windows.Forms.BindingSource(this.components);
            this.txeAmount = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txePath = new System.Windows.Forms.TextBox();
            this.파일경로 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.파일경로)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.pcbImage);
            this.layoutControl1.Controls.Add(this.txePath);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.cbbProductId);
            this.layoutControl1.Controls.Add(this.cbbGroceryId);
            this.layoutControl1.Controls.Add(this.txeAmount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(514, 288);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(253, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbbProductId
            // 
            this.cbbProductId.DataSource = this.bdsProduct;
            this.cbbProductId.DisplayMember = "Name";
            this.cbbProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductId.Enabled = false;
            this.cbbProductId.FormattingEnabled = true;
            this.cbbProductId.Location = new System.Drawing.Point(67, 12);
            this.cbbProductId.Name = "cbbProductId";
            this.cbbProductId.Size = new System.Drawing.Size(326, 23);
            this.cbbProductId.TabIndex = 2;
            this.cbbProductId.ValueMember = "ProductId";
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(LNTKKiosk.Data.Product);
            // 
            // cbbGroceryId
            // 
            this.cbbGroceryId.DataSource = this.bdsGrocery;
            this.cbbGroceryId.DisplayMember = "Item";
            this.cbbGroceryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGroceryId.FormattingEnabled = true;
            this.cbbGroceryId.Location = new System.Drawing.Point(67, 42);
            this.cbbGroceryId.Name = "cbbGroceryId";
            this.cbbGroceryId.Size = new System.Drawing.Size(326, 23);
            this.cbbGroceryId.TabIndex = 3;
            this.cbbGroceryId.ValueMember = "GroceryId";
            // 
            // bdsGrocery
            // 
            this.bdsGrocery.DataSource = typeof(LNTKKiosk.Data.Grocery);
            // 
            // txeAmount
            // 
            this.txeAmount.Location = new System.Drawing.Point(67, 72);
            this.txeAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txeAmount.Name = "txeAmount";
            this.txeAmount.Size = new System.Drawing.Size(326, 24);
            this.txeAmount.StyleController = this.layoutControl1;
            this.txeAmount.TabIndex = 4;
            this.txeAmount.EditValueChanged += new System.EventHandler(this.txeAmount_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.파일경로,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(514, 288);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbProductId;
            this.layoutControlItem1.CustomizationFormText = "상품";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(385, 30);
            this.layoutControlItem1.Text = "상품";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbGroceryId;
            this.layoutControlItem2.CustomizationFormText = "재료";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(385, 30);
            this.layoutControlItem2.Text = "재료";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeAmount;
            this.layoutControlItem3.CustomizationFormText = "개수";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(385, 28);
            this.layoutControlItem3.Text = "개수";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 117);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(385, 117);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnClose;
            this.layoutControlItem4.Location = new System.Drawing.Point(241, 234);
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
            this.layoutControlItem5.Control = this.btnUpdate;
            this.layoutControlItem5.Location = new System.Drawing.Point(97, 234);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 234);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(97, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txePath
            // 
            this.txePath.Location = new System.Drawing.Point(67, 100);
            this.txePath.Name = "txePath";
            this.txePath.Size = new System.Drawing.Size(213, 25);
            this.txePath.TabIndex = 7;
            // 
            // 파일경로
            // 
            this.파일경로.Control = this.txePath;
            this.파일경로.Location = new System.Drawing.Point(0, 88);
            this.파일경로.Name = "파일경로";
            this.파일경로.Size = new System.Drawing.Size(272, 29);
            this.파일경로.TextSize = new System.Drawing.Size(52, 18);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(397, 12);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(105, 264);
            this.pcbImage.TabIndex = 8;
            this.pcbImage.TabStop = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.pcbImage;
            this.layoutControlItem7.Location = new System.Drawing.Point(385, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(109, 268);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(284, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "찾기(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSearch;
            this.layoutControlItem6.Location = new System.Drawing.Point(272, 88);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(113, 29);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // RecipeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 288);
            this.Controls.Add(this.layoutControl1);
            this.Name = "RecipeUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "레시피수정";
            this.Load += new System.EventHandler(this.RecipeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.파일경로)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbbGroceryId;
        private DevExpress.XtraEditors.TextEdit txeAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource bdsGrocery;
        private System.Windows.Forms.ComboBox cbbProductId;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.TextBox txePath;
        private DevExpress.XtraLayout.LayoutControlItem 파일경로;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}