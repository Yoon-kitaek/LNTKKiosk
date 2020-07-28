namespace LNTKCustomer.UserControl
{
    partial class SideSelection
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
            this.pceTwo = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.sbtFriesCustomization = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lbcBurgerCustomization = new DevExpress.XtraEditors.LabelControl();
            this.pceBurgerPicture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pceTwo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceBurgerPicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pceTwo
            // 
            this.tablePanel1.SetColumn(this.pceTwo, 0);
            this.pceTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceTwo.EditValue = global::LNTKCustomer.Properties.Resources.two;
            this.pceTwo.Location = new System.Drawing.Point(3, 18);
            this.pceTwo.Name = "pceTwo";
            this.pceTwo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceTwo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pceTwo, 1);
            this.pceTwo.Size = new System.Drawing.Size(114, 114);
            this.pceTwo.TabIndex = 7;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Controls.Add(this.pceBurgerPicture);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.pceTwo);
            this.tablePanel1.Controls.Add(this.lbcBurgerCustomization);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(1198, 150);
            this.tablePanel1.TabIndex = 16;
            // 
            // sbtFriesCustomization
            // 
            this.sbtFriesCustomization.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtFriesCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.sbtFriesCustomization.Appearance.Options.UseBackColor = true;
            this.sbtFriesCustomization.Appearance.Options.UseFont = true;
            this.sbtFriesCustomization.AppearanceDisabled.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtFriesCustomization.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.sbtFriesCustomization.AppearanceDisabled.Options.UseBackColor = true;
            this.sbtFriesCustomization.AppearanceDisabled.Options.UseFont = true;
            this.sbtFriesCustomization.AppearanceHovered.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtFriesCustomization.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.sbtFriesCustomization.AppearanceHovered.Options.UseBackColor = true;
            this.sbtFriesCustomization.AppearanceHovered.Options.UseFont = true;
            this.sbtFriesCustomization.AppearancePressed.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtFriesCustomization.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.sbtFriesCustomization.AppearancePressed.Options.UseBackColor = true;
            this.sbtFriesCustomization.AppearancePressed.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.sbtFriesCustomization, 0);
            this.sbtFriesCustomization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbtFriesCustomization.Location = new System.Drawing.Point(3, 26);
            this.sbtFriesCustomization.Name = "sbtFriesCustomization";
            this.tablePanel2.SetRow(this.sbtFriesCustomization, 1);
            this.sbtFriesCustomization.Size = new System.Drawing.Size(228, 62);
            this.sbtFriesCustomization.TabIndex = 15;
            this.sbtFriesCustomization.Text = "사이드 추가/변경";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 4);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.sbtFriesCustomization);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(961, 18);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel2.Size = new System.Drawing.Size(234, 114);
            this.tablePanel2.TabIndex = 16;
            // 
            // lbcBurgerCustomization
            // 
            this.lbcBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcBurgerCustomization.Appearance.Options.UseFont = true;
            this.lbcBurgerCustomization.Appearance.Options.UseTextOptions = true;
            this.lbcBurgerCustomization.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcBurgerCustomization.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcBurgerCustomization.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcBurgerCustomization.AppearanceDisabled.Options.UseFont = true;
            this.lbcBurgerCustomization.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcBurgerCustomization.AppearanceHovered.Options.UseFont = true;
            this.lbcBurgerCustomization.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbcBurgerCustomization.AppearancePressed.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbcBurgerCustomization, 3);
            this.lbcBurgerCustomization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcBurgerCustomization.Location = new System.Drawing.Point(482, 18);
            this.lbcBurgerCustomization.Name = "lbcBurgerCustomization";
            this.tablePanel1.SetRow(this.lbcBurgerCustomization, 1);
            this.lbcBurgerCustomization.Size = new System.Drawing.Size(473, 114);
            this.lbcBurgerCustomization.TabIndex = 14;
            this.lbcBurgerCustomization.Text = "원하시는 사이드메뉴를 선택해주세요";
            // 
            // pceBurgerPicture
            // 
            this.tablePanel1.SetColumn(this.pceBurgerPicture, 2);
            this.pceBurgerPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceBurgerPicture.Location = new System.Drawing.Point(183, 18);
            this.pceBurgerPicture.Name = "pceBurgerPicture";
            this.pceBurgerPicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.tablePanel1.SetRow(this.pceBurgerPicture, 1);
            this.pceBurgerPicture.Size = new System.Drawing.Size(294, 114);
            this.pceBurgerPicture.TabIndex = 17;
            // 
            // SideSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "SideSelection";
            this.Size = new System.Drawing.Size(1198, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pceTwo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceBurgerPicture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pceTwo;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton sbtFriesCustomization;
        private DevExpress.XtraEditors.LabelControl lbcBurgerCustomization;
        private DevExpress.XtraEditors.PictureEdit pceBurgerPicture;
    }
}
