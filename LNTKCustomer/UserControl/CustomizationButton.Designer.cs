namespace LNTKCustomer.UserControl
{
    partial class CustomizationButton
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
            this.sbtBurgerCustomization = new DevExpress.XtraEditors.SimpleButton();
            this.lbcBurgerCustomization = new DevExpress.XtraEditors.LabelControl();
            this.pceBurgerPicture = new DevExpress.XtraEditors.PictureEdit();
            this.pceOne = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pceBurgerPicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceOne.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtBurgerCustomization
            // 
            this.sbtBurgerCustomization.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.sbtBurgerCustomization.Appearance.Options.UseBackColor = true;
            this.sbtBurgerCustomization.Appearance.Options.UseFont = true;
            this.sbtBurgerCustomization.Location = new System.Drawing.Point(926, 127);
            this.sbtBurgerCustomization.Name = "sbtBurgerCustomization";
            this.sbtBurgerCustomization.Size = new System.Drawing.Size(200, 60);
            this.sbtBurgerCustomization.TabIndex = 14;
            this.sbtBurgerCustomization.Text = "재료 추가/변경";
            // 
            // lbcBurgerCustomization
            // 
            this.lbcBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbcBurgerCustomization.Appearance.Options.UseFont = true;
            this.lbcBurgerCustomization.Appearance.Options.UseTextOptions = true;
            this.lbcBurgerCustomization.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcBurgerCustomization.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcBurgerCustomization.Location = new System.Drawing.Point(557, 142);
            this.lbcBurgerCustomization.Name = "lbcBurgerCustomization";
            this.lbcBurgerCustomization.Size = new System.Drawing.Size(326, 30);
            this.lbcBurgerCustomization.TabIndex = 13;
            this.lbcBurgerCustomization.Text = "추가/변경하실 재료를 선택해주세요";
            // 
            // pceBurgerPicture
            // 
            this.pceBurgerPicture.Location = new System.Drawing.Point(81, 14);
            this.pceBurgerPicture.Name = "pceBurgerPicture";
            this.pceBurgerPicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceBurgerPicture.Size = new System.Drawing.Size(453, 292);
            this.pceBurgerPicture.TabIndex = 12;
            // 
            // pceOne
            // 
            this.pceOne.EditValue = global::LNTKCustomer.Properties.Resources.one;
            this.pceOne.Location = new System.Drawing.Point(3, 24);
            this.pceOne.Name = "pceOne";
            this.pceOne.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceOne.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceOne.Size = new System.Drawing.Size(70, 70);
            this.pceOne.TabIndex = 11;
            // 
            // CustomizationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbtBurgerCustomization);
            this.Controls.Add(this.lbcBurgerCustomization);
            this.Controls.Add(this.pceBurgerPicture);
            this.Controls.Add(this.pceOne);
            this.Name = "CustomizationButton";
            this.Size = new System.Drawing.Size(1161, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pceBurgerPicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceOne.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtBurgerCustomization;
        private DevExpress.XtraEditors.LabelControl lbcBurgerCustomization;
        private DevExpress.XtraEditors.PictureEdit pceBurgerPicture;
        private DevExpress.XtraEditors.PictureEdit pceOne;
    }
}
