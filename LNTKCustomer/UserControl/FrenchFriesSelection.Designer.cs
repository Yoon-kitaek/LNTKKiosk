namespace LNTKCustomer.UserControl
{
    partial class FrenchFriesSelection
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
            this.sbtFriesCustomization = new DevExpress.XtraEditors.SimpleButton();
            this.pceTwo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pceTwo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcBurgerCustomization
            // 
            this.lbcBurgerCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbcBurgerCustomization.Appearance.Options.UseFont = true;
            this.lbcBurgerCustomization.Appearance.Options.UseTextOptions = true;
            this.lbcBurgerCustomization.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcBurgerCustomization.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbcBurgerCustomization.Location = new System.Drawing.Point(79, 21);
            this.lbcBurgerCustomization.Name = "lbcBurgerCustomization";
            this.lbcBurgerCustomization.Size = new System.Drawing.Size(426, 30);
            this.lbcBurgerCustomization.TabIndex = 14;
            this.lbcBurgerCustomization.Text = "원하시는 감자튀김/사이드메뉴를 선택해주세요";
            // 
            // sbtFriesCustomization
            // 
            this.sbtFriesCustomization.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.sbtFriesCustomization.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.sbtFriesCustomization.Appearance.Options.UseBackColor = true;
            this.sbtFriesCustomization.Appearance.Options.UseFont = true;
            this.sbtFriesCustomization.Location = new System.Drawing.Point(554, 5);
            this.sbtFriesCustomization.Name = "sbtFriesCustomization";
            this.sbtFriesCustomization.Size = new System.Drawing.Size(200, 60);
            this.sbtFriesCustomization.TabIndex = 15;
            this.sbtFriesCustomization.Text = "감자튀김 추가/변경";
            // 
            // pceTwo
            // 
            this.pceTwo.EditValue = global::LNTKCustomer.Properties.Resources.two;
            this.pceTwo.Location = new System.Drawing.Point(3, 3);
            this.pceTwo.Name = "pceTwo";
            this.pceTwo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceTwo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pceTwo.Size = new System.Drawing.Size(70, 70);
            this.pceTwo.TabIndex = 7;
            // 
            // FrenchFriesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbtFriesCustomization);
            this.Controls.Add(this.lbcBurgerCustomization);
            this.Controls.Add(this.pceTwo);
            this.Name = "FrenchFriesSelection";
            this.Size = new System.Drawing.Size(824, 76);
            ((System.ComponentModel.ISupportInitialize)(this.pceTwo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pceTwo;
        private DevExpress.XtraEditors.LabelControl lbcBurgerCustomization;
        private DevExpress.XtraEditors.SimpleButton sbtFriesCustomization;
    }
}
