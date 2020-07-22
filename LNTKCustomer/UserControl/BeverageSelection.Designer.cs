namespace LNTKCustomer.UserControl
{
    partial class BeverageSelection
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
            this.lbcBurgerCustomization = new DevExpress.XtraEditors.LabelControl();
            this.sbtBeverageCustomization = new DevExpress.XtraEditors.SimpleButton();
            this.pceThree = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pceThree.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcBurgerCustomization
            // 
            this.lbcBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbcBurgerCustomization.Appearance.Options.UseFont = true;
            this.lbcBurgerCustomization.Appearance.Options.UseTextOptions = true;
            this.lbcBurgerCustomization.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcBurgerCustomization.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcBurgerCustomization.Location = new System.Drawing.Point(79, 23);
            this.lbcBurgerCustomization.Name = "lbcBurgerCustomization";
            this.lbcBurgerCustomization.Size = new System.Drawing.Size(276, 30);
            this.lbcBurgerCustomization.TabIndex = 15;
            this.lbcBurgerCustomization.Text = "원하시는 음료를 선택해주세요";
            // 
            // sbtBeverageCustomization
            // 
            this.sbtBeverageCustomization.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtBeverageCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.sbtBeverageCustomization.Appearance.Options.UseBackColor = true;
            this.sbtBeverageCustomization.Appearance.Options.UseFont = true;
            this.sbtBeverageCustomization.Location = new System.Drawing.Point(394, 9);
            this.sbtBeverageCustomization.Name = "sbtBeverageCustomization";
            this.sbtBeverageCustomization.Size = new System.Drawing.Size(200, 60);
            this.sbtBeverageCustomization.TabIndex = 20;
            this.sbtBeverageCustomization.Text = "음료 추가/변경";
            // 
            // pceThree
            // 
            this.pceThree.EditValue = global::LNTKCustomer.Properties.Resources.three;
            this.pceThree.Location = new System.Drawing.Point(3, 3);
            this.pceThree.Name = "pceThree";
            this.pceThree.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceThree.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceThree.Size = new System.Drawing.Size(70, 70);
            this.pceThree.TabIndex = 8;
            // 
            // BeverageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbtBeverageCustomization);
            this.Controls.Add(this.lbcBurgerCustomization);
            this.Controls.Add(this.pceThree);
            this.Name = "BeverageSelection";
            this.Size = new System.Drawing.Size(812, 77);
            ((System.ComponentModel.ISupportInitialize)(this.pceThree.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pceThree;
        private DevExpress.XtraEditors.LabelControl lbcBurgerCustomization;
        private DevExpress.XtraEditors.SimpleButton sbtBeverageCustomization;
    }
}
