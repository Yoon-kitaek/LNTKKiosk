namespace LNTKCustomer.Form
{
    partial class ProductThumbnail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductThumbnail));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.uscThumbnail3 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail2 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail1 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail4 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail5 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail6 = new LNTKCustomer.UserControl.Thumbnail();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pceRight = new DevExpress.XtraEditors.PictureEdit();
            this.pceLeft = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Controls.Add(this.pceRight);
            this.layoutControl1.Controls.Add(this.pceLeft);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(152, 1317, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(777, 1051);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // uscThumbnail3
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail3, 0);
            this.uscThumbnail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail3.Label = "label";
            this.uscThumbnail3.Location = new System.Drawing.Point(3, 345);
            this.uscThumbnail3.Name = "uscThumbnail3";
            this.tablePanel1.SetRow(this.uscThumbnail3, 1);
            this.uscThumbnail3.Size = new System.Drawing.Size(279, 336);
            this.uscThumbnail3.TabIndex = 2;
            this.uscThumbnail3.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail2
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail2, 1);
            this.uscThumbnail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail2.Label = "label";
            this.uscThumbnail2.Location = new System.Drawing.Point(288, 3);
            this.uscThumbnail2.Name = "uscThumbnail2";
            this.tablePanel1.SetRow(this.uscThumbnail2, 0);
            this.uscThumbnail2.Size = new System.Drawing.Size(279, 336);
            this.uscThumbnail2.TabIndex = 1;
            this.uscThumbnail2.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail1
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail1, 0);
            this.uscThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail1.Label = "label";
            this.uscThumbnail1.Location = new System.Drawing.Point(3, 3);
            this.uscThumbnail1.Name = "uscThumbnail1";
            this.tablePanel1.SetRow(this.uscThumbnail1, 0);
            this.uscThumbnail1.Size = new System.Drawing.Size(279, 336);
            this.uscThumbnail1.TabIndex = 0;
            this.uscThumbnail1.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail4
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail4, 1);
            this.uscThumbnail4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail4.Label = "label";
            this.uscThumbnail4.Location = new System.Drawing.Point(288, 345);
            this.uscThumbnail4.Name = "uscThumbnail4";
            this.tablePanel1.SetRow(this.uscThumbnail4, 1);
            this.uscThumbnail4.Size = new System.Drawing.Size(279, 336);
            this.uscThumbnail4.TabIndex = 3;
            this.uscThumbnail4.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail5
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail5, 0);
            this.uscThumbnail5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail5.Label = "label";
            this.uscThumbnail5.Location = new System.Drawing.Point(3, 687);
            this.uscThumbnail5.Name = "uscThumbnail5";
            this.tablePanel1.SetRow(this.uscThumbnail5, 2);
            this.uscThumbnail5.Size = new System.Drawing.Size(279, 337);
            this.uscThumbnail5.TabIndex = 4;
            this.uscThumbnail5.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail6
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail6, 1);
            this.uscThumbnail6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail6.Label = "label";
            this.uscThumbnail6.Location = new System.Drawing.Point(288, 687);
            this.uscThumbnail6.Name = "uscThumbnail6";
            this.tablePanel1.SetRow(this.uscThumbnail6, 2);
            this.uscThumbnail6.Size = new System.Drawing.Size(279, 337);
            this.uscThumbnail6.TabIndex = 5;
            this.uscThumbnail6.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.emptySpaceItem4,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(777, 1051);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 689);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(91, 342);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(91, 345);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(746, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(11, 1031);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.uscThumbnail6);
            this.tablePanel1.Controls.Add(this.uscThumbnail5);
            this.tablePanel1.Controls.Add(this.uscThumbnail4);
            this.tablePanel1.Controls.Add(this.uscThumbnail3);
            this.tablePanel1.Controls.Add(this.uscThumbnail1);
            this.tablePanel1.Controls.Add(this.uscThumbnail2);
            this.tablePanel1.Location = new System.Drawing.Point(103, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel1.Size = new System.Drawing.Size(569, 1027);
            this.tablePanel1.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tablePanel1;
            this.layoutControlItem4.Location = new System.Drawing.Point(91, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(573, 1031);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(664, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(82, 345);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(664, 689);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(82, 342);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pceRight
            // 
            this.pceRight.EditValue = ((object)(resources.GetObject("pceRight.EditValue")));
            this.pceRight.Location = new System.Drawing.Point(676, 357);
            this.pceRight.Margin = new System.Windows.Forms.Padding(5);
            this.pceRight.Name = "pceRight";
            this.pceRight.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceRight.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceRight.Size = new System.Drawing.Size(78, 340);
            this.pceRight.StyleController = this.layoutControl1;
            this.pceRight.TabIndex = 6;
            this.pceRight.Click += new System.EventHandler(this.pceRight_Click);
            // 
            // pceLeft
            // 
            this.pceLeft.EditValue = ((object)(resources.GetObject("pceLeft.EditValue")));
            this.pceLeft.Location = new System.Drawing.Point(12, 357);
            this.pceLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pceLeft.Name = "pceLeft";
            this.pceLeft.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceLeft.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceLeft.Size = new System.Drawing.Size(87, 340);
            this.pceLeft.StyleController = this.layoutControl1;
            this.pceLeft.TabIndex = 5;
            this.pceLeft.Click += new System.EventHandler(this.pceLeft_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pceLeft;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 345);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(91, 344);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pceRight;
            this.layoutControlItem3.Location = new System.Drawing.Point(664, 345);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(82, 344);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ProductThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 1051);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductThumbnail";
            this.Text = "ProductThumbnail";
            this.Load += new System.EventHandler(this.ProductThumbnail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControl.Thumbnail uscThumbnail2;
        private UserControl.Thumbnail uscThumbnail3;
        private UserControl.Thumbnail uscThumbnail4;
        private UserControl.Thumbnail uscThumbnail5;
        private UserControl.Thumbnail uscThumbnail6;
        private DevExpress.XtraEditors.PictureEdit pceRight;
        private DevExpress.XtraEditors.PictureEdit pceLeft;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private UserControl.Thumbnail uscThumbnail1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}