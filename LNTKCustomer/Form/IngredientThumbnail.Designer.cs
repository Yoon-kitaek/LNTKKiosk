namespace LNTKCustomer.Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientThumbnail));
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lbcGroceryName = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.uscIngredient4 = new LNTKCustomer.UserControl.IngredientCustomization();
            this.uscIngredient3 = new LNTKCustomer.UserControl.IngredientCustomization();
            this.uscIngredient2 = new LNTKCustomer.UserControl.IngredientCustomization();
            this.uscIngredient1 = new LNTKCustomer.UserControl.IngredientCustomization();
            this.pceLeft = new DevExpress.XtraEditors.PictureEdit();
            this.pceRight = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(737, 868);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(717, 848);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.tablePanel1);
            this.layoutControl2.Location = new System.Drawing.Point(12, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(713, 844);
            this.layoutControl2.TabIndex = 5;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.pceLeft);
            this.tablePanel1.Controls.Add(this.pceRight);
            this.tablePanel1.Controls.Add(this.lbcGroceryName);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Size = new System.Drawing.Size(689, 820);
            this.tablePanel1.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(737, 868);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lbcGroceryName
            // 
            this.lbcGroceryName.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcGroceryName.Appearance.Options.UseFont = true;
            this.lbcGroceryName.Appearance.Options.UseTextOptions = true;
            this.lbcGroceryName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcGroceryName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcGroceryName.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcGroceryName.AppearanceHovered.Options.UseFont = true;
            this.lbcGroceryName.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcGroceryName.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcGroceryName.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcGroceryName.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcGroceryName.AppearancePressed.Options.UseFont = true;
            this.lbcGroceryName.AppearancePressed.Options.UseTextOptions = true;
            this.lbcGroceryName.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcGroceryName.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.lbcGroceryName, 1);
            this.lbcGroceryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcGroceryName.Location = new System.Drawing.Point(72, 3);
            this.lbcGroceryName.Name = "lbcGroceryName";
            this.tablePanel1.SetRow(this.lbcGroceryName, 0);
            this.lbcGroceryName.Size = new System.Drawing.Size(545, 76);
            this.lbcGroceryName.TabIndex = 1;
            this.lbcGroceryName.Text = "상품명";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.uscIngredient4);
            this.tablePanel2.Controls.Add(this.uscIngredient3);
            this.tablePanel2.Controls.Add(this.uscIngredient2);
            this.tablePanel2.Controls.Add(this.uscIngredient1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(72, 85);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(545, 732);
            this.tablePanel2.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(713, 844);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tablePanel1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(693, 824);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(693, 469);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // uscIngredient4
            // 
            this.tablePanel2.SetColumn(this.uscIngredient4, 1);
            this.uscIngredient4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscIngredient4.Location = new System.Drawing.Point(276, 369);
            this.uscIngredient4.Name = "uscIngredient4";
            this.tablePanel2.SetRow(this.uscIngredient4, 1);
            this.uscIngredient4.Size = new System.Drawing.Size(267, 360);
            this.uscIngredient4.TabIndex = 4;
            // 
            // uscIngredient3
            // 
            this.tablePanel2.SetColumn(this.uscIngredient3, 0);
            this.uscIngredient3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscIngredient3.Location = new System.Drawing.Point(3, 369);
            this.uscIngredient3.Name = "uscIngredient3";
            this.tablePanel2.SetRow(this.uscIngredient3, 1);
            this.uscIngredient3.Size = new System.Drawing.Size(267, 360);
            this.uscIngredient3.TabIndex = 3;
            // 
            // uscIngredient2
            // 
            this.tablePanel2.SetColumn(this.uscIngredient2, 1);
            this.uscIngredient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscIngredient2.Location = new System.Drawing.Point(276, 3);
            this.uscIngredient2.Name = "uscIngredient2";
            this.tablePanel2.SetRow(this.uscIngredient2, 0);
            this.uscIngredient2.Size = new System.Drawing.Size(267, 360);
            this.uscIngredient2.TabIndex = 2;
            // 
            // uscIngredient1
            // 
            this.tablePanel2.SetColumn(this.uscIngredient1, 0);
            this.uscIngredient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscIngredient1.Location = new System.Drawing.Point(3, 3);
            this.uscIngredient1.Name = "uscIngredient1";
            this.tablePanel2.SetRow(this.uscIngredient1, 0);
            this.uscIngredient1.Size = new System.Drawing.Size(267, 360);
            this.uscIngredient1.TabIndex = 1;
            // 
            // pceLeft
            // 
            this.tablePanel1.SetColumn(this.pceLeft, 0);
            this.pceLeft.EditValue = ((object)(resources.GetObject("pceLeft.EditValue")));
            this.pceLeft.Location = new System.Drawing.Point(4, 281);
            this.pceLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pceLeft.Name = "pceLeft";
            this.pceLeft.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceLeft.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceLeft, 1);
            this.pceLeft.Size = new System.Drawing.Size(61, 340);
            this.pceLeft.StyleController = this.layoutControl1;
            this.pceLeft.TabIndex = 8;
            this.pceLeft.Click += new System.EventHandler(this.pceLeft_Click);
            // 
            // pceRight
            // 
            this.tablePanel1.SetColumn(this.pceRight, 2);
            this.pceRight.EditValue = ((object)(resources.GetObject("pceRight.EditValue")));
            this.pceRight.Location = new System.Drawing.Point(625, 281);
            this.pceRight.Margin = new System.Windows.Forms.Padding(5);
            this.pceRight.Name = "pceRight";
            this.pceRight.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceRight.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceRight, 1);
            this.pceRight.Size = new System.Drawing.Size(59, 340);
            this.pceRight.StyleController = this.layoutControl1;
            this.pceRight.TabIndex = 7;
            this.pceRight.Click += new System.EventHandler(this.pceRight_Click);
            // 
            // IngredientThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 868);
            this.Controls.Add(this.layoutControl1);
            this.Name = "IngredientThumbnail";
            this.Text = "IngredientThumbnail";
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceRight.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl lbcGroceryName;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private UserControl.IngredientCustomization uscIngredient4;
        private UserControl.IngredientCustomization uscIngredient3;
        private UserControl.IngredientCustomization uscIngredient2;
        private UserControl.IngredientCustomization uscIngredient1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PictureEdit pceRight;
        private DevExpress.XtraEditors.PictureEdit pceLeft;
    }
}