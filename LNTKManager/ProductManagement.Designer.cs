namespace LNTKManager
{
    partial class ProductManagement
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEventPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventProducts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecipes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsProduct;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(LNTKKiosk.Data.Product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEventPrice,
            this.colProductId,
            this.colName,
            this.colDescription,
            this.colPicture,
            this.colPrice,
            this.colCodeCategoryId,
            this.colCodeCategory,
            this.colEventProducts,
            this.colOrderDetails,
            this.colRecipes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colEventPrice
            // 
            this.colEventPrice.FieldName = "EventPrice";
            this.colEventPrice.MinWidth = 25;
            this.colEventPrice.Name = "colEventPrice";
            this.colEventPrice.Visible = true;
            this.colEventPrice.VisibleIndex = 0;
            this.colEventPrice.Width = 119;
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 25;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 1;
            this.colProductId.Width = 155;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 55;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 55;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.MinWidth = 25;
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 4;
            this.colPicture.Width = 55;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            this.colPrice.Width = 55;
            // 
            // colCodeCategoryId
            // 
            this.colCodeCategoryId.FieldName = "CodeCategoryId";
            this.colCodeCategoryId.MinWidth = 25;
            this.colCodeCategoryId.Name = "colCodeCategoryId";
            this.colCodeCategoryId.Visible = true;
            this.colCodeCategoryId.VisibleIndex = 6;
            this.colCodeCategoryId.Width = 55;
            // 
            // colCodeCategory
            // 
            this.colCodeCategory.FieldName = "CodeCategory";
            this.colCodeCategory.MinWidth = 25;
            this.colCodeCategory.Name = "colCodeCategory";
            this.colCodeCategory.Visible = true;
            this.colCodeCategory.VisibleIndex = 7;
            this.colCodeCategory.Width = 55;
            // 
            // colEventProducts
            // 
            this.colEventProducts.FieldName = "EventProducts";
            this.colEventProducts.MinWidth = 25;
            this.colEventProducts.Name = "colEventProducts";
            this.colEventProducts.Visible = true;
            this.colEventProducts.VisibleIndex = 8;
            this.colEventProducts.Width = 55;
            // 
            // colOrderDetails
            // 
            this.colOrderDetails.FieldName = "OrderDetails";
            this.colOrderDetails.MinWidth = 25;
            this.colOrderDetails.Name = "colOrderDetails";
            this.colOrderDetails.Visible = true;
            this.colOrderDetails.VisibleIndex = 9;
            this.colOrderDetails.Width = 55;
            // 
            // colRecipes
            // 
            this.colRecipes.FieldName = "Recipes";
            this.colRecipes.MinWidth = 25;
            this.colRecipes.Name = "colRecipes";
            this.colRecipes.Visible = true;
            this.colRecipes.VisibleIndex = 10;
            this.colRecipes.Width = 56;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colEventPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colEventProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colRecipes;
    }
}