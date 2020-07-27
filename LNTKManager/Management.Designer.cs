namespace LNTKManager
{
    partial class Management
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grvProduct = new DevExpress.XtraGrid.GridControl();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventProducts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecipes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tctlManagement = new DevExpress.XtraTab.XtraTabControl();
            this.tpgeOrder = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).BeginInit();
            this.tctlManagement.SuspendLayout();
            this.tpgeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 437;
            this.gridView4.GridControl = this.grvProduct;
            this.gridView4.Name = "gridView4";
            // 
            // grvProduct
            // 
            this.grvProduct.DataSource = this.bdsProduct;
            this.grvProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridLevelNode1.LevelTemplate = this.gridView4;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.LevelTemplate = this.gridView5;
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.LevelTemplate = this.gridView6;
            gridLevelNode3.RelationName = "Level3";
            this.grvProduct.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.grvProduct.Location = new System.Drawing.Point(4, 32);
            this.grvProduct.MainView = this.gridView3;
            this.grvProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.Size = new System.Drawing.Size(796, 382);
            this.grvProduct.TabIndex = 4;
            this.grvProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5,
            this.gridView6,
            this.gridView3,
            this.gridView4});
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(LNTKKiosk.Data.Product);
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 437;
            this.gridView5.GridControl = this.grvProduct;
            this.gridView5.Name = "gridView5";
            // 
            // gridView6
            // 
            this.gridView6.DetailHeight = 437;
            this.gridView6.GridControl = this.grvProduct;
            this.gridView6.Name = "gridView6";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colName,
            this.colDescription,
            this.colPicture,
            this.colPrice,
            this.colEventProducts,
            this.colOrderDetails,
            this.colRecipes});
            this.gridView3.DetailHeight = 437;
            this.gridView3.GridControl = this.grvProduct;
            this.gridView3.GroupCount = 1;
            this.gridView3.Name = "gridView3";
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 31;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            this.colProductId.Width = 117;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 31;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 117;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 31;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 117;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.MinWidth = 31;
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 1;
            this.colPicture.Width = 117;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 31;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 117;
            // 
            // colEventProducts
            // 
            this.colEventProducts.FieldName = "EventProducts";
            this.colEventProducts.MinWidth = 31;
            this.colEventProducts.Name = "colEventProducts";
            this.colEventProducts.Visible = true;
            this.colEventProducts.VisibleIndex = 4;
            this.colEventProducts.Width = 117;
            // 
            // colOrderDetails
            // 
            this.colOrderDetails.FieldName = "OrderDetails";
            this.colOrderDetails.MinWidth = 31;
            this.colOrderDetails.Name = "colOrderDetails";
            this.colOrderDetails.Visible = true;
            this.colOrderDetails.VisibleIndex = 5;
            this.colOrderDetails.Width = 117;
            // 
            // colRecipes
            // 
            this.colRecipes.FieldName = "Recipes";
            this.colRecipes.MinWidth = 31;
            this.colRecipes.Name = "colRecipes";
            this.colRecipes.Visible = true;
            this.colRecipes.VisibleIndex = 6;
            this.colRecipes.Width = 117;
            // 
            // tctlManagement
            // 
            this.tctlManagement.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctlManagement.Appearance.Options.UseFont = true;
            this.tctlManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlManagement.Location = new System.Drawing.Point(0, 0);
            this.tctlManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tctlManagement.Name = "tctlManagement";
            this.tctlManagement.SelectedTabPage = this.tpgeOrder;
            this.tctlManagement.Size = new System.Drawing.Size(800, 450);
            this.tctlManagement.TabIndex = 0;
            this.tctlManagement.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpgeOrder,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage5});
            this.tctlManagement.TabPageWidth = 180;
            // 
            // tpgeOrder
            // 
            this.tpgeOrder.Controls.Add(this.gridControl2);
            this.tpgeOrder.Controls.Add(this.gridControl1);
            this.tpgeOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgeOrder.Name = "tpgeOrder";
            this.tpgeOrder.Size = new System.Drawing.Size(798, 418);
            this.tpgeOrder.Text = "주문관리";
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl2.Location = new System.Drawing.Point(14, 284);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(500, 225);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(14, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(500, 225);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grvProduct);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(798, 418);
            this.xtraTabPage2.Text = "상품관리";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(798, 418);
            this.xtraTabPage3.Text = "매출조회";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(798, 418);
            this.xtraTabPage5.Text = "재료관리";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tctlManagement);
            this.Name = "Management";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).EndInit();
            this.tctlManagement.ResumeLayout(false);
            this.tpgeOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tctlManagement;
        private DevExpress.XtraTab.XtraTabPage tpgeOrder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grvProduct;
        private System.Windows.Forms.BindingSource bdsProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colEventProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colRecipes;
    }
}

