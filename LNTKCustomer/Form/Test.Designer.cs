namespace LNTKCustomer.Form
{
    partial class Test
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
            this.thumbnailContainer1 = new LNTKCustomer.UserControl.ThumbnailContainer();
            this.SuspendLayout();
            // 
            // thumbnailContainer1
            // 
            this.thumbnailContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailContainer1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailContainer1.Name = "thumbnailContainer1";
            this.thumbnailContainer1.Size = new System.Drawing.Size(512, 386);
            this.thumbnailContainer1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.thumbnailContainer1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.ThumbnailContainer thumbnailContainer1;
    }
}