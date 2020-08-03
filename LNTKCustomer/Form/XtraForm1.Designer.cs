namespace LNTKCustomer.Form
{
    partial class XtraForm1
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
            this.bugerCustomizing_BreadSelection1 = new LNTKCustomer.UserControl.BugerCustomizing_BreadSelection();
            this.SuspendLayout();
            // 
            // bugerCustomizing_BreadSelection1
            // 
            this.bugerCustomizing_BreadSelection1.Location = new System.Drawing.Point(99, -82);
            this.bugerCustomizing_BreadSelection1.Name = "bugerCustomizing_BreadSelection1";
            this.bugerCustomizing_BreadSelection1.Size = new System.Drawing.Size(1024, 908);
            this.bugerCustomizing_BreadSelection1.TabIndex = 1;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 942);
            this.Controls.Add(this.bugerCustomizing_BreadSelection1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.BugerCustomizing_BreadSelection bugerCustomizing_BreadSelection1;
    }
}