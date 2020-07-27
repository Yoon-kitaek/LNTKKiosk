namespace LNTKCustomer.UserControl
{
    partial class PackageSelection
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pceMiddleSet = new DevExpress.XtraEditors.PictureEdit();
            this.pceSingle = new DevExpress.XtraEditors.PictureEdit();
            this.pceLargetSet = new DevExpress.XtraEditors.PictureEdit();
            this.lbcSingle = new DevExpress.XtraEditors.LabelControl();
            this.lbcLargeSet = new DevExpress.XtraEditors.LabelControl();
            this.lbcMiddleSet = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceMiddleSet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSingle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLargetSet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1114, 367);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1114, 367);
            this.Root.TextVisible = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel1.Controls.Add(this.lbcMiddleSet);
            this.tablePanel1.Controls.Add(this.lbcLargeSet);
            this.tablePanel1.Controls.Add(this.lbcSingle);
            this.tablePanel1.Controls.Add(this.pceLargetSet);
            this.tablePanel1.Controls.Add(this.pceSingle);
            this.tablePanel1.Controls.Add(this.pceMiddleSet);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(1090, 343);
            this.tablePanel1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1094, 347);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // pceMiddleSet
            // 
            this.tablePanel1.SetColumn(this.pceMiddleSet, 1);
            this.pceMiddleSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceMiddleSet.Location = new System.Drawing.Point(366, 3);
            this.pceMiddleSet.Name = "pceMiddleSet";
            this.pceMiddleSet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceMiddleSet.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceMiddleSet, 0);
            this.pceMiddleSet.Size = new System.Drawing.Size(357, 268);
            this.pceMiddleSet.TabIndex = 0;
            // 
            // pceSingle
            // 
            this.tablePanel1.SetColumn(this.pceSingle, 0);
            this.pceSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceSingle.Location = new System.Drawing.Point(3, 3);
            this.pceSingle.Name = "pceSingle";
            this.pceSingle.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceSingle.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceSingle, 0);
            this.pceSingle.Size = new System.Drawing.Size(357, 268);
            this.pceSingle.TabIndex = 1;
            // 
            // pceLargetSet
            // 
            this.tablePanel1.SetColumn(this.pceLargetSet, 2);
            this.pceLargetSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceLargetSet.Location = new System.Drawing.Point(730, 3);
            this.pceLargetSet.Name = "pceLargetSet";
            this.pceLargetSet.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceLargetSet.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceLargetSet, 0);
            this.pceLargetSet.Size = new System.Drawing.Size(357, 268);
            this.pceLargetSet.TabIndex = 2;
            // 
            // lbcSingle
            // 
            this.lbcSingle.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcSingle.Appearance.Options.UseFont = true;
            this.lbcSingle.Appearance.Options.UseTextOptions = true;
            this.lbcSingle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcSingle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lbcSingle, 0);
            this.lbcSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcSingle.Location = new System.Drawing.Point(3, 277);
            this.lbcSingle.Name = "lbcSingle";
            this.tablePanel1.SetRow(this.lbcSingle, 1);
            this.lbcSingle.Size = new System.Drawing.Size(357, 63);
            this.lbcSingle.TabIndex = 4;
            this.lbcSingle.Text = "labelControl2";
            // 
            // lbcLargeSet
            // 
            this.lbcLargeSet.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcLargeSet.Appearance.Options.UseFont = true;
            this.lbcLargeSet.Appearance.Options.UseTextOptions = true;
            this.lbcLargeSet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcLargeSet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lbcLargeSet, 2);
            this.lbcLargeSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcLargeSet.Location = new System.Drawing.Point(730, 277);
            this.lbcLargeSet.Name = "lbcLargeSet";
            this.tablePanel1.SetRow(this.lbcLargeSet, 1);
            this.lbcLargeSet.Size = new System.Drawing.Size(357, 63);
            this.lbcLargeSet.TabIndex = 5;
            this.lbcLargeSet.Text = "labelControl2";
            // 
            // lbcMiddleSet
            // 
            this.lbcMiddleSet.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcMiddleSet.Appearance.Options.UseFont = true;
            this.lbcMiddleSet.Appearance.Options.UseTextOptions = true;
            this.lbcMiddleSet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcMiddleSet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lbcMiddleSet, 1);
            this.lbcMiddleSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcMiddleSet.Location = new System.Drawing.Point(366, 277);
            this.lbcMiddleSet.Name = "lbcMiddleSet";
            this.tablePanel1.SetRow(this.lbcMiddleSet, 1);
            this.lbcMiddleSet.Size = new System.Drawing.Size(357, 63);
            this.lbcMiddleSet.TabIndex = 6;
            this.lbcMiddleSet.Text = "labelControl2";
            // 
            // PackageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PackageSelection";
            this.Size = new System.Drawing.Size(1114, 367);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceMiddleSet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSingle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLargetSet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl lbcMiddleSet;
        private DevExpress.XtraEditors.LabelControl lbcLargeSet;
        private DevExpress.XtraEditors.LabelControl lbcSingle;
        private DevExpress.XtraEditors.PictureEdit pceLargetSet;
        private DevExpress.XtraEditors.PictureEdit pceSingle;
        private DevExpress.XtraEditors.PictureEdit pceMiddleSet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
