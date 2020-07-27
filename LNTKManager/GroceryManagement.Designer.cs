namespace LNTKManager
{
    partial class GroceryManagement
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cbbCategoryId = new System.Windows.Forms.ComboBox();
            this.txeUnit = new DevExpress.XtraEditors.TextEdit();
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnInsert = new System.Windows.Forms.Button();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsGrocery = new System.Windows.Forms.BindingSource(this.components);
            this.colGroceryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecipes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStocks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCategory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.btnInsert);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.cbbCategoryId);
            this.layoutControl1.Controls.Add(this.txeUnit);
            this.layoutControl1.Controls.Add(this.txeName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 394);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 394);
            this.Root.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsGrocery;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 337);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroceryId,
            this.colCodeCategoryId,
            this.colUnit,
            this.colItem,
            this.colCodeCategory,
            this.colRecipes,
            this.colStocks});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(429, 341);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(429, 86);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(351, 255);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 341);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(141, 33);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cbbCategoryId
            // 
            this.cbbCategoryId.DataSource = this.bdsCategory;
            this.cbbCategoryId.DisplayMember = "Item";
            this.cbbCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryId.FormattingEnabled = true;
            this.cbbCategoryId.Location = new System.Drawing.Point(505, 12);
            this.cbbCategoryId.Name = "cbbCategoryId";
            this.cbbCategoryId.Size = new System.Drawing.Size(283, 23);
            this.cbbCategoryId.TabIndex = 4;
            this.cbbCategoryId.ValueMember = "CodeCategoryId";
            // 
            // txeUnit
            // 
            this.txeUnit.Location = new System.Drawing.Point(505, 42);
            this.txeUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txeUnit.Name = "txeUnit";
            this.txeUnit.Size = new System.Drawing.Size(283, 24);
            this.txeUnit.StyleController = this.layoutControl1;
            this.txeUnit.TabIndex = 5;
            // 
            // txeName
            // 
            this.txeName.Location = new System.Drawing.Point(505, 70);
            this.txeName.Margin = new System.Windows.Forms.Padding(4);
            this.txeName.Name = "txeName";
            this.txeName.Size = new System.Drawing.Size(283, 24);
            this.txeName.StyleController = this.layoutControl1;
            this.txeName.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbCategoryId;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "카테고리";
            this.layoutControlItem2.Location = new System.Drawing.Point(429, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(351, 30);
            this.layoutControlItem2.Text = "카테고리";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeUnit;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "단위";
            this.layoutControlItem3.Location = new System.Drawing.Point(429, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(351, 28);
            this.layoutControlItem3.Text = "단위";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txeName;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "식품명";
            this.layoutControlItem4.Location = new System.Drawing.Point(429, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(351, 28);
            this.layoutControlItem4.Text = "식품명";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(504, 353);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 29);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "등록(&I)";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnInsert;
            this.layoutControlItem5.Location = new System.Drawing.Point(492, 341);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(144, 33);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(648, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(636, 341);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(144, 33);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(429, 341);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(63, 33);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDelete;
            this.layoutControlItem7.Location = new System.Drawing.Point(285, 341);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(144, 33);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnUpdate;
            this.layoutControlItem8.Location = new System.Drawing.Point(141, 341);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(144, 33);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(144, 33);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // bdsGrocery
            // 
            this.bdsGrocery.DataSource = typeof(LNTKKiosk.Data.Grocery);
            // 
            // colGroceryId
            // 
            this.colGroceryId.FieldName = "GroceryId";
            this.colGroceryId.MinWidth = 25;
            this.colGroceryId.Name = "colGroceryId";
            this.colGroceryId.Visible = true;
            this.colGroceryId.VisibleIndex = 0;
            this.colGroceryId.Width = 94;
            // 
            // colCodeCategoryId
            // 
            this.colCodeCategoryId.FieldName = "CodeCategoryId";
            this.colCodeCategoryId.MinWidth = 25;
            this.colCodeCategoryId.Name = "colCodeCategoryId";
            this.colCodeCategoryId.Visible = true;
            this.colCodeCategoryId.VisibleIndex = 1;
            this.colCodeCategoryId.Width = 94;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.MinWidth = 25;
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 94;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.MinWidth = 25;
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 3;
            this.colItem.Width = 94;
            // 
            // colCodeCategory
            // 
            this.colCodeCategory.FieldName = "CodeCategory";
            this.colCodeCategory.MinWidth = 25;
            this.colCodeCategory.Name = "colCodeCategory";
            this.colCodeCategory.Visible = true;
            this.colCodeCategory.VisibleIndex = 4;
            this.colCodeCategory.Width = 94;
            // 
            // colRecipes
            // 
            this.colRecipes.FieldName = "Recipes";
            this.colRecipes.MinWidth = 25;
            this.colRecipes.Name = "colRecipes";
            this.colRecipes.Visible = true;
            this.colRecipes.VisibleIndex = 5;
            this.colRecipes.Width = 94;
            // 
            // colStocks
            // 
            this.colStocks.FieldName = "Stocks";
            this.colStocks.MinWidth = 25;
            this.colStocks.Name = "colStocks";
            this.colStocks.Visible = true;
            this.colStocks.VisibleIndex = 6;
            this.colStocks.Width = 94;
            // 
            // bdsCategory
            // 
            this.bdsCategory.DataSource = typeof(LNTKKiosk.Data.CodeCategory);
            // 
            // GroceryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroceryManagement";
            this.Text = "GroceryManagement";
            this.Load += new System.EventHandler(this.GroceryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.ComboBox cbbCategoryId;
        private DevExpress.XtraEditors.TextEdit txeUnit;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.BindingSource bdsGrocery;
        private DevExpress.XtraGrid.Columns.GridColumn colGroceryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colRecipes;
        private DevExpress.XtraGrid.Columns.GridColumn colStocks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource bdsCategory;
    }
}