﻿namespace WinCongres
{
    partial class FrmMDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.menuBtnSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.activitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congressistesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hébergementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnSessions,
            this.activitésToolStripMenuItem,
            this.hébergementsToolStripMenuItem,
            this.congressistesToolStripMenuItem,
            this.liguesToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(1538, 33);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStripMDI";
            // 
            // menuBtnSessions
            // 
            this.menuBtnSessions.Name = "menuBtnSessions";
            this.menuBtnSessions.Size = new System.Drawing.Size(96, 29);
            this.menuBtnSessions.Text = "Sessions";
            this.menuBtnSessions.Click += new System.EventHandler(this.menuBtnSessions_Click);
            // 
            // activitésToolStripMenuItem
            // 
            this.activitésToolStripMenuItem.Name = "activitésToolStripMenuItem";
            this.activitésToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.activitésToolStripMenuItem.Text = "Activités";
            // 
            // congressistesToolStripMenuItem
            // 
            this.congressistesToolStripMenuItem.Name = "congressistesToolStripMenuItem";
            this.congressistesToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.congressistesToolStripMenuItem.Text = "Inscriptions";
            this.congressistesToolStripMenuItem.Click += new System.EventHandler(this.congressistesToolStripMenuItem_Click);
            // 
            // hébergementsToolStripMenuItem
            // 
            this.hébergementsToolStripMenuItem.Name = "hébergementsToolStripMenuItem";
            this.hébergementsToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.hébergementsToolStripMenuItem.Text = "Hébergements";
            // 
            // liguesToolStripMenuItem
            // 
            this.liguesToolStripMenuItem.Name = "liguesToolStripMenuItem";
            this.liguesToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.liguesToolStripMenuItem.Text = "Ligues participantes";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 993);
            this.Controls.Add(this.menuStripMDI);
            this.MainMenuStrip = this.menuStripMDI;
            this.Name = "FrmMDI";
            this.Text = ")";
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSessions;
        private System.Windows.Forms.ToolStripMenuItem activitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hébergementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congressistesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liguesToolStripMenuItem;
    }
}