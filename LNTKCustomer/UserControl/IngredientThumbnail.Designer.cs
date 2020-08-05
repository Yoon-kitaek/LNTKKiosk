namespace LNTKCustomer.UserControl
{
    partial class IngredientThumbnail
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lbcQuantity = new DevExpress.XtraEditors.LabelControl();
            this.pceMinus = new DevExpress.XtraEditors.PictureEdit();
            this.pcePlus = new DevExpress.XtraEditors.PictureEdit();
            this.pceCheckBox = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.uscThumbnail = new LNTKCustomer.UserControl.Thumbnail();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceMinus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcePlus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.uscThumbnail);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(786, 857);
            this.tablePanel1.TabIndex = 5;
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
            this.tablePanel2.Size = new System.Drawing.Size(73, 851);
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
            this.lbcQuantity.Location = new System.Drawing.Point(3, 343);
            this.lbcQuantity.Name = "lbcQuantity";
            this.tablePanel2.SetRow(this.lbcQuantity, 2);
            this.lbcQuantity.Size = new System.Drawing.Size(67, 334);
            this.lbcQuantity.TabIndex = 3;
            this.lbcQuantity.Text = "수량";
            // 
            // pceMinus
            // 
            this.tablePanel2.SetColumn(this.pceMinus, 0);
            this.pceMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceMinus.EditValue = global::LNTKCustomer.Properties.Resources.Minus;
            this.pceMinus.Location = new System.Drawing.Point(3, 683);
            this.pceMinus.Name = "pceMinus";
            this.pceMinus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceMinus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tablePanel2.SetRow(this.pceMinus, 3);
            this.pceMinus.Size = new System.Drawing.Size(67, 165);
            this.pceMinus.TabIndex = 2;
            // 
            // pcePlus
            // 
            this.tablePanel2.SetColumn(this.pcePlus, 0);
            this.pcePlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcePlus.EditValue = global::LNTKCustomer.Properties.Resources.Plus;
            this.pcePlus.Location = new System.Drawing.Point(3, 173);
            this.pcePlus.Name = "pcePlus";
            this.pcePlus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcePlus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.tablePanel2.SetRow(this.pcePlus, 1);
            this.pcePlus.Size = new System.Drawing.Size(67, 164);
            this.pcePlus.TabIndex = 1;
            // 
            // pceCheckBox
            // 
            this.tablePanel2.SetColumn(this.pceCheckBox, 0);
            this.pceCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceCheckBox.Location = new System.Drawing.Point(3, 3);
            this.pceCheckBox.Name = "pceCheckBox";
            this.pceCheckBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceCheckBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel2.SetRow(this.pceCheckBox, 0);
            this.pceCheckBox.Size = new System.Drawing.Size(67, 164);
            this.pceCheckBox.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(810, 881);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(810, 881);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(790, 861);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // uscThumbnail
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail, 1);
            this.uscThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail.Label = "label";
            this.uscThumbnail.Location = new System.Drawing.Point(82, 3);
            this.uscThumbnail.Name = "uscThumbnail";
            this.tablePanel1.SetRow(this.uscThumbnail, 0);
            this.uscThumbnail.Size = new System.Drawing.Size(701, 851);
            this.uscThumbnail.TabIndex = 1;
            // 
            // IngredientThumbnail
            // 
            this.Controls.Add(this.layoutControl1);
            this.Name = "IngredientThumbnail";
            this.Size = new System.Drawing.Size(810, 881);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceMinus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcePlus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl lbcQuantity;
        private DevExpress.XtraEditors.PictureEdit pceMinus;
        private DevExpress.XtraEditors.PictureEdit pcePlus;
        private DevExpress.XtraEditors.PictureEdit pceCheckBox;
        private Thumbnail uscThumbnail;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
