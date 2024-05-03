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
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(1538, 24);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStripMDI";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 993);
            this.Controls.Add(this.menuStripMDI);
            this.MainMenuStrip = this.menuStripMDI;
            this.Name = "FrmMDI";
            this.Text = "Gestionnaire de l\'organisation du Congrès \"Sport et Santé\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
    }
}