namespace sysProg
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
            this.StartApp = new System.Windows.Forms.Button();
            this.StopAllApps = new System.Windows.Forms.Button();
            this.appToExe = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.Scan = new System.Windows.Forms.Button();
            this.LoadLib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartApp
            // 
            this.StartApp.Location = new System.Drawing.Point(32, 38);
            this.StartApp.Name = "StartApp";
            this.StartApp.Size = new System.Drawing.Size(75, 23);
            this.StartApp.TabIndex = 0;
            this.StartApp.Text = "Start App";
            this.StartApp.UseVisualStyleBackColor = true;
            this.StartApp.Click += new System.EventHandler(this.StartApp_click);
            // 
            // StopAllApps
            // 
            this.StopAllApps.Location = new System.Drawing.Point(353, 38);
            this.StopAllApps.Name = "StopAllApps";
            this.StopAllApps.Size = new System.Drawing.Size(75, 23);
            this.StopAllApps.TabIndex = 1;
            this.StopAllApps.Text = "Stop All Apps";
            this.StopAllApps.UseVisualStyleBackColor = true;
            this.StopAllApps.Click += new System.EventHandler(this.StopAllApps_click);
            // 
            // appToExe
            // 
            this.appToExe.Location = new System.Drawing.Point(12, 12);
            this.appToExe.Name = "appToExe";
            this.appToExe.Size = new System.Drawing.Size(440, 20);
            this.appToExe.TabIndex = 2;
            this.appToExe.Text = "DemoLib.dll";
            this.appToExe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.appToExe_KeyUp);
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbLog.Location = new System.Drawing.Point(0, 83);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(464, 239);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(132, 38);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(75, 23);
            this.Scan.TabIndex = 4;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // LoadLib
            // 
            this.LoadLib.Location = new System.Drawing.Point(237, 38);
            this.LoadLib.Name = "LoadLib";
            this.LoadLib.Size = new System.Drawing.Size(75, 23);
            this.LoadLib.TabIndex = 5;
            this.LoadLib.Text = "Load Lib";
            this.LoadLib.UseVisualStyleBackColor = true;
            this.LoadLib.Click += new System.EventHandler(this.LoadLib_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.LoadLib);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.appToExe);
            this.Controls.Add(this.StopAllApps);
            this.Controls.Add(this.StartApp);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartApp;
        private System.Windows.Forms.Button StopAllApps;
        private System.Windows.Forms.TextBox appToExe;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button LoadLib;
    }
}

