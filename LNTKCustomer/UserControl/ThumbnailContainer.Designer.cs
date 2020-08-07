namespace LNTKCustomer.UserControl
{
    partial class ThumbnailContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.pceLeftArrow = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.pceRightArrow = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.uscThumbnail4 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail3 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail2 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail1 = new LNTKCustomer.UserControl.Thumbnail();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeftArrow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceRightArrow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(767, 709);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel2.Controls.Add(this.tablePanel4);
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Controls.Add(this.tablePanel1);
            this.tablePanel2.Location = new System.Drawing.Point(12, 12);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(743, 685);
            this.tablePanel2.TabIndex = 5;
            // 
            // tablePanel4
            // 
            this.tablePanel2.SetColumn(this.tablePanel4, 0);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel4.Controls.Add(this.pceLeftArrow);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(3, 3);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel2.SetRow(this.tablePanel4, 0);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F)});
            this.tablePanel4.Size = new System.Drawing.Size(68, 679);
            this.tablePanel4.TabIndex = 6;
            // 
            // pceLeftArrow
            // 
            this.tablePanel4.SetColumn(this.pceLeftArrow, 0);
            this.pceLeftArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceLeftArrow.EditValue = global::LNTKCustomer.Properties.Resources.LeftArrow;
            this.pceLeftArrow.Location = new System.Drawing.Point(3, 309);
            this.pceLeftArrow.Name = "pceLeftArrow";
            this.pceLeftArrow.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceLeftArrow.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel4.SetRow(this.pceLeftArrow, 1);
            this.pceLeftArrow.Size = new System.Drawing.Size(62, 62);
            this.pceLeftArrow.TabIndex = 0;
            this.pceLeftArrow.Click += new System.EventHandler(this.pceLeftArrow_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 2);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel3.Controls.Add(this.pceRightArrow);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(672, 3);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 0);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F)});
            this.tablePanel3.Size = new System.Drawing.Size(68, 679);
            this.tablePanel3.TabIndex = 5;
            // 
            // pceRightArrow
            // 
            this.tablePanel3.SetColumn(this.pceRightArrow, 0);
            this.pceRightArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceRightArrow.EditValue = global::LNTKCustomer.Properties.Resources.RightArrow;
            this.pceRightArrow.Location = new System.Drawing.Point(3, 309);
            this.pceRightArrow.Name = "pceRightArrow";
            this.pceRightArrow.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceRightArrow.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel3.SetRow(this.pceRightArrow, 1);
            this.pceRightArrow.Size = new System.Drawing.Size(62, 62);
            this.pceRightArrow.TabIndex = 0;
            this.pceRightArrow.Click += new System.EventHandler(this.pceRightArrow_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel2.SetColumn(this.tablePanel1, 1);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.uscThumbnail4);
            this.tablePanel1.Controls.Add(this.uscThumbnail3);
            this.tablePanel1.Controls.Add(this.uscThumbnail2);
            this.tablePanel1.Controls.Add(this.uscThumbnail1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(77, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel2.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(588, 679);
            this.tablePanel1.TabIndex = 4;
            // 
            // uscThumbnail4
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail4, 1);
            this.uscThumbnail4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail4.Label = "label";
            this.uscThumbnail4.Location = new System.Drawing.Point(297, 343);
            this.uscThumbnail4.Name = "uscThumbnail4";
            this.tablePanel1.SetRow(this.uscThumbnail4, 1);
            this.uscThumbnail4.Size = new System.Drawing.Size(288, 333);
            this.uscThumbnail4.TabIndex = 3;
            this.uscThumbnail4.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscThumbnail3
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail3, 0);
            this.uscThumbnail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail3.Label = "label";
            this.uscThumbnail3.Location = new System.Drawing.Point(3, 343);
            this.uscThumbnail3.Name = "uscThumbnail3";
            this.tablePanel1.SetRow(this.uscThumbnail3, 1);
            this.uscThumbnail3.Size = new System.Drawing.Size(288, 333);
            this.uscThumbnail3.TabIndex = 2;
            this.uscThumbnail3.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscThumbnail2
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail2, 1);
            this.uscThumbnail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail2.Label = "label";
            this.uscThumbnail2.Location = new System.Drawing.Point(297, 3);
            this.uscThumbnail2.Name = "uscThumbnail2";
            this.tablePanel1.SetRow(this.uscThumbnail2, 0);
            this.uscThumbnail2.Size = new System.Drawing.Size(288, 334);
            this.uscThumbnail2.TabIndex = 1;
            this.uscThumbnail2.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscThumbnail1
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail1, 0);
            this.uscThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail1.Label = "label";
            this.uscThumbnail1.Location = new System.Drawing.Point(3, 3);
            this.uscThumbnail1.Name = "uscThumbnail1";
            this.tablePanel1.SetRow(this.uscThumbnail1, 0);
            this.uscThumbnail1.Size = new System.Drawing.Size(288, 334);
            this.uscThumbnail1.TabIndex = 0;
            this.uscThumbnail1.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(767, 709);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tablePanel2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(747, 689);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ThumbnailContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ThumbnailContainer";
            this.Size = new System.Drawing.Size(767, 709);
            this.Load += new System.EventHandler(this.ThumbnailContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceLeftArrow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceRightArrow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private Thumbnail uscThumbnail4;
        private Thumbnail uscThumbnail3;
        private Thumbnail uscThumbnail2;
        private Thumbnail uscThumbnail1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PictureEdit pceLeftArrow;
        private DevExpress.XtraEditors.PictureEdit pceRightArrow;
    }
}
