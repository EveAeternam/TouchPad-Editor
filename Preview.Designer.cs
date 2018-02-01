namespace TouchPad_UI_Editor
{
    partial class Preview
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.context_emulatorPrev = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeOrientationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landscapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portraitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_prevBg = new System.Windows.Forms.PictureBox();
            this.diag_saveScreenshot = new System.Windows.Forms.SaveFileDialog();
            this.pb_preview = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.context_emulatorPrev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_prevBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(461, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // context_emulatorPrev
            // 
            this.context_emulatorPrev.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.takeScreenshotToolStripMenuItem,
            this.changeOrientationToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.context_emulatorPrev.Name = "context_emulatorPrev";
            this.context_emulatorPrev.Size = new System.Drawing.Size(179, 120);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // takeScreenshotToolStripMenuItem
            // 
            this.takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
            this.takeScreenshotToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.takeScreenshotToolStripMenuItem.Text = "Take Screenshot...";
            // 
            // changeOrientationToolStripMenuItem
            // 
            this.changeOrientationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landscapeToolStripMenuItem,
            this.portraitToolStripMenuItem});
            this.changeOrientationToolStripMenuItem.Name = "changeOrientationToolStripMenuItem";
            this.changeOrientationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.changeOrientationToolStripMenuItem.Text = "Change Orientation";
            // 
            // landscapeToolStripMenuItem
            // 
            this.landscapeToolStripMenuItem.Name = "landscapeToolStripMenuItem";
            this.landscapeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.landscapeToolStripMenuItem.Text = "Landscape";
            // 
            // portraitToolStripMenuItem
            // 
            this.portraitToolStripMenuItem.Name = "portraitToolStripMenuItem";
            this.portraitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.portraitToolStripMenuItem.Text = "Portrait";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pb_prevBg
            // 
            this.pb_prevBg.Image = global::TouchPad_UI_Editor.Properties.Resources.tft_land;
            this.pb_prevBg.Location = new System.Drawing.Point(12, 12);
            this.pb_prevBg.Name = "pb_prevBg";
            this.pb_prevBg.Size = new System.Drawing.Size(438, 297);
            this.pb_prevBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_prevBg.TabIndex = 3;
            this.pb_prevBg.TabStop = false;
            // 
            // pb_preview
            // 
            this.pb_preview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_preview.Location = new System.Drawing.Point(27, 29);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(350, 262);
            this.pb_preview.TabIndex = 4;
            this.pb_preview.TabStop = false;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 339);
            this.ContextMenuStrip = this.context_emulatorPrev;
            this.Controls.Add(this.pb_preview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pb_prevBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Preview";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Preview_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.context_emulatorPrev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_prevBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip context_emulatorPrev;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOrientationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landscapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portraitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeScreenshotToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog diag_saveScreenshot;
        public System.Windows.Forms.PictureBox pb_preview;
        public System.Windows.Forms.PictureBox pb_prevBg;
    }
}