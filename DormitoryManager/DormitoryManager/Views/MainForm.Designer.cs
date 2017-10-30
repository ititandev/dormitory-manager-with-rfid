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
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.hopDongTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.sinhVienTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.phongTab = new System.Windows.Forms.RibbonTab();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab6 = new System.Windows.Forms.RibbonTab();
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
            // ribbon
            // 
            this.ribbon.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = null;
            this.ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            // 
            // 
            // 
            this.ribbon.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton1);
            this.ribbon.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton2);
            this.ribbon.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton3);
            this.ribbon.QuickAcessToolbar.DropDownButtonItems.Add(this.DropDownButton4);
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(711, 136);
            this.ribbon.TabIndex = 0;
            this.ribbon.Tabs.Add(this.hopDongTab);
            this.ribbon.Tabs.Add(this.sinhVienTab);
            this.ribbon.Tabs.Add(this.phongTab);
            this.ribbon.Tabs.Add(this.ribbonTab4);
            this.ribbon.Tabs.Add(this.ribbonTab5);
            this.ribbon.Tabs.Add(this.ribbonTab6);
            this.ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon.Text = "ribbon1";
            this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.ribbon.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
            // 
            // hopDongTab
            // 
            this.hopDongTab.Panels.Add(this.ribbonPanel1);
            this.hopDongTab.Panels.Add(this.ribbonPanel2);
            this.hopDongTab.Text = "Hợp Đồng";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // sinhVienTab
            // 
            this.sinhVienTab.Panels.Add(this.ribbonPanel3);
            this.sinhVienTab.Panels.Add(this.ribbonPanel4);
            this.sinhVienTab.Text = "Sinh Viên";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // phongTab
            // 
            this.phongTab.Text = "Phòng";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Text = "ribbonTab4";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Text = "ribbonTab5";
            // 
            // ribbonTab6
            // 
            this.ribbonTab6.Text = "ribbonTab6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.ribbon);
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
        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonTab hopDongTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab sinhVienTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonTab phongTab;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonTab ribbonTab6;
    }
}