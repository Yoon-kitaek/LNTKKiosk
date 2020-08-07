namespace LNTKCustomer.Form
{
    partial class CashPayment
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lbcInstruction = new DevExpress.XtraEditors.LabelControl();
            this.pceCashInput = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceCashInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1154, 528);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel1.Controls.Add(this.lbcInstruction);
            this.tablePanel1.Controls.Add(this.pceCashInput);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(1130, 504);
            this.tablePanel1.TabIndex = 4;
            // 
            // lbcInstruction
            // 
            this.lbcInstruction.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcInstruction.Appearance.Options.UseFont = true;
            this.lbcInstruction.Appearance.Options.UseTextOptions = true;
            this.lbcInstruction.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcInstruction.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcInstruction.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcInstruction.AppearanceDisabled.Options.UseFont = true;
            this.lbcInstruction.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcInstruction.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcInstruction.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcInstruction.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcInstruction.AppearanceHovered.Options.UseFont = true;
            this.lbcInstruction.AppearanceHovered.Options.UseTextOptions = true;
            this.lbcInstruction.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcInstruction.AppearanceHovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcInstruction.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcInstruction.AppearancePressed.Options.UseFont = true;
            this.lbcInstruction.AppearancePressed.Options.UseTextOptions = true;
            this.lbcInstruction.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcInstruction.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tablePanel1.SetColumn(this.lbcInstruction, 1);
            this.lbcInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcInstruction.Location = new System.Drawing.Point(173, 339);
            this.lbcInstruction.Name = "lbcInstruction";
            this.tablePanel1.SetRow(this.lbcInstruction, 3);
            this.lbcInstruction.Size = new System.Drawing.Size(785, 106);
            this.lbcInstruction.TabIndex = 1;
            this.lbcInstruction.Text = "현금투입구에 돈을 투입해주세요\r\n";
            // 
            // pceCashInput
            // 
            this.tablePanel1.SetColumn(this.pceCashInput, 1);
            this.pceCashInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceCashInput.EditValue = global::LNTKCustomer.Properties.Resources.CashInput;
            this.pceCashInput.Location = new System.Drawing.Point(173, 59);
            this.pceCashInput.Name = "pceCashInput";
            this.pceCashInput.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceCashInput.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceCashInput, 1);
            this.pceCashInput.Size = new System.Drawing.Size(785, 218);
            this.pceCashInput.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1154, 528);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1134, 508);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 528);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CashPayment";
            this.Text = "CashPayment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CashPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceCashInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PictureEdit pceCashInput;
        private DevExpress.XtraEditors.LabelControl lbcInstruction;
    }
}