namespace WinCongres
{
    partial class FrmSessions
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
            System.Windows.Forms.Label idLabel;
            this.tabControlSession = new System.Windows.Forms.TabControl();
            this.tabPageSessions = new System.Windows.Forms.TabPage();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffichageMomentJournee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessions = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.idLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            this.tabControlSession.SuspendLayout();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.tabPageSessions);
            this.tabControlSession.Controls.Add(this.tabPageDetail);
            this.tabControlSession.Location = new System.Drawing.Point(12, 12);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(1306, 916);
            this.tabControlSession.TabIndex = 0;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridSession);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 29);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSessions.Size = new System.Drawing.Size(1298, 883);
            this.tabPageSessions.TabIndex = 0;
            this.tabPageSessions.Text = "Liste des sessions";
            this.tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // dataGridSession
            // 
            this.dataGridSession.AutoGenerateColumns = false;
            this.dataGridSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn,
            this.nomPresidentDataGridViewTextBoxColumn,
            this.nbPlaceDataGridViewTextBoxColumn,
            this.salleDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateSessionDataGridViewTextBoxColumn,
            this.AffichageMomentJournee});
            this.dataGridSession.DataSource = this.bindSrcSessions;
            this.dataGridSession.Location = new System.Drawing.Point(-4, 0);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.RowHeadersWidth = 62;
            this.dataGridSession.RowTemplate.Height = 28;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(1306, 820);
            this.dataGridSession.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 59;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 94;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "NomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "Président";
            this.nomPresidentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPresidentDataGridViewTextBoxColumn.Width = 112;
            // 
            // nbPlaceDataGridViewTextBoxColumn
            // 
            this.nbPlaceDataGridViewTextBoxColumn.DataPropertyName = "NbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.HeaderText = "Nb. de Places";
            this.nbPlaceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nbPlaceDataGridViewTextBoxColumn.Name = "nbPlaceDataGridViewTextBoxColumn";
            this.nbPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlaceDataGridViewTextBoxColumn.Width = 142;
            // 
            // salleDataGridViewTextBoxColumn
            // 
            this.salleDataGridViewTextBoxColumn.DataPropertyName = "Salle";
            this.salleDataGridViewTextBoxColumn.HeaderText = "Salle";
            this.salleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salleDataGridViewTextBoxColumn.Name = "salleDataGridViewTextBoxColumn";
            this.salleDataGridViewTextBoxColumn.ReadOnly = true;
            this.salleDataGridViewTextBoxColumn.Width = 80;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateSessionDataGridViewTextBoxColumn
            // 
            this.dateSessionDataGridViewTextBoxColumn.DataPropertyName = "DateSession";
            this.dateSessionDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateSessionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateSessionDataGridViewTextBoxColumn.Name = "dateSessionDataGridViewTextBoxColumn";
            this.dateSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSessionDataGridViewTextBoxColumn.Width = 80;
            // 
            // AffichageMomentJournee
            // 
            this.AffichageMomentJournee.DataPropertyName = "AffichageMomentJournee";
            this.AffichageMomentJournee.HeaderText = "Moment";
            this.AffichageMomentJournee.MinimumWidth = 8;
            this.AffichageMomentJournee.Name = "AffichageMomentJournee";
            this.AffichageMomentJournee.ReadOnly = true;
            this.AffichageMomentJournee.Width = 103;
            // 
            // bindSrcSessions
            // 
            this.bindSrcSessions.DataSource = typeof(congres.dll.Session);
            this.bindSrcSessions.CurrentChanged += new System.EventHandler(this.bindSrcSession_CurrentChanged);
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(idLabel);
            this.tabPageDetail.Controls.Add(this.idLabel1);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(1298, 883);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détails";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(172, 142);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(31, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id :";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(205, 142);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label1";
            // 
            // FrmSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 941);
            this.Controls.Add(this.tabControlSession);
            this.Name = "FrmSessions";
            this.Text = "FrmSessions";
            this.tabControlSession.ResumeLayout(false);
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSrcSessions;
        private System.Windows.Forms.TabControl tabControlSession;
        private System.Windows.Forms.TabPage tabPageSessions;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AffichageMomentJournee;
        private System.Windows.Forms.Label idLabel1;
    }
}