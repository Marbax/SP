namespace async_counters
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
            this.lCounter0 = new System.Windows.Forms.Label();
            this.lCounter1 = new System.Windows.Forms.Label();
            this.lCounter2 = new System.Windows.Forms.Label();
            this.lCounter3 = new System.Windows.Forms.Label();
            this.lCounter4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbQueue = new System.Windows.Forms.RadioButton();
            this.rbReverseQueue = new System.Windows.Forms.RadioButton();
            this.rbShuffle = new System.Windows.Forms.RadioButton();
            this.rbGrouShuffle = new System.Windows.Forms.RadioButton();
            this.gbCountRules = new System.Windows.Forms.GroupBox();
            this.gbCountRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lCounter0
            // 
            this.lCounter0.AutoSize = true;
            this.lCounter0.Location = new System.Drawing.Point(42, 41);
            this.lCounter0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCounter0.Name = "lCounter0";
            this.lCounter0.Size = new System.Drawing.Size(18, 20);
            this.lCounter0.TabIndex = 0;
            this.lCounter0.Text = "0";
            // 
            // lCounter1
            // 
            this.lCounter1.AutoSize = true;
            this.lCounter1.Location = new System.Drawing.Point(42, 90);
            this.lCounter1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCounter1.Name = "lCounter1";
            this.lCounter1.Size = new System.Drawing.Size(18, 20);
            this.lCounter1.TabIndex = 0;
            this.lCounter1.Text = "0";
            // 
            // lCounter2
            // 
            this.lCounter2.AutoSize = true;
            this.lCounter2.Location = new System.Drawing.Point(42, 138);
            this.lCounter2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCounter2.Name = "lCounter2";
            this.lCounter2.Size = new System.Drawing.Size(18, 20);
            this.lCounter2.TabIndex = 0;
            this.lCounter2.Text = "0";
            // 
            // lCounter3
            // 
            this.lCounter3.AutoSize = true;
            this.lCounter3.Location = new System.Drawing.Point(42, 190);
            this.lCounter3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCounter3.Name = "lCounter3";
            this.lCounter3.Size = new System.Drawing.Size(18, 20);
            this.lCounter3.TabIndex = 0;
            this.lCounter3.Text = "0";
            // 
            // lCounter4
            // 
            this.lCounter4.AutoSize = true;
            this.lCounter4.Location = new System.Drawing.Point(42, 244);
            this.lCounter4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCounter4.Name = "lCounter4";
            this.lCounter4.Size = new System.Drawing.Size(18, 20);
            this.lCounter4.TabIndex = 0;
            this.lCounter4.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 290);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(139, 290);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(260, 290);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(9, 23);
            this.rbAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(44, 24);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbQueue
            // 
            this.rbQueue.AutoSize = true;
            this.rbQueue.Location = new System.Drawing.Point(9, 72);
            this.rbQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbQueue.Name = "rbQueue";
            this.rbQueue.Size = new System.Drawing.Size(75, 24);
            this.rbQueue.TabIndex = 2;
            this.rbQueue.TabStop = true;
            this.rbQueue.Text = "Queue";
            this.rbQueue.UseVisualStyleBackColor = true;
            this.rbQueue.CheckedChanged += new System.EventHandler(this.rbQueue_CheckedChanged);
            // 
            // rbReverseQueue
            // 
            this.rbReverseQueue.AutoSize = true;
            this.rbReverseQueue.Location = new System.Drawing.Point(9, 120);
            this.rbReverseQueue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbReverseQueue.Name = "rbReverseQueue";
            this.rbReverseQueue.Size = new System.Drawing.Size(138, 24);
            this.rbReverseQueue.TabIndex = 2;
            this.rbReverseQueue.TabStop = true;
            this.rbReverseQueue.Text = "Reverse Queue";
            this.rbReverseQueue.UseVisualStyleBackColor = true;
            this.rbReverseQueue.CheckedChanged += new System.EventHandler(this.rbReverseQueue_CheckedChanged);
            // 
            // rbShuffle
            // 
            this.rbShuffle.AutoSize = true;
            this.rbShuffle.Location = new System.Drawing.Point(9, 172);
            this.rbShuffle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbShuffle.Name = "rbShuffle";
            this.rbShuffle.Size = new System.Drawing.Size(128, 24);
            this.rbShuffle.TabIndex = 2;
            this.rbShuffle.TabStop = true;
            this.rbShuffle.Text = "1->3->5->2->4";
            this.rbShuffle.UseVisualStyleBackColor = true;
            this.rbShuffle.CheckedChanged += new System.EventHandler(this.rbShuffle_CheckedChanged);
            // 
            // rbGrouShuffle
            // 
            this.rbGrouShuffle.AutoSize = true;
            this.rbGrouShuffle.Location = new System.Drawing.Point(9, 226);
            this.rbGrouShuffle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbGrouShuffle.Name = "rbGrouShuffle";
            this.rbGrouShuffle.Size = new System.Drawing.Size(118, 24);
            this.rbGrouShuffle.TabIndex = 2;
            this.rbGrouShuffle.TabStop = true;
            this.rbGrouShuffle.Text = "(1,5)->(2,3,4)";
            this.rbGrouShuffle.UseVisualStyleBackColor = true;
            this.rbGrouShuffle.CheckedChanged += new System.EventHandler(this.rbGrouShuffle_CheckedChanged);
            // 
            // gbCountRules
            // 
            this.gbCountRules.Controls.Add(this.rbQueue);
            this.gbCountRules.Controls.Add(this.rbGrouShuffle);
            this.gbCountRules.Controls.Add(this.rbAll);
            this.gbCountRules.Controls.Add(this.rbShuffle);
            this.gbCountRules.Controls.Add(this.rbReverseQueue);
            this.gbCountRules.Location = new System.Drawing.Point(187, 18);
            this.gbCountRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCountRules.Name = "gbCountRules";
            this.gbCountRules.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCountRules.Size = new System.Drawing.Size(166, 262);
            this.gbCountRules.TabIndex = 3;
            this.gbCountRules.TabStop = false;
            this.gbCountRules.Text = "Count Rules";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 338);
            this.Controls.Add(this.gbCountRules);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lCounter4);
            this.Controls.Add(this.lCounter2);
            this.Controls.Add(this.lCounter3);
            this.Controls.Add(this.lCounter1);
            this.Controls.Add(this.lCounter0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Async Counters";
            this.gbCountRules.ResumeLayout(false);
            this.gbCountRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCounter0;
        private System.Windows.Forms.Label lCounter1;
        private System.Windows.Forms.Label lCounter2;
        private System.Windows.Forms.Label lCounter3;
        private System.Windows.Forms.Label lCounter4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbQueue;
        private System.Windows.Forms.RadioButton rbReverseQueue;
        private System.Windows.Forms.RadioButton rbShuffle;
        private System.Windows.Forms.RadioButton rbGrouShuffle;
        private System.Windows.Forms.GroupBox gbCountRules;
    }
}

