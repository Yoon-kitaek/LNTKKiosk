namespace LNTKCustomer.Form
{
    partial class CustomerMenu
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnRecommended = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnBurgerSet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnBeverageCoffee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnKingMorning = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnDiscountLunch = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnRecommendedMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
           // this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.accordionControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(637, 336, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.BackColor2 = System.Drawing.Color.Transparent;
            this.accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.Transparent;
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("HYHeadLine M", 13F);
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.Transparent;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.accordionControl1.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.BackColor = System.Drawing.Color.Blue;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.ItemWithContainer.Normal.BackColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.ItemWithContainer.Normal.BackColor2 = System.Drawing.Color.White;
            this.accordionControl1.Appearance.ItemWithContainer.Normal.Options.UseBackColor = true;
            this.accordionControl1.Appearance.ItemWithContainer.Pressed.BackColor = System.Drawing.Color.Blue;
            this.accordionControl1.Appearance.ItemWithContainer.Pressed.Options.UseBackColor = true;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnRecommended,
            this.accordionControlSeparator1,
            this.btnBurgerSet,
            this.accordionControlSeparator2,
            this.btnBeverageCoffee,
            this.accordionControlSeparator3,
            this.btnKingMorning,
            this.accordionControlSeparator4,
            this.btnDiscountLunch,
            this.accordionControlSeparator5});
            this.accordionControl1.Location = new System.Drawing.Point(12, 12);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(173, 426);
            this.accordionControl1.StyleController = this.layoutControl1;
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // btnRecommended
            // 
            this.btnRecommended.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.btnRecommended.Name = "btnRecommended";
            this.btnRecommended.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRecommended.Text = "추천 메뉴";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnBurgerSet
            // 
            this.btnBurgerSet.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btnBurgerSet.Name = "btnBurgerSet";
            this.btnBurgerSet.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBurgerSet.Text = "버거&세트";
            this.btnBurgerSet.Click += new System.EventHandler(this.btnBurgerSet_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // btnBeverageCoffee
            // 
            this.btnBeverageCoffee.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btnBeverageCoffee.Name = "btnBeverageCoffee";
            this.btnBeverageCoffee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBeverageCoffee.Text = "음료&커피";
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // btnKingMorning
            // 
            this.btnKingMorning.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btnKingMorning.Name = "btnKingMorning";
            this.btnKingMorning.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnKingMorning.Text = "킹모닝";
            this.btnKingMorning.Click += new System.EventHandler(this.btnKingMorning_Click);
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // btnDiscountLunch
            // 
            this.btnDiscountLunch.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btnDiscountLunch.Name = "btnDiscountLunch";
            this.btnDiscountLunch.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDiscountLunch.Text = "런치할인";
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.accordionControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(177, 430);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(177, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(603, 430);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnRecommendedMenu
            // 
            this.btnRecommendedMenu.Appearance.Disabled.BackColor = System.Drawing.Color.White;
            this.btnRecommendedMenu.Appearance.Disabled.Options.UseBackColor = true;
            this.btnRecommendedMenu.Appearance.Hovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecommendedMenu.Appearance.Hovered.Font = new System.Drawing.Font("Headline R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRecommendedMenu.Appearance.Hovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRecommendedMenu.Appearance.Hovered.Options.UseBackColor = true;
            this.btnRecommendedMenu.Appearance.Hovered.Options.UseFont = true;
            this.btnRecommendedMenu.Appearance.Normal.BackColor = System.Drawing.Color.White;
            this.btnRecommendedMenu.Appearance.Normal.Options.UseBackColor = true;
            this.btnRecommendedMenu.Appearance.Pressed.BackColor = System.Drawing.Color.Tomato;
            this.btnRecommendedMenu.Appearance.Pressed.Options.UseBackColor = true;
            this.btnRecommendedMenu.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.btnRecommendedMenu.Name = "btnRecommendedMenu";
            this.btnRecommendedMenu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRecommendedMenu.Text = "추천 메뉴";
            // 
            // ribbonPage2
            // 
   // this.ribbonPage2.Name = "ribbonPage2";
       //    this.ribbonPage2.Text = "ribbonPage2";
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::LNTKCustomer.Properties.Resources._3D햄버거;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBurgerSet;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBeverageCoffee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKingMorning;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDiscountLunch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRecommended;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRecommendedMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
  
    }
}