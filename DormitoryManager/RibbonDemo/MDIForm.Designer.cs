namespace DormitoryManager
{
   partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DropDownButton1 = new System.Windows.Forms.RibbonButton();
            this.DropDownButton2 = new System.Windows.Forms.RibbonButton();
            this.SubMenuButton1 = new System.Windows.Forms.RibbonButton();
            this.SubMenuButton2 = new System.Windows.Forms.RibbonButton();
            this.DropDownButton3 = new System.Windows.Forms.RibbonButton();
            this.DropDownButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.SuspendLayout();
            // 
            // DropDownButton1
            // 
            this.DropDownButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton1.Image")));
            this.DropDownButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("DropDownButton1.SmallImage")));
            this.DropDownButton1.Text = "Some button";
            // 
            // DropDownButton2
            // 
            this.DropDownButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DropDownButton2.DropDownItems.Add(this.SubMenuButton1);
            this.DropDownButton2.DropDownItems.Add(this.SubMenuButton2);
            this.DropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton2.Image")));
            this.DropDownButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("DropDownButton2.SmallImage")));
            this.DropDownButton2.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.DropDownButton2.Text = "Submenu";
            // 
            // SubMenuButton1
            // 
            this.SubMenuButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.SubMenuButton1.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuButton1.Image")));
            this.SubMenuButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("SubMenuButton1.SmallImage")));
            this.SubMenuButton1.Text = "1";
            // 
            // SubMenuButton2
            // 
            this.SubMenuButton2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.SubMenuButton2.Image = ((System.Drawing.Image)(resources.GetObject("SubMenuButton2.Image")));
            this.SubMenuButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("SubMenuButton2.SmallImage")));
            this.SubMenuButton2.Text = "2";
            // 
            // DropDownButton3
            // 
            this.DropDownButton3.CheckOnClick = true;
            this.DropDownButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton3.Image")));
            this.DropDownButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("DropDownButton3.SmallImage")));
            this.DropDownButton3.Text = "CheckOnClick!";
            // 
            // DropDownButton4
            // 
            this.DropDownButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton4.Image")));
            this.DropDownButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("DropDownButton4.SmallImage")));
            this.DropDownButton4.Text = "Some other button";
            // 
            // ribbon1
            // 
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton1);
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton2);
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton3);
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton4);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(711, 136);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.ribbon1.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Sinh Viên";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MDIForm";
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.RibbonButton DropDownButton1;
      private System.Windows.Forms.RibbonButton DropDownButton2;
      private System.Windows.Forms.RibbonButton SubMenuButton1;
      private System.Windows.Forms.RibbonButton SubMenuButton2;
      private System.Windows.Forms.RibbonButton DropDownButton3;
      private System.Windows.Forms.RibbonButton DropDownButton4;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
    }
}