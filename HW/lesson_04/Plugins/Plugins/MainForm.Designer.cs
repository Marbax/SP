namespace Plugins
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIUpdateFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISupport = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(468, 370);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.TSMIUpdateFilters,
            this.TSMIFilters,
            this.TSMISupport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIOpen,
            this.TSMISaveTo});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // TSMIOpen
            // 
            this.TSMIOpen.Name = "TSMIOpen";
            this.TSMIOpen.Size = new System.Drawing.Size(113, 22);
            this.TSMIOpen.Text = "Open";
            this.TSMIOpen.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // TSMISaveTo
            // 
            this.TSMISaveTo.Name = "TSMISaveTo";
            this.TSMISaveTo.Size = new System.Drawing.Size(113, 22);
            this.TSMISaveTo.Text = "Save To";
            this.TSMISaveTo.Click += new System.EventHandler(this.TSMISaveTo_Click);
            // 
            // TSMIUpdateFilters
            // 
            this.TSMIUpdateFilters.Name = "TSMIUpdateFilters";
            this.TSMIUpdateFilters.Size = new System.Drawing.Size(91, 20);
            this.TSMIUpdateFilters.Text = "Update Filters";
            this.TSMIUpdateFilters.Click += new System.EventHandler(this.TSMIUpdate_Click);
            // 
            // TSMIFilters
            // 
            this.TSMIFilters.Name = "TSMIFilters";
            this.TSMIFilters.Size = new System.Drawing.Size(50, 20);
            this.TSMIFilters.Text = "Filters";
            // 
            // TSMISupport
            // 
            this.TSMISupport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAbout});
            this.TSMISupport.Name = "TSMISupport";
            this.TSMISupport.Size = new System.Drawing.Size(61, 20);
            this.TSMISupport.Text = "Support";
            // 
            // TSMIAbout
            // 
            this.TSMIAbout.Name = "TSMIAbout";
            this.TSMIAbout.Size = new System.Drawing.Size(107, 22);
            this.TSMIAbout.Text = "About";
            this.TSMIAbout.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 394);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Plugins";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMIFilters;
        private System.Windows.Forms.ToolStripMenuItem TSMISupport;
        private System.Windows.Forms.ToolStripMenuItem TSMIAbout;
        private System.Windows.Forms.ToolStripMenuItem TSMIUpdateFilters;
        private System.Windows.Forms.ToolStripMenuItem TSMISaveTo;
    }
}

