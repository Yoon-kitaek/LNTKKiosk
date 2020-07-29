namespace LNTKCustomer.Form
{
    partial class ShoppingCart
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
            this.uscThumbnailContainer = new LNTKCustomer.UserControl.ThumbnailContainer();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.sbtHome = new DevExpress.XtraEditors.SimpleButton();
            this.sbtPay = new DevExpress.XtraEditors.SimpleButton();
            this.grcShoppedItemList = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpackageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.lbcPackageName = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcShoppedItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lbcPackageName);
            this.layoutControl1.Controls.Add(this.uscThumbnailContainer);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(826, 698, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(734, 1066);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // uscThumbnailContainer
            // 
            this.uscThumbnailContainer.Location = new System.Drawing.Point(12, 67);
            this.uscThumbnailContainer.Name = "uscThumbnailContainer";
            this.uscThumbnailContainer.Size = new System.Drawing.Size(710, 589);
            this.uscThumbnailContainer.TabIndex = 5;
            this.uscThumbnailContainer.ArrowClicked += new System.EventHandler<LNTKCustomer.UserControl.ThumbnailContainer.ArrowClickedEventArgs>(this.uscThumbnailContainer_ArrowClicked);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.sbtHome);
            this.layoutControl2.Controls.Add(this.sbtPay);
            this.layoutControl2.Controls.Add(this.grcShoppedItemList);
            this.layoutControl2.Location = new System.Drawing.Point(12, 660);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 363, 812, 500);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(710, 394);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // sbtHome
            // 
            this.sbtHome.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.sbtHome.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtHome.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbtHome.Appearance.Options.UseBackColor = true;
            this.sbtHome.Appearance.Options.UseFont = true;
            this.sbtHome.Appearance.Options.UseForeColor = true;
            this.sbtHome.Location = new System.Drawing.Point(68, 351);
            this.sbtHome.MaximumSize = new System.Drawing.Size(0, 200);
            this.sbtHome.Name = "sbtHome";
            this.sbtHome.Size = new System.Drawing.Size(241, 31);
            this.sbtHome.StyleController = this.layoutControl2;
            this.sbtHome.TabIndex = 22;
            this.sbtHome.Text = "다른 상품 보기";
            this.sbtHome.Click += new System.EventHandler(this.sbtHome_Click);
            // 
            // sbtPay
            // 
            this.sbtPay.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.sbtPay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtPay.Appearance.Options.UseBackColor = true;
            this.sbtPay.Appearance.Options.UseFont = true;
            this.sbtPay.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtPay.AppearanceDisabled.Options.UseFont = true;
            this.sbtPay.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtPay.AppearanceHovered.Options.UseFont = true;
            this.sbtPay.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtPay.AppearancePressed.Options.UseFont = true;
            this.sbtPay.Location = new System.Drawing.Point(371, 351);
            this.sbtPay.Name = "sbtPay";
            this.sbtPay.Size = new System.Drawing.Size(252, 31);
            this.sbtPay.StyleController = this.layoutControl2;
            this.sbtPay.TabIndex = 21;
            this.sbtPay.Text = "결제하기";
            this.sbtPay.Click += new System.EventHandler(this.sbtPay_Click);
            // 
            // grcShoppedItemList
            // 
            this.grcShoppedItemList.DataSource = this.productBindingSource;
            this.grcShoppedItemList.Location = new System.Drawing.Point(12, 12);
            this.grcShoppedItemList.MainView = this.gridView2;
            this.grcShoppedItemList.Name = "grcShoppedItemList";
            this.grcShoppedItemList.Size = new System.Drawing.Size(686, 335);
            this.grcShoppedItemList.TabIndex = 6;
            this.grcShoppedItemList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grcShoppedItemList.Click += new System.EventHandler(this.grcShoppedItemList_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LNTKKiosk.Data.ShoppedItem);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpackageName,
            this.colproductName,
            this.colquantity,
            this.coltotalPrice});
            this.gridView2.GridControl = this.grcShoppedItemList;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowPreview = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpackageName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colpackageName
            // 
            this.colpackageName.Caption = " ";
            this.colpackageName.FieldName = "packageName";
            this.colpackageName.MinWidth = 25;
            this.colpackageName.Name = "colpackageName";
            this.colpackageName.Visible = true;
            this.colpackageName.VisibleIndex = 0;
            this.colpackageName.Width = 94;
            // 
            // colproductName
            // 
            this.colproductName.Caption = "상품명";
            this.colproductName.FieldName = "productName";
            this.colproductName.MinWidth = 25;
            this.colproductName.Name = "colproductName";
            this.colproductName.OptionsColumn.ReadOnly = true;
            this.colproductName.Visible = true;
            this.colproductName.VisibleIndex = 0;
            this.colproductName.Width = 94;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "수량";
            this.colquantity.FieldName = "quantity";
            this.colquantity.MinWidth = 25;
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 1;
            this.colquantity.Width = 94;
            // 
            // coltotalPrice
            // 
            this.coltotalPrice.Caption = "가격";
            this.coltotalPrice.FieldName = "totalPrice";
            this.coltotalPrice.MinWidth = 25;
            this.coltotalPrice.Name = "coltotalPrice";
            this.coltotalPrice.Visible = true;
            this.coltotalPrice.VisibleIndex = 2;
            this.coltotalPrice.Width = 94;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(710, 394);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grcShoppedItemList;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(690, 339);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbtPay;
            this.layoutControlItem4.Location = new System.Drawing.Point(359, 339);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(256, 35);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbtHome;
            this.layoutControlItem5.Location = new System.Drawing.Point(56, 339);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(245, 35);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(301, 339);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(58, 35);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(615, 339);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(75, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 339);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(56, 35);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(734, 1066);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 648);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(714, 398);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.uscThumbnailContainer;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(714, 593);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.Caption = "상품명";
            this.colName.FieldName = "PackageName";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colEventPrice
            // 
            this.colEventPrice.Caption = "가격";
            this.colEventPrice.FieldName = "TotalPrice";
            this.colEventPrice.MinWidth = 25;
            this.colEventPrice.Name = "colEventPrice";
            this.colEventPrice.Visible = true;
            this.colEventPrice.VisibleIndex = 0;
            this.colEventPrice.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "수량";
            this.gridColumn1.FieldName = "Quantity";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 94;
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.Name = "tileViewColumn1";
            // 
            // lbcPackageName
            // 
            this.lbcPackageName.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcPackageName.Appearance.Options.UseFont = true;
            this.lbcPackageName.Appearance.Options.UseTextOptions = true;
            this.lbcPackageName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcPackageName.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcPackageName.AppearanceDisabled.Options.UseFont = true;
            this.lbcPackageName.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcPackageName.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcPackageName.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcPackageName.AppearanceHovered.Options.UseFont = true;
            this.lbcPackageName.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcPackageName.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcPackageName.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcPackageName.AppearancePressed.Options.UseFont = true;
            this.lbcPackageName.AppearancePressed.Options.UseTextOptions = true;
            this.lbcPackageName.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcPackageName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbcPackageName.Location = new System.Drawing.Point(12, 12);
            this.lbcPackageName.Name = "lbcPackageName";
            this.lbcPackageName.Size = new System.Drawing.Size(710, 51);
            this.lbcPackageName.StyleController = this.layoutControl1;
            this.lbcPackageName.TabIndex = 6;
            this.lbcPackageName.Text = "세트 이름";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbcPackageName;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(714, 55);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 1066);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcShoppedItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEventPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.GridControl grcShoppedItemList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colpackageName;
        private DevExpress.XtraGrid.Columns.GridColumn colproductName;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalPrice;
        private DevExpress.XtraEditors.SimpleButton sbtPay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton sbtHome;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private UserControl.ThumbnailContainer uscThumbnailContainer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LabelControl lbcPackageName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}