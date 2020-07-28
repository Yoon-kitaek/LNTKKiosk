﻿namespace LNTKCustomer.Form
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
            this.pceRight = new DevExpress.XtraEditors.PictureEdit();
            this.pceLeft = new DevExpress.XtraEditors.PictureEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uscThumbnail4 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail5 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail6 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail1 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail2 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail3 = new LNTKCustomer.UserControl.Thumbnail();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pceRight);
            this.layoutControl1.Controls.Add(this.pceLeft);
            this.layoutControl1.Controls.Add(this.tableLayoutPanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(742, 439, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1326, 669);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pceRight
            // 
            this.pceRight.EditValue = ((object)(resources.GetObject("pceRight.EditValue")));
            this.pceRight.Location = new System.Drawing.Point(1156, 260);
            this.pceRight.Margin = new System.Windows.Forms.Padding(5);
            this.pceRight.Name = "pceRight";
            this.pceRight.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceRight.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceRight.Size = new System.Drawing.Size(158, 92);
            this.pceRight.StyleController = this.layoutControl1;
            this.pceRight.TabIndex = 6;
            this.pceRight.Click += new System.EventHandler(this.pceRight_Click);
            // 
            // pceLeft
            // 
            this.pceLeft.EditValue = ((object)(resources.GetObject("pceLeft.EditValue")));
            this.pceLeft.Location = new System.Drawing.Point(12, 266);
            this.pceLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pceLeft.Name = "pceLeft";
            this.pceLeft.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceLeft.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceLeft.Size = new System.Drawing.Size(158, 87);
            this.pceLeft.StyleController = this.layoutControl1;
            this.pceLeft.TabIndex = 5;
            this.pceLeft.Click += new System.EventHandler(this.pceLeft_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.uscThumbnail6, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(174, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 645);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // uscThumbnail4
            // 
            this.uscThumbnail4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail4.Label = "label";
            this.uscThumbnail4.Location = new System.Drawing.Point(3, 325);
            this.uscThumbnail4.Name = "uscThumbnail4";
            this.uscThumbnail4.Size = new System.Drawing.Size(319, 317);
            this.uscThumbnail4.TabIndex = 3;
            this.uscThumbnail4.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail5
            // 
            this.uscThumbnail5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail5.Label = "label";
            this.uscThumbnail5.Location = new System.Drawing.Point(328, 325);
            this.uscThumbnail5.Name = "uscThumbnail5";
            this.uscThumbnail5.Size = new System.Drawing.Size(319, 317);
            this.uscThumbnail5.TabIndex = 4;
            this.uscThumbnail5.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);
            // 
            // uscThumbnail6
            // 
            this.uscThumbnail6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail6.Label = "label";
            this.uscThumbnail6.Location = new System.Drawing.Point(653, 325);
            this.uscThumbnail6.Name = "uscThumbnail6";
            this.uscThumbnail6.Size = new System.Drawing.Size(322, 317);
            this.uscThumbnail6.TabIndex = 5;
            this.uscThumbnail6.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);

            // 
            // uscThumbnail1
            // 
            this.uscThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail1.Label = "label";
            this.uscThumbnail1.Location = new System.Drawing.Point(3, 3);
            this.uscThumbnail1.Name = "uscThumbnail1";
            this.uscThumbnail1.Size = new System.Drawing.Size(319, 316);
            this.uscThumbnail1.TabIndex = 0;
            this.uscThumbnail1.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);


            // 
            // uscThumbnail2
            // 
            this.uscThumbnail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail2.Label = "label";
            this.uscThumbnail2.Location = new System.Drawing.Point(328, 3);
            this.uscThumbnail2.Name = "uscThumbnail2";
            this.uscThumbnail2.Size = new System.Drawing.Size(319, 316);
            this.uscThumbnail2.TabIndex = 1;
            this.uscThumbnail2.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);


            // 
            // uscThumbnail3
            // 
            this.uscThumbnail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail3.Label = "label";
            this.uscThumbnail3.Location = new System.Drawing.Point(653, 3);
            this.uscThumbnail3.Name = "uscThumbnail3";
            this.uscThumbnail3.Size = new System.Drawing.Size(322, 316);
            this.uscThumbnail3.TabIndex = 2;
            this.uscThumbnail3.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail_ThumbnailClicked);


            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1326, 669);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tableLayoutPanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(982, 649);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 345);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(162, 304);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(1144, 344);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(162, 305);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(162, 254);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pceLeft;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 254);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(162, 91);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pceRight;
            this.layoutControlItem3.Location = new System.Drawing.Point(1144, 248);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(162, 96);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(1144, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(162, 248);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ProductThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 669);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ProductThumbnail";
            this.Text = "ProductThumbnail";
            this.Load += new System.EventHandler(this.ProductThumbnail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControl.Thumbnail uscThumbnail2;
        private UserControl.Thumbnail uscThumbnail3;
        private UserControl.Thumbnail uscThumbnail4;
        private UserControl.Thumbnail uscThumbnail5;
        private UserControl.Thumbnail uscThumbnail6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PictureEdit pceRight;
        private DevExpress.XtraEditors.PictureEdit pceLeft;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private UserControl.Thumbnail uscThumbnail1;
    }
}