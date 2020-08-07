namespace LNTKCustomer.UserControl
{
    partial class IngredientCustomization
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pceThumbnail = new DevExpress.XtraEditors.PictureEdit();
            this.lbcName = new DevExpress.XtraEditors.LabelControl();
            this.lbcPrice = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lbcQuantity = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pceMinus = new DevExpress.XtraEditors.PictureEdit();
            this.pcePlus = new DevExpress.XtraEditors.PictureEdit();
            this.pceCheckBox = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceThumbnail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceMinus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcePlus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheckBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(784, 478);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(760, 454);
            this.tablePanel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel1, 1);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pceThumbnail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbcName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbcPrice, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel1.SetRow(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 448);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pceThumbnail
            // 
            this.pceThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceThumbnail.Location = new System.Drawing.Point(3, 3);
            this.pceThumbnail.Name = "pceThumbnail";
            this.pceThumbnail.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceThumbnail.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceThumbnail.Size = new System.Drawing.Size(672, 352);
            this.pceThumbnail.TabIndex = 4;
            // 
            // lbcName
            // 
            this.lbcName.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbcName.Appearance.Options.UseFont = true;
            this.lbcName.Appearance.Options.UseTextOptions = true;
            this.lbcName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcName.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcName.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcName.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcName.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcName.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcName.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcName.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcName.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcName.AppearancePressed.Options.UseTextOptions = true;
            this.lbcName.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcName.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcName.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbcName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcName.Location = new System.Drawing.Point(3, 361);
            this.lbcName.Name = "lbcName";
            this.lbcName.Size = new System.Drawing.Size(672, 38);
            this.lbcName.TabIndex = 5;
            this.lbcName.Text = "label";
            // 
            // lbcPrice
            // 
            this.lbcPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbcPrice.Appearance.Options.UseFont = true;
            this.lbcPrice.Appearance.Options.UseTextOptions = true;
            this.lbcPrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbcPrice.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcPrice.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcPrice.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcPrice.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbcPrice.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcPrice.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcPrice.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcPrice.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbcPrice.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcPrice.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcPrice.AppearancePressed.Options.UseTextOptions = true;
            this.lbcPrice.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbcPrice.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcPrice.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lbcPrice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbcPrice.Location = new System.Drawing.Point(3, 405);
            this.lbcPrice.Name = "lbcPrice";
            this.lbcPrice.Size = new System.Drawing.Size(645, 30);
            this.lbcPrice.TabIndex = 6;
            this.lbcPrice.Text = "label";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.lbcQuantity);
            this.tablePanel2.Controls.Add(this.pceMinus);
            this.tablePanel2.Controls.Add(this.pcePlus);
            this.tablePanel2.Controls.Add(this.pceCheckBox);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel2.Size = new System.Drawing.Size(70, 448);
            this.tablePanel2.TabIndex = 2;
            // 
            // lbcQuantity
            // 
            this.lbcQuantity.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcQuantity.Appearance.Options.UseFont = true;
            this.lbcQuantity.Appearance.Options.UseTextOptions = true;
            this.lbcQuantity.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcQuantity.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcQuantity.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcQuantity.AppearanceDisabled.Options.UseFont = true;
            this.lbcQuantity.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcQuantity.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcQuantity.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcQuantity.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcQuantity.AppearanceHovered.Options.UseFont = true;
            this.lbcQuantity.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcQuantity.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcQuantity.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcQuantity.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcQuantity.AppearancePressed.Options.UseFont = true;
            this.lbcQuantity.AppearancePressed.Options.UseTextOptions = true;
            this.lbcQuantity.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcQuantity.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcQuantity.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel2.SetColumn(this.lbcQuantity, 0);
            this.lbcQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcQuantity.Location = new System.Drawing.Point(3, 183);
            this.lbcQuantity.Name = "lbcQuantity";
            this.tablePanel2.SetRow(this.lbcQuantity, 2);
            this.lbcQuantity.Size = new System.Drawing.Size(64, 173);
            this.lbcQuantity.TabIndex = 3;
            this.lbcQuantity.Text = "수량";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(784, 478);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 458);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // pceMinus
            // 
            this.tablePanel2.SetColumn(this.pceMinus, 0);
            this.pceMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceMinus.EditValue = global::LNTKCustomer.Properties.Resources.Minus;
            this.pceMinus.Location = new System.Drawing.Point(3, 362);
            this.pceMinus.Name = "pceMinus";
            this.pceMinus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceMinus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tablePanel2.SetRow(this.pceMinus, 3);
            this.pceMinus.Size = new System.Drawing.Size(64, 83);
            this.pceMinus.TabIndex = 2;
            this.pceMinus.Click += new System.EventHandler(this.pceMinus_Click);
            // 
            // pcePlus
            // 
            this.tablePanel2.SetColumn(this.pcePlus, 0);
            this.pcePlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcePlus.EditValue = global::LNTKCustomer.Properties.Resources.Plus;
            this.pcePlus.Location = new System.Drawing.Point(3, 93);
            this.pcePlus.Name = "pcePlus";
            this.pcePlus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcePlus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tablePanel2.SetRow(this.pcePlus, 1);
            this.pcePlus.Size = new System.Drawing.Size(64, 84);
            this.pcePlus.TabIndex = 1;
            this.pcePlus.Click += new System.EventHandler(this.pcePlus_Click);
            // 
            // pceCheckBox
            // 
            this.tablePanel2.SetColumn(this.pceCheckBox, 0);
            this.pceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceCheckBox.EditValue = global::LNTKCustomer.Properties.Resources.Uncheck;
            this.pceCheckBox.Location = new System.Drawing.Point(3, 3);
            this.pceCheckBox.Name = "pceCheckBox";
            this.pceCheckBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceCheckBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel2.SetRow(this.pceCheckBox, 0);
            this.pceCheckBox.Size = new System.Drawing.Size(64, 84);
            this.pceCheckBox.TabIndex = 0;
            this.pceCheckBox.Click += new System.EventHandler(this.pceCheckBox_Click);
            // 
            // IngredientCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "IngredientCustomization";
            this.Size = new System.Drawing.Size(784, 478);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceThumbnail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceMinus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcePlus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheckBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl lbcQuantity;
        private DevExpress.XtraEditors.PictureEdit pceMinus;
        private DevExpress.XtraEditors.PictureEdit pcePlus;
        private DevExpress.XtraEditors.PictureEdit pceCheckBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PictureEdit pceThumbnail;
        private DevExpress.XtraEditors.LabelControl lbcName;
        private DevExpress.XtraEditors.LabelControl lbcPrice;
    }
}
