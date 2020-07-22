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
            this.grvNonCompletedOrder = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCompleted1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvCompletedOrder = new DevExpress.XtraGrid.GridControl();
            this.bdsCompletedOrder = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.bdsNonCompletedOrder = new System.Windows.Forms.BindingSource(this.components);
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).BeginInit();
            this.tctlManagement.SuspendLayout();
            this.tpgeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNonCompletedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompletedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCompletedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNonCompletedOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grvProduct;
            this.gridView4.Name = "gridView4";
            // 
            // grvProduct
            // 
            this.grvProduct.DataSource = this.bdsProduct;
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
            this.grvProduct.Location = new System.Drawing.Point(27, 109);
            this.grvProduct.MainView = this.gridView3;
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.Size = new System.Drawing.Size(637, 306);
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
            this.gridView5.GridControl = this.grvProduct;
            this.gridView5.Name = "gridView5";
            // 
            // gridView6
            // 
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
            this.gridView3.GridControl = this.grvProduct;
            this.gridView3.Name = "gridView3";
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.MinWidth = 25;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 0;
            this.colProductId.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 94;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.MinWidth = 25;
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 3;
            this.colPicture.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 94;
            // 
            // colEventProducts
            // 
            this.colEventProducts.FieldName = "EventProducts";
            this.colEventProducts.MinWidth = 25;
            this.colEventProducts.Name = "colEventProducts";
            this.colEventProducts.Visible = true;
            this.colEventProducts.VisibleIndex = 5;
            this.colEventProducts.Width = 94;
            // 
            // colOrderDetails
            // 
            this.colOrderDetails.FieldName = "OrderDetails";
            this.colOrderDetails.MinWidth = 25;
            this.colOrderDetails.Name = "colOrderDetails";
            this.colOrderDetails.Visible = true;
            this.colOrderDetails.VisibleIndex = 6;
            this.colOrderDetails.Width = 94;
            // 
            // colRecipes
            // 
            this.colRecipes.FieldName = "Recipes";
            this.colRecipes.MinWidth = 25;
            this.colRecipes.Name = "colRecipes";
            this.colRecipes.Visible = true;
            this.colRecipes.VisibleIndex = 7;
            this.colRecipes.Width = 94;
            // 
            // tctlManagement
            // 
            this.tctlManagement.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctlManagement.Appearance.Options.UseFont = true;
            this.tctlManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlManagement.Location = new System.Drawing.Point(0, 0);
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
            this.tpgeOrder.Controls.Add(this.grvNonCompletedOrder);
            this.tpgeOrder.Controls.Add(this.grvCompletedOrder);
            this.tpgeOrder.Name = "tpgeOrder";
            this.tpgeOrder.Size = new System.Drawing.Size(794, 414);
            this.tpgeOrder.Text = "주문관리";
            // 
            // grvNonCompletedOrder
            // 
            this.grvNonCompletedOrder.DataSource = this.bdsNonCompletedOrder;
            this.grvNonCompletedOrder.Location = new System.Drawing.Point(11, 200);
            this.grvNonCompletedOrder.MainView = this.gridView2;
            this.grvNonCompletedOrder.Name = "grvNonCompletedOrder";
            this.grvNonCompletedOrder.Size = new System.Drawing.Size(400, 207);
            this.grvNonCompletedOrder.TabIndex = 1;
            this.grvNonCompletedOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId1,
            this.colIsCompleted1,
            this.colDate1});
            this.gridView2.GridControl = this.grvNonCompletedOrder;
            this.gridView2.Name = "gridView2";
            // 
            // colOrderId1
            // 
            this.colOrderId1.FieldName = "OrderId";
            this.colOrderId1.MinWidth = 25;
            this.colOrderId1.Name = "colOrderId1";
            this.colOrderId1.Visible = true;
            this.colOrderId1.VisibleIndex = 0;
            this.colOrderId1.Width = 94;
            // 
            // colIsCompleted1
            // 
            this.colIsCompleted1.FieldName = "IsCompleted";
            this.colIsCompleted1.MinWidth = 25;
            this.colIsCompleted1.Name = "colIsCompleted1";
            this.colIsCompleted1.Visible = true;
            this.colIsCompleted1.VisibleIndex = 1;
            this.colIsCompleted1.Width = 94;
            // 
            // grvCompletedOrder
            // 
            this.grvCompletedOrder.DataSource = this.bdsCompletedOrder;
            this.grvCompletedOrder.Location = new System.Drawing.Point(11, 3);
            this.grvCompletedOrder.MainView = this.gridView1;
            this.grvCompletedOrder.Name = "grvCompletedOrder";
            this.grvCompletedOrder.Size = new System.Drawing.Size(400, 191);
            this.grvCompletedOrder.TabIndex = 0;
            this.grvCompletedOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsCompletedOrder
            // 
            this.bdsCompletedOrder.DataSource = typeof(LNTKKiosk.Data.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colIsCompleted,
            this.colDate});
            this.gridView1.GridControl = this.grvCompletedOrder;
            this.gridView1.Name = "gridView1";
            // 
            // colOrderId
            // 
            this.colOrderId.FieldName = "OrderId";
            this.colOrderId.MinWidth = 25;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 0;
            this.colOrderId.Width = 94;
            // 
            // colIsCompleted
            // 
            this.colIsCompleted.FieldName = "IsCompleted";
            this.colIsCompleted.MinWidth = 25;
            this.colIsCompleted.Name = "colIsCompleted";
            this.colIsCompleted.Visible = true;
            this.colIsCompleted.VisibleIndex = 1;
            this.colIsCompleted.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 94;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grvProduct);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(794, 414);
            this.xtraTabPage2.Text = "상품관리";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(794, 414);
            this.xtraTabPage3.Text = "매출조회";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(794, 414);
            this.xtraTabPage5.Text = "재료관리";
            // 
            // bdsNonCompletedOrder
            // 
            this.bdsNonCompletedOrder.DataSource = typeof(LNTKKiosk.Data.Order);
            // 
            // colDate1
            // 
            this.colDate1.FieldName = "Date";
            this.colDate1.MinWidth = 25;
            this.colDate1.Name = "colDate1";
            this.colDate1.Visible = true;
            this.colDate1.VisibleIndex = 2;
            this.colDate1.Width = 94;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tctlManagement);
            this.Name = "Management";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).EndInit();
            this.tctlManagement.ResumeLayout(false);
            this.tpgeOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvNonCompletedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompletedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCompletedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsNonCompletedOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tctlManagement;
        private DevExpress.XtraTab.XtraTabPage tpgeOrder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl grvNonCompletedOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grvCompletedOrder;
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
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompleted1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompleted;
        private System.Windows.Forms.BindingSource bdsCompletedOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private System.Windows.Forms.BindingSource bdsNonCompletedOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
    }
}

