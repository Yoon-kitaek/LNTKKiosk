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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.tctlManagement = new DevExpress.XtraTab.XtraTabControl();
            this.tpgeOrder = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bdsCompletedOrder = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCompleted1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsNonCompletedOrder = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpgeProduct = new DevExpress.XtraTab.XtraTabPage();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.buttonContainer1 = new LNTKManager.ButtonContainer();
            this.tpgeRevenue = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.bdsOrderDetail = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.OrderMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tpgeShin = new DevExpress.XtraTab.XtraTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).BeginInit();
            this.tctlManagement.SuspendLayout();
            this.tpgeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCompletedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNonCompletedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tpgeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).BeginInit();
            this.tpgeRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderDetail)).BeginInit();
            this.SuspendLayout();
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
            this.tpgeProduct,
            this.tpgeRevenue,
            this.tpgeShin});
            this.tctlManagement.TabPageWidth = 180;
            this.tctlManagement.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tctlManagement_SelectedPageChanged);
            this.tctlManagement.Click += new System.EventHandler(this.tctlManagement_Click);
            // 
            // tpgeOrder
            // 
            this.tpgeOrder.Controls.Add(this.gridControl2);
            this.tpgeOrder.Controls.Add(this.gridControl1);
            this.tpgeOrder.Name = "tpgeOrder";
            this.tpgeOrder.Size = new System.Drawing.Size(798, 418);
            this.tpgeOrder.Text = "주문관리";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bdsCompletedOrder;
            this.gridControl2.Location = new System.Drawing.Point(11, 227);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(400, 180);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsCompletedOrder
            // 
            this.bdsCompletedOrder.DataSource = typeof(LNTKKiosk.Data.Order);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId1,
            this.colDate1,
            this.colIsCompleted1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colOrderId1
            // 
            this.colOrderId1.FieldName = "OrderId";
            this.colOrderId1.MinWidth = 25;
            this.colOrderId1.Name = "colOrderId1";
            this.colOrderId1.OptionsColumn.AllowEdit = false;
            this.colOrderId1.Visible = true;
            this.colOrderId1.VisibleIndex = 0;
            this.colOrderId1.Width = 94;
            // 
            // colDate1
            // 
            this.colDate1.FieldName = "Date";
            this.colDate1.MinWidth = 25;
            this.colDate1.Name = "colDate1";
            this.colDate1.OptionsColumn.AllowEdit = false;
            this.colDate1.Visible = true;
            this.colDate1.VisibleIndex = 1;
            this.colDate1.Width = 94;
            // 
            // colIsCompleted1
            // 
            this.colIsCompleted1.FieldName = "IsCompleted";
            this.colIsCompleted1.MinWidth = 25;
            this.colIsCompleted1.Name = "colIsCompleted1";
            this.colIsCompleted1.OptionsColumn.AllowEdit = false;
            this.colIsCompleted1.Visible = true;
            this.colIsCompleted1.VisibleIndex = 2;
            this.colIsCompleted1.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsNonCompletedOrder;
            this.gridControl1.Location = new System.Drawing.Point(11, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 191);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsNonCompletedOrder
            // 
            this.bdsNonCompletedOrder.DataSource = typeof(LNTKKiosk.Data.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colDate,
            this.colIsCompleted});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colOrderId
            // 
            this.colOrderId.FieldName = "OrderId";
            this.colOrderId.MinWidth = 25;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.OptionsColumn.AllowEdit = false;
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 0;
            this.colOrderId.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 94;
            // 
            // colIsCompleted
            // 
            this.colIsCompleted.FieldName = "IsCompleted";
            this.colIsCompleted.MinWidth = 25;
            this.colIsCompleted.Name = "colIsCompleted";
            this.colIsCompleted.OptionsColumn.AllowEdit = false;
            this.colIsCompleted.Visible = true;
            this.colIsCompleted.VisibleIndex = 2;
            this.colIsCompleted.Width = 94;
            // 
            // tpgeProduct
            // 
            this.tpgeProduct.Controls.Add(this.btnDelete);
            this.tpgeProduct.Controls.Add(this.btnUpdate);
            this.tpgeProduct.Controls.Add(this.btnAdd);
            this.tpgeProduct.Controls.Add(this.dataGridView1);
            this.tpgeProduct.Controls.Add(this.buttonContainer1);
            this.tpgeProduct.Name = "tpgeProduct";
            this.tpgeProduct.Size = new System.Drawing.Size(798, 418);
            this.tpgeProduct.Text = "상품관리";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(177, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(294, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(56, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdsProduct;
            this.dataGridView1.Location = new System.Drawing.Point(56, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(652, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdsProduct
            // 
            this.bdsProduct.DataSource = typeof(LNTKKiosk.Data.Product);
            // 
            // buttonContainer1
            // 
            this.buttonContainer1.Location = new System.Drawing.Point(52, 66);
            this.buttonContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonContainer1.Name = "buttonContainer1";
            this.buttonContainer1.Size = new System.Drawing.Size(656, 69);
            this.buttonContainer1.TabIndex = 0;
            this.buttonContainer1.MenuSelected += new System.EventHandler<LNTKManager.ButtonContainer.MenuSelectedEventArgs>(this.buttonContainer1_MenuSelected);
            // 
            // tpgeRevenue
            // 
            this.tpgeRevenue.Controls.Add(this.pivotGridControl1);
            this.tpgeRevenue.Name = "tpgeRevenue";
            this.tpgeRevenue.Size = new System.Drawing.Size(798, 418);
            this.tpgeRevenue.Text = "매출조회";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.bdsOrderDetail;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldOrderTime,
            this.fieldProductName,
            this.fieldProductPrice,
            this.OrderMonth});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(798, 418);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // bdsOrderDetail
            // 
            this.bdsOrderDetail.DataSource = typeof(LNTKKiosk.Data.OrderDetail);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "카테고리";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 123;
            // 
            // fieldOrderTime
            // 
            this.fieldOrderTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderTime.AreaIndex = 0;
            this.fieldOrderTime.Caption = "Year";
            this.fieldOrderTime.FieldName = "OrderTime";
            this.fieldOrderTime.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderTime.Name = "fieldOrderTime";
            this.fieldOrderTime.UnboundFieldName = "fieldOrderTime";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "상품";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldProductPrice
            // 
            this.fieldProductPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductPrice.AreaIndex = 0;
            this.fieldProductPrice.FieldName = "ProductPrice";
            this.fieldProductPrice.Name = "fieldProductPrice";
            // 
            // OrderMonth
            // 
            this.OrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.OrderMonth.AreaIndex = 1;
            this.OrderMonth.Caption = "Month";
            this.OrderMonth.FieldName = "OrderTime";
            this.OrderMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.OrderMonth.Name = "OrderMonth";
            this.OrderMonth.UnboundFieldName = "OrderMonth";
            // 
            // tpgeShin
            // 
            this.tpgeShin.Name = "tpgeShin";
            this.tpgeShin.Size = new System.Drawing.Size(798, 418);
            this.tpgeShin.Text = "재료관리";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.tctlManagement)).EndInit();
            this.tctlManagement.ResumeLayout(false);
            this.tpgeOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCompletedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNonCompletedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tpgeProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProduct)).EndInit();
            this.tpgeRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tctlManagement;
        private DevExpress.XtraTab.XtraTabPage tpgeOrder;
        private DevExpress.XtraTab.XtraTabPage tpgeProduct;
        private DevExpress.XtraTab.XtraTabPage tpgeRevenue;
        private DevExpress.XtraTab.XtraTabPage tpgeShin;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdsProduct;
        private ButtonContainer buttonContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompleted1;
        private System.Windows.Forms.BindingSource bdsNonCompletedOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCompleted;
        private System.Windows.Forms.BindingSource bdsCompletedOrder;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource bdsOrderDetail;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductPrice;
        private DevExpress.XtraPivotGrid.PivotGridField OrderMonth;
    }
}

