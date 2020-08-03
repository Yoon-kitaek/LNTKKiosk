namespace LNTKCustomer.UserControl
{
    partial class BugerCustomizing_BreadSelection
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbBasicBread = new DevExpress.XtraEditors.CheckEdit();
            this.cbSesameBread = new DevExpress.XtraEditors.CheckEdit();
            this.cbHomilBread = new DevExpress.XtraEditors.CheckEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBasicBread.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSesameBread.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHomilBread.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(737, 388, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1024, 908);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.btnNext);
            this.tablePanel1.Controls.Add(this.cbHomilBread);
            this.tablePanel1.Controls.Add(this.cbSesameBread);
            this.tablePanel1.Controls.Add(this.cbBasicBread);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(1000, 884);
            this.tablePanel1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1024, 908);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tablePanel1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1004, 888);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // cbBasicBread
            // 
            this.cbBasicBread.BackgroundImage = global::LNTKCustomer.Properties.Resources._963513_20170616175437_922_0001;
            this.cbBasicBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablePanel1.SetColumn(this.cbBasicBread, 1);
            this.cbBasicBread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBasicBread.Location = new System.Drawing.Point(103, 91);
            this.cbBasicBread.Name = "cbBasicBread";
            this.cbBasicBread.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.cbBasicBread.Properties.Appearance.Options.UseFont = true;
            this.cbBasicBread.Properties.Appearance.Options.UseImage = true;
            this.cbBasicBread.Properties.Appearance.Options.UseTextOptions = true;
            this.cbBasicBread.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbBasicBread.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cbBasicBread.Properties.Caption = "밀빵";
            this.cbBasicBread.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.cbBasicBread.Properties.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.Red;
            this.cbBasicBread.Properties.ImageOptions.ImageChecked = global::LNTKCustomer.Properties.Resources._963513_20170616175437_922_0001;
            this.cbBasicBread.Properties.ImageOptions.ImageGrayed = global::LNTKCustomer.Properties.Resources._963513_20170616175437_922_0001;
            this.cbBasicBread.Properties.ImageOptions.ImageUnchecked = global::LNTKCustomer.Properties.Resources._963513_20170616175437_922_0001;
            this.cbBasicBread.Properties.ReadOnly = true;
            this.tablePanel1.SetRow(this.cbBasicBread, 1);
            this.cbBasicBread.Size = new System.Drawing.Size(394, 348);
            this.cbBasicBread.TabIndex = 0;
            // 
            // cbSesameBread
            // 
            this.cbSesameBread.BackgroundImage = global::LNTKCustomer.Properties.Resources.참깨방;
            this.cbSesameBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.cbSesameBread, 2);
            this.cbSesameBread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSesameBread.Location = new System.Drawing.Point(503, 91);
            this.cbSesameBread.Name = "cbSesameBread";
            this.cbSesameBread.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.cbSesameBread.Properties.Appearance.Options.UseFont = true;
            this.cbSesameBread.Properties.Appearance.Options.UseTextOptions = true;
            this.cbSesameBread.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbSesameBread.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cbSesameBread.Properties.Caption = "참깨빵";
            this.tablePanel1.SetRow(this.cbSesameBread, 1);
            this.cbSesameBread.Size = new System.Drawing.Size(394, 348);
            this.cbSesameBread.TabIndex = 1;
            // 
            // cbHomilBread
            // 
            this.cbHomilBread.BackgroundImage = global::LNTKCustomer.Properties.Resources.호밀빵;
            this.cbHomilBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablePanel1.SetColumn(this.cbHomilBread, 1);
            this.cbHomilBread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHomilBread.Location = new System.Drawing.Point(103, 445);
            this.cbHomilBread.Name = "cbHomilBread";
            this.cbHomilBread.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.cbHomilBread.Properties.Appearance.Options.UseFont = true;
            this.cbHomilBread.Properties.Appearance.Options.UseTextOptions = true;
            this.cbHomilBread.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbHomilBread.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cbHomilBread.Properties.Caption = "호밀빵";
            this.tablePanel1.SetRow(this.cbHomilBread, 2);
            this.cbHomilBread.Size = new System.Drawing.Size(394, 348);
            this.cbHomilBread.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnNext, 2);
            this.btnNext.Location = new System.Drawing.Point(503, 817);
            this.btnNext.Name = "btnNext";
            this.tablePanel1.SetRow(this.btnNext, 3);
            this.btnNext.Size = new System.Drawing.Size(394, 46);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "다음 단계";
            // 
            // BugerCustomizing_BreadSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "BugerCustomizing_BreadSelection";
            this.Size = new System.Drawing.Size(1024, 908);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBasicBread.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSesameBread.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHomilBread.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.CheckEdit cbHomilBread;
        private DevExpress.XtraEditors.CheckEdit cbSesameBread;
        private DevExpress.XtraEditors.CheckEdit cbBasicBread;
    }
}
