namespace LNTKCustomer.UserControl
{
    partial class ThumbnailContainer
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.uscThumbnail6 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail5 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail4 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail3 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail2 = new LNTKCustomer.UserControl.Thumbnail();
            this.uscThumbnail1 = new LNTKCustomer.UserControl.Thumbnail();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
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
            this.layoutControl1.Size = new System.Drawing.Size(1119, 518);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.uscThumbnail6);
            this.tablePanel1.Controls.Add(this.uscThumbnail5);
            this.tablePanel1.Controls.Add(this.uscThumbnail4);
            this.tablePanel1.Controls.Add(this.uscThumbnail3);
            this.tablePanel1.Controls.Add(this.uscThumbnail2);
            this.tablePanel1.Controls.Add(this.uscThumbnail1);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(1095, 494);
            this.tablePanel1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1119, 518);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1099, 498);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // uscThumbnail6
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail6, 2);
            this.uscThumbnail6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail6.Label = "label";
            this.uscThumbnail6.Location = new System.Drawing.Point(745, 250);
            this.uscThumbnail6.Name = "uscThumbnail6";
            this.tablePanel1.SetRow(this.uscThumbnail6, 1);
            this.uscThumbnail6.Size = new System.Drawing.Size(347, 241);
            this.uscThumbnail6.TabIndex = 5;
            this.uscThumbnail6.ThumbnailClicked += new System.EventHandler<LNTKCustomer.UserControl.Thumbnail.ThumbnailClickedEventArgs>(this.uscThumbnail6_ThumbnailClicked);
            // 
            // uscThumbnail5
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail5, 1);
            this.uscThumbnail5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail5.Label = "label";
            this.uscThumbnail5.Location = new System.Drawing.Point(392, 250);
            this.uscThumbnail5.Name = "uscThumbnail5";
            this.tablePanel1.SetRow(this.uscThumbnail5, 1);
            this.uscThumbnail5.Size = new System.Drawing.Size(347, 241);
            this.uscThumbnail5.TabIndex = 4;
            // 
            // uscThumbnail4
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail4, 0);
            this.uscThumbnail4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail4.Label = "label";
            this.uscThumbnail4.Location = new System.Drawing.Point(3, 250);
            this.uscThumbnail4.Name = "uscThumbnail4";
            this.tablePanel1.SetRow(this.uscThumbnail4, 1);
            this.uscThumbnail4.Size = new System.Drawing.Size(383, 241);
            this.uscThumbnail4.TabIndex = 3;
            // 
            // uscThumbnail3
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail3, 2);
            this.uscThumbnail3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail3.Label = "label";
            this.uscThumbnail3.Location = new System.Drawing.Point(745, 3);
            this.uscThumbnail3.Name = "uscThumbnail3";
            this.tablePanel1.SetRow(this.uscThumbnail3, 0);
            this.uscThumbnail3.Size = new System.Drawing.Size(347, 241);
            this.uscThumbnail3.TabIndex = 2;
            // 
            // uscThumbnail2
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail2, 1);
            this.uscThumbnail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail2.Label = "label";
            this.uscThumbnail2.Location = new System.Drawing.Point(392, 3);
            this.uscThumbnail2.Name = "uscThumbnail2";
            this.tablePanel1.SetRow(this.uscThumbnail2, 0);
            this.uscThumbnail2.Size = new System.Drawing.Size(347, 241);
            this.uscThumbnail2.TabIndex = 1;
            // 
            // uscThumbnail1
            // 
            this.tablePanel1.SetColumn(this.uscThumbnail1, 0);
            this.uscThumbnail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscThumbnail1.Label = "label";
            this.uscThumbnail1.Location = new System.Drawing.Point(3, 3);
            this.uscThumbnail1.Name = "uscThumbnail1";
            this.tablePanel1.SetRow(this.uscThumbnail1, 0);
            this.uscThumbnail1.Size = new System.Drawing.Size(383, 241);
            this.uscThumbnail1.TabIndex = 0;
            this.uscThumbnail1.Click += new System.EventHandler(this.uscThumbnail1_Click);
            // 
            // ThumbnailContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ThumbnailContainer";
            this.Size = new System.Drawing.Size(1119, 518);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private Thumbnail uscThumbnail6;
        private Thumbnail uscThumbnail5;
        private Thumbnail uscThumbnail4;
        private Thumbnail uscThumbnail3;
        private Thumbnail uscThumbnail2;
        private Thumbnail uscThumbnail1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
