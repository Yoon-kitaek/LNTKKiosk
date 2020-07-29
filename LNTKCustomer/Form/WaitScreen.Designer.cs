namespace LNTKCustomer
{
    partial class WaitScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitScreen));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.imsWaitScreen2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imsWaitScreen1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsWaitScreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsWaitScreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.imsWaitScreen2);
            this.layoutControl1.Controls.Add(this.imsWaitScreen1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(766, 1127);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // imsWaitScreen2
            // 
            this.imsWaitScreen2.AllowLooping = true;
            this.imsWaitScreen2.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imsWaitScreen2.AutoSlideInterval = 2000;
            this.imsWaitScreen2.CurrentImageIndex = 0;
            this.imsWaitScreen2.Images.Add(((System.Drawing.Image)(resources.GetObject("imsWaitScreen2.Images"))));
            this.imsWaitScreen2.Images.Add(((System.Drawing.Image)(resources.GetObject("imsWaitScreen2.Images1"))));
            this.imsWaitScreen2.Location = new System.Drawing.Point(12, 552);
            this.imsWaitScreen2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imsWaitScreen2.Name = "imsWaitScreen2";
            this.imsWaitScreen2.Size = new System.Drawing.Size(742, 563);
            this.imsWaitScreen2.StyleController = this.layoutControl1;
            this.imsWaitScreen2.TabIndex = 5;
            this.imsWaitScreen2.Text = "imageSlider1";
            this.imsWaitScreen2.Click += new System.EventHandler(this.imsWaitScreen_Click);
            // 
            // imsWaitScreen1
            // 
            this.imsWaitScreen1.AllowLooping = true;
            this.imsWaitScreen1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imsWaitScreen1.AutoSlideInterval = 2000;
            this.imsWaitScreen1.CurrentImageIndex = 0;
            this.imsWaitScreen1.Images.Add(((System.Drawing.Image)(resources.GetObject("imsWaitScreen1.Images"))));
            this.imsWaitScreen1.Images.Add(((System.Drawing.Image)(resources.GetObject("imsWaitScreen1.Images1"))));
            this.imsWaitScreen1.Location = new System.Drawing.Point(12, 12);
            this.imsWaitScreen1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imsWaitScreen1.Name = "imsWaitScreen1";
            this.imsWaitScreen1.Size = new System.Drawing.Size(742, 536);
            this.imsWaitScreen1.StyleController = this.layoutControl1;
            this.imsWaitScreen1.TabIndex = 4;
            this.imsWaitScreen1.Text = "imageSlider1";
            this.imsWaitScreen1.Click += new System.EventHandler(this.imsWaitScreen_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(766, 1127);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.imsWaitScreen1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(746, 540);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.imsWaitScreen2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 540);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(746, 567);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // WaitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 1127);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WaitScreen";
            this.Text = "대기 화면";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imsWaitScreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsWaitScreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.Controls.ImageSlider imsWaitScreen1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Controls.ImageSlider imsWaitScreen2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

