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
            this.pceThree = new DevExpress.XtraEditors.PictureEdit();
            this.lbcBurgerCustomization = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pceThree.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pceThree
            // 
            this.pceThree.EditValue = global::LNTKCustomer.Properties.Resources.three;
            this.pceThree.Location = new System.Drawing.Point(18, 15);
            this.pceThree.Name = "pceThree";
            this.pceThree.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceThree.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceThree.Size = new System.Drawing.Size(90, 90);
            this.pceThree.TabIndex = 8;
            // 
            // lbcBurgerCustomization
            // 
            this.lbcBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbcBurgerCustomization.Appearance.Options.UseFont = true;
            this.lbcBurgerCustomization.Appearance.Options.UseTextOptions = true;
            this.lbcBurgerCustomization.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcBurgerCustomization.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcBurgerCustomization.Location = new System.Drawing.Point(137, 39);
            this.lbcBurgerCustomization.Name = "lbcBurgerCustomization";
            this.lbcBurgerCustomization.Size = new System.Drawing.Size(399, 41);
            this.lbcBurgerCustomization.TabIndex = 15;
            this.lbcBurgerCustomization.Text = "원하시는 음료를 선택해주세요";
            // 
            // BeverageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbcBurgerCustomization);
            this.Controls.Add(this.pceThree);
            this.Name = "BeverageSelection";
            this.Size = new System.Drawing.Size(931, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pceThree.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pceThree;
        private DevExpress.XtraEditors.LabelControl lbcBurgerCustomization;
    }
}
