namespace LNTKManager
{
    partial class GroceryUpdate
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txeGroceryId = new DevExpress.XtraEditors.TextEdit();
            this.cbbCategoryId = new System.Windows.Forms.ComboBox();
            this.txeUnit = new DevExpress.XtraEditors.TextEdit();
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bdsCategory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeGroceryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txeGroceryId);
            this.layoutControl1.Controls.Add(this.cbbCategoryId);
            this.layoutControl1.Controls.Add(this.txeUnit);
            this.layoutControl1.Controls.Add(this.txeName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(387, 188);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txeGroceryId
            // 
            this.txeGroceryId.Enabled = false;
            this.txeGroceryId.Location = new System.Drawing.Point(70, 12);
            this.txeGroceryId.Name = "txeGroceryId";
            this.txeGroceryId.Size = new System.Drawing.Size(305, 24);
            this.txeGroceryId.StyleController = this.layoutControl1;
            this.txeGroceryId.TabIndex = 4;
            // 
            // cbbCategoryId
            // 
            this.cbbCategoryId.DataSource = this.bdsCategory;
            this.cbbCategoryId.DisplayMember = "Item";
            this.cbbCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoryId.FormattingEnabled = true;
            this.cbbCategoryId.Location = new System.Drawing.Point(70, 40);
            this.cbbCategoryId.Name = "cbbCategoryId";
            this.cbbCategoryId.Size = new System.Drawing.Size(305, 23);
            this.cbbCategoryId.TabIndex = 4;
            this.cbbCategoryId.ValueMember = "CodeCategoryId";
            // 
            // txeUnit
            // 
            this.txeUnit.Location = new System.Drawing.Point(70, 70);
            this.txeUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txeUnit.Name = "txeUnit";
            this.txeUnit.Size = new System.Drawing.Size(305, 24);
            this.txeUnit.StyleController = this.layoutControl1;
            this.txeUnit.TabIndex = 5;
            this.txeUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txeUnit_KeyPress);
            // 
            // txeName
            // 
            this.txeName.Location = new System.Drawing.Point(70, 98);
            this.txeName.Margin = new System.Windows.Forms.Padding(4);
            this.txeName.Name = "txeName";
            this.txeName.Size = new System.Drawing.Size(305, 24);
            this.txeName.StyleController = this.layoutControl1;
            this.txeName.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(387, 188);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeGroceryId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem1.Text = "식재료ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbCategoryId;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "카테고리";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(367, 30);
            this.layoutControlItem5.Text = "카테고리";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(55, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txeUnit;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "단위";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem6.Text = "단위";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(55, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txeName;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "식품명";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem7.Text = "식품명";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(55, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(367, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(223, 134);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnUpdate;
            this.layoutControlItem3.Location = new System.Drawing.Point(79, 134);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(144, 34);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 134);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(79, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bdsCategory
            // 
            this.bdsCategory.DataSource = typeof(LNTKKiosk.Data.CodeCategory);
            // 
            // GroceryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 188);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroceryUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "식재료수정";
            this.Load += new System.EventHandler(this.GroceryUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeGroceryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txeGroceryId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbbCategoryId;
        private System.Windows.Forms.BindingSource bdsCategory;
        private DevExpress.XtraEditors.TextEdit txeUnit;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}