namespace WinCongres
{
    partial class FrmSalle
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
            this.tabControlSalle = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.dataGridSalle = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSalle = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridCongressistes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.bindSrcSession = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estMatinDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.affichageMomentJourneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSalle.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSalle)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSession)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSalle
            // 
            this.tabControlSalle.Controls.Add(this.tabPageListe);
            this.tabControlSalle.Controls.Add(this.tabPageDetail);
            this.tabControlSalle.Location = new System.Drawing.Point(27, 51);
            this.tabControlSalle.Name = "tabControlSalle";
            this.tabControlSalle.SelectedIndex = 0;
            this.tabControlSalle.Size = new System.Drawing.Size(1019, 438);
            this.tabControlSalle.TabIndex = 1;
            this.tabControlSalle.SelectedIndexChanged += new System.EventHandler(this.AnnulerModification);
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.dataGridSalle);
            this.tabPageListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListe.Size = new System.Drawing.Size(1011, 412);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste des salles";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // dataGridSalle
            // 
            this.dataGridSalle.AllowUserToAddRows = false;
            this.dataGridSalle.AllowUserToDeleteRows = false;
            this.dataGridSalle.AutoGenerateColumns = false;
            this.dataGridSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridSalle.DataSource = this.bindSrcSalle;
            this.dataGridSalle.Location = new System.Drawing.Point(0, 0);
            this.dataGridSalle.MultiSelect = false;
            this.dataGridSalle.Name = "dataGridSalle";
            this.dataGridSalle.ReadOnly = true;
            this.dataGridSalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSalle.Size = new System.Drawing.Size(1011, 412);
            this.dataGridSalle.TabIndex = 0;
            this.dataGridSalle.CurrentCellChanged += new System.EventHandler(this.dataGridSalle_CurrentCellChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindSrcSalle
            // 
            this.bindSrcSalle.DataSource = typeof(congres.dll.Salle);
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.label8);
            this.tabPageDetail.Controls.Add(this.dataGridCongressistes);
            this.tabPageDetail.Controls.Add(this.groupBox1);
            this.tabPageDetail.Controls.Add(this.btnSupprimer);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(1011, 412);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détail de la salle";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Liste des sessions :";
            // 
            // dataGridCongressistes
            // 
            this.dataGridCongressistes.AllowUserToAddRows = false;
            this.dataGridCongressistes.AllowUserToDeleteRows = false;
            this.dataGridCongressistes.AutoGenerateColumns = false;
            this.dataGridCongressistes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCongressistes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.themeDataGridViewTextBoxColumn,
            this.nomPresidentDataGridViewTextBoxColumn,
            this.nbPlacesDataGridViewTextBoxColumn,
            this.salleDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateSessionDataGridViewTextBoxColumn,
            this.estMatinDataGridViewCheckBoxColumn,
            this.affichageMomentJourneeDataGridViewTextBoxColumn});
            this.dataGridCongressistes.DataSource = this.bindSrcSession;
            this.dataGridCongressistes.Location = new System.Drawing.Point(643, 67);
            this.dataGridCongressistes.Name = "dataGridCongressistes";
            this.dataGridCongressistes.ReadOnly = true;
            this.dataGridCongressistes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCongressistes.Size = new System.Drawing.Size(353, 282);
            this.dataGridCongressistes.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtBoxVille);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.lblLibelle);
            this.groupBox1.Controls.Add(this.txtBoxId);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de la salle";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSalle, "Libelle", true));
            this.txtBoxVille.Location = new System.Drawing.Point(327, 49);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(252, 20);
            this.txtBoxVille.TabIndex = 16;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(318, 259);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(149, 31);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.AnnulerModification);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Teal;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(126, 259);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(149, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(280, 52);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 11;
            this.lblLibelle.Text = "Libellé";
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSalle, "Id", true));
            this.txtBoxId.Location = new System.Drawing.Point(41, 49);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(219, 20);
            this.txtBoxId.TabIndex = 2;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Teal;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(126, 259);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(149, 31);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimer.Location = new System.Drawing.Point(223, 362);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(176, 31);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer la salle";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(412, 495);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Ajouter une nouvelle salle";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // bindSrcSession
            // 
            this.bindSrcSession.DataSource = typeof(congres.dll.Session);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "NomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "NomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbPlacesDataGridViewTextBoxColumn
            // 
            this.nbPlacesDataGridViewTextBoxColumn.DataPropertyName = "NbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.HeaderText = "NbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.Name = "nbPlacesDataGridViewTextBoxColumn";
            this.nbPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salleDataGridViewTextBoxColumn
            // 
            this.salleDataGridViewTextBoxColumn.DataPropertyName = "Salle";
            this.salleDataGridViewTextBoxColumn.HeaderText = "Salle";
            this.salleDataGridViewTextBoxColumn.Name = "salleDataGridViewTextBoxColumn";
            this.salleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateSessionDataGridViewTextBoxColumn
            // 
            this.dateSessionDataGridViewTextBoxColumn.DataPropertyName = "DateSession";
            this.dateSessionDataGridViewTextBoxColumn.HeaderText = "DateSession";
            this.dateSessionDataGridViewTextBoxColumn.Name = "dateSessionDataGridViewTextBoxColumn";
            this.dateSessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estMatinDataGridViewCheckBoxColumn
            // 
            this.estMatinDataGridViewCheckBoxColumn.DataPropertyName = "EstMatin";
            this.estMatinDataGridViewCheckBoxColumn.HeaderText = "EstMatin";
            this.estMatinDataGridViewCheckBoxColumn.Name = "estMatinDataGridViewCheckBoxColumn";
            this.estMatinDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // affichageMomentJourneeDataGridViewTextBoxColumn
            // 
            this.affichageMomentJourneeDataGridViewTextBoxColumn.DataPropertyName = "AffichageMomentJournee";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.HeaderText = "AffichageMomentJournee";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.Name = "affichageMomentJourneeDataGridViewTextBoxColumn";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.tabControlSalle);
            this.Name = "FrmSalle";
            this.Text = "Gestion des salles";
            this.Load += new System.EventHandler(this.FrmSalle_Load);
            this.tabControlSalle.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSalle)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSalle;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.DataGridView dataGridSalle;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridCongressistes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.BindingSource bindSrcSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estMatinDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affichageMomentJourneeDataGridViewTextBoxColumn;
    }
}