namespace LNTKManager
{
    partial class ButtonContainer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uscTabButton0 = new LNTKManager.TabButton();
            this.uscTabButton1 = new LNTKManager.TabButton();
            this.uscTabButton2 = new LNTKManager.TabButton();
            this.uscTabButton3 = new LNTKManager.TabButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.uscTabButton0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscTabButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscTabButton2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscTabButton3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uscTabButton0
            // 
            this.uscTabButton0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTabButton0.Label = "버거";
            this.uscTabButton0.Location = new System.Drawing.Point(3, 3);
            this.uscTabButton0.Name = "uscTabButton0";
            this.uscTabButton0.Size = new System.Drawing.Size(133, 253);
            this.uscTabButton0.TabIndex = 0;
            this.uscTabButton0.ButtonClicked += new System.EventHandler<LNTKManager.TabButton.ButtonClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscTabButton1
            // 
            this.uscTabButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTabButton1.Label = "음료";
            this.uscTabButton1.Location = new System.Drawing.Point(142, 3);
            this.uscTabButton1.Name = "uscTabButton1";
            this.uscTabButton1.Size = new System.Drawing.Size(133, 253);
            this.uscTabButton1.TabIndex = 1;
            this.uscTabButton1.ButtonClicked += new System.EventHandler<LNTKManager.TabButton.ButtonClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscTabButton2
            // 
            this.uscTabButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTabButton2.Label = "사이드";
            this.uscTabButton2.Location = new System.Drawing.Point(281, 3);
            this.uscTabButton2.Name = "uscTabButton2";
            this.uscTabButton2.Size = new System.Drawing.Size(133, 253);
            this.uscTabButton2.TabIndex = 2;
            this.uscTabButton2.ButtonClicked += new System.EventHandler<LNTKManager.TabButton.ButtonClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // uscTabButton3
            // 
            this.uscTabButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTabButton3.Label = "음료";
            this.uscTabButton3.Location = new System.Drawing.Point(420, 3);
            this.uscTabButton3.Name = "uscTabButton3";
            this.uscTabButton3.Size = new System.Drawing.Size(136, 253);
            this.uscTabButton3.TabIndex = 3;
            this.uscTabButton3.ButtonClicked += new System.EventHandler<LNTKManager.TabButton.ButtonClickedEventArgs>(this.uscTabButton_ButtonClicked);
            // 
            // ButtonContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ButtonContainer";
            this.Size = new System.Drawing.Size(559, 259);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TabButton uscTabButton0;
        private TabButton uscTabButton1;
        private TabButton uscTabButton2;
        private TabButton uscTabButton3;
    }
}
