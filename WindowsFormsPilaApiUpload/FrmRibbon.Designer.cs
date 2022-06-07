namespace WindowsFormsPilaApiUpload
{
    partial class FrmRibbon
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
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.ribbon1.OrbText = "orbtext hau zerda?";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Text = "bat";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 177);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "batTAb";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            this.ribbonPanel1.Click += new System.EventHandler(this.ribbonPanel1_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "ribbonPanel3";
            this.ribbonPanel3.Click += new System.EventHandler(this.ribbonPanel3_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Panels.Add(this.ribbonPanel4);
            this.ribbonTab2.Panels.Add(this.ribbonPanel5);
            this.ribbonTab2.Text = "biTab";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "ribbonPanel5";
            this.ribbonPanel5.Click += new System.EventHandler(this.ribbonPanel5_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Panels.Add(this.ribbonPanel7);
            this.ribbonTab3.Panels.Add(this.ribbonPanel8);
            this.ribbonTab3.Text = "ribbonTab3";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "ribbonPanel6";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "ribbonPanel7";
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Text = "ribbonPanel8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FrmRibbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "FrmRibbon";
            this.Text = "FrmRibbon";
            this.Load += new System.EventHandler(this.FrmRibbon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.TextBox textBox1;
    }
}