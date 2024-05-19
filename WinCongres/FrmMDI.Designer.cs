namespace WinCongres
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
            this.menuBtnActivites = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnHebergements = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnInscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLigues = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCongressiste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnSessions,
            this.menuBtnActivites,
            this.menuBtnHebergements,
            this.menuBtnInscriptions,
            this.menuBtnLigues,
            this.btnCongressiste});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripMDI.Size = new System.Drawing.Size(1461, 24);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStripMDI";
            // 
            // menuBtnSessions
            // 
            this.menuBtnSessions.Name = "menuBtnSessions";
            this.menuBtnSessions.Size = new System.Drawing.Size(63, 22);
            this.menuBtnSessions.Text = "Sessions";
            this.menuBtnSessions.Click += new System.EventHandler(this.menuBtnSessions_Click);
            // 
            // menuBtnActivites
            // 
            this.menuBtnActivites.Name = "menuBtnActivites";
            this.menuBtnActivites.Size = new System.Drawing.Size(64, 22);
            this.menuBtnActivites.Text = "Activités";
            this.menuBtnActivites.Click += new System.EventHandler(this.menuBtnActivites_Click);
            // 
            // menuBtnHebergements
            // 
            this.menuBtnHebergements.Name = "menuBtnHebergements";
            this.menuBtnHebergements.Size = new System.Drawing.Size(97, 22);
            this.menuBtnHebergements.Text = "Hébergements";
            this.menuBtnHebergements.Click += new System.EventHandler(this.menuBtnHebergements_Click);
            // 
            // menuBtnInscriptions
            // 
            this.menuBtnInscriptions.Name = "menuBtnInscriptions";
            this.menuBtnInscriptions.Size = new System.Drawing.Size(80, 22);
            this.menuBtnInscriptions.Text = "Inscriptions";
            this.menuBtnInscriptions.Click += new System.EventHandler(this.menuBtnInscriptions_Click);
            // 
            // menuBtnLigues
            // 
            this.menuBtnLigues.Name = "menuBtnLigues";
            this.menuBtnLigues.Size = new System.Drawing.Size(124, 22);
            this.menuBtnLigues.Text = "Ligues participantes";
            this.menuBtnLigues.Click += new System.EventHandler(this.menuBtnLigues_Click);
            // 
            // btnCongressiste
            // 
            this.btnCongressiste.Name = "btnCongressiste";
            this.btnCongressiste.Size = new System.Drawing.Size(91, 22);
            this.btnCongressiste.Text = "Congressistes";
            this.btnCongressiste.Click += new System.EventHandler(this.btnCongressiste_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 855);
            this.Controls.Add(this.menuStripMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMDI";
            this.Text = "Gestionnaire de l\'organisation du Congrès \"Sport et Santé\"";
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSessions;
        private System.Windows.Forms.ToolStripMenuItem menuBtnActivites;
        private System.Windows.Forms.ToolStripMenuItem menuBtnHebergements;
        private System.Windows.Forms.ToolStripMenuItem menuBtnInscriptions;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLigues;
        private System.Windows.Forms.ToolStripMenuItem btnCongressiste;
    }
}