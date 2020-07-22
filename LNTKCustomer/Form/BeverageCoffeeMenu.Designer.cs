namespace LNTKCustomer.Form
{
    partial class BeverageCoffeeMenu
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
            this.uscThumbnail1 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail2 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail3 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail4 = new LNTKCustomer.UserControl.Thumbnail();
            this.SuspendLayout();
            // 
            // uscThumbnail1
            // 
            this.uscThumbnail1.Label = "label";
            this.uscThumbnail1.Location = new System.Drawing.Point(12, 2);
            this.uscThumbnail1.Name = "uscThumbnail1";
            this.uscThumbnail1.Size = new System.Drawing.Size(472, 329);
            this.uscThumbnail1.TabIndex = 0;
            // 
            // uscThumbnail2
            // 
            this.uscThumbnail2.Label = "label";
            this.uscThumbnail2.Location = new System.Drawing.Point(507, 2);
            this.uscThumbnail2.Name = "uscThumbnail2";
            this.uscThumbnail2.Size = new System.Drawing.Size(472, 329);
            this.uscThumbnail2.TabIndex = 1;
            // 
            // uscThumbnail3
            // 
            this.uscThumbnail3.Label = "label";
            this.uscThumbnail3.Location = new System.Drawing.Point(12, 337);
            this.uscThumbnail3.Name = "uscThumbnail3";
            this.uscThumbnail3.Size = new System.Drawing.Size(472, 329);
            this.uscThumbnail3.TabIndex = 2;
            // 
            // uscThumbnail4
            // 
            this.uscThumbnail4.Label = "label";
            this.uscThumbnail4.Location = new System.Drawing.Point(507, 337);
            this.uscThumbnail4.Name = "uscThumbnail4";
            this.uscThumbnail4.Size = new System.Drawing.Size(472, 329);
            this.uscThumbnail4.TabIndex = 3;
            // 
            // BeverageCoffeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 692);
            this.Controls.Add(this.uscThumbnail4);
            this.Controls.Add(this.uscThumbnail3);
            this.Controls.Add(this.uscThumbnail2);
            this.Controls.Add(this.uscThumbnail1);
            this.Name = "BeverageCoffeeMenu";
            this.Text = "BeverageCoffeeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.Thumbnail uscThumbnail1;
        private UserControl.Thumbnail uscThumbnail2;
        private UserControl.Thumbnail uscThumbnail3;
        private UserControl.Thumbnail uscThumbnail4;
    }
}