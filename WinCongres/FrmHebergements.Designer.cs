namespace WinCongres
{
    partial class FrmHebergements
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
            this.tabControlHebergement = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.dataGridHebergement = new System.Windows.Forms.DataGridView();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridCongressistes = new System.Windows.Forms.DataGridView();
            this.bindSrcLesCongressistes = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblNbEtoiles = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxNbEtoiles = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.txtBoxCp = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbEtoilesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcHebergement = new System.Windows.Forms.BindingSource(this.components);
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcCongressiste = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlHebergement.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLesCongressistes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlHebergement
            // 
            this.tabControlHebergement.Controls.Add(this.tabPageListe);
            this.tabControlHebergement.Controls.Add(this.tabPageDetail);
            this.tabControlHebergement.Location = new System.Drawing.Point(26, 35);
            this.tabControlHebergement.Name = "tabControlHebergement";
            this.tabControlHebergement.SelectedIndex = 0;
            this.tabControlHebergement.Size = new System.Drawing.Size(1019, 438);
            this.tabControlHebergement.TabIndex = 0;
            this.tabControlHebergement.SelectedIndexChanged += new System.EventHandler(this.AnnulerModification);
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.dataGridHebergement);
            this.tabPageListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListe.Size = new System.Drawing.Size(1011, 412);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste des hébergements";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // dataGridHebergement
            // 
            this.dataGridHebergement.AllowUserToAddRows = false;
            this.dataGridHebergement.AllowUserToDeleteRows = false;
            this.dataGridHebergement.AutoGenerateColumns = false;
            this.dataGridHebergement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHebergement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.nbEtoilesDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn});
            this.dataGridHebergement.DataSource = this.bindSrcHebergement;
            this.dataGridHebergement.Location = new System.Drawing.Point(0, 0);
            this.dataGridHebergement.MultiSelect = false;
            this.dataGridHebergement.Name = "dataGridHebergement";
            this.dataGridHebergement.ReadOnly = true;
            this.dataGridHebergement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHebergement.Size = new System.Drawing.Size(1011, 412);
            this.dataGridHebergement.TabIndex = 0;
            this.dataGridHebergement.CurrentCellChanged += new System.EventHandler(this.dataGridHebergement_CurrentCellChanged);
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
            this.tabPageDetail.Text = "Détail de l\'hébergement";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Liste des congressistes hébergés :";
            // 
            // dataGridCongressistes
            // 
            this.dataGridCongressistes.AllowUserToAddRows = false;
            this.dataGridCongressistes.AllowUserToDeleteRows = false;
            this.dataGridCongressistes.AutoGenerateColumns = false;
            this.dataGridCongressistes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCongressistes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn1});
            this.dataGridCongressistes.DataSource = this.bindSrcCongressiste;
            this.dataGridCongressistes.Location = new System.Drawing.Point(643, 67);
            this.dataGridCongressistes.Name = "dataGridCongressistes";
            this.dataGridCongressistes.ReadOnly = true;
            this.dataGridCongressistes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCongressistes.Size = new System.Drawing.Size(353, 282);
            this.dataGridCongressistes.TabIndex = 1;
            // 
            // bindSrcLesCongressistes
            // 
            this.bindSrcLesCongressistes.DataMember = "LesCongressistes";
            this.bindSrcLesCongressistes.DataSource = this.bindSrcHebergement;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxVille);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.txtBoxNom);
            this.groupBox1.Controls.Add(this.lblNbEtoiles);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Controls.Add(this.lblCp);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.txtBoxNbEtoiles);
            this.groupBox1.Controls.Add(this.txtBoxTel);
            this.groupBox1.Controls.Add(this.txtBoxPrix);
            this.groupBox1.Controls.Add(this.txtBoxCp);
            this.groupBox1.Controls.Add(this.txtBoxAdresse);
            this.groupBox1.Controls.Add(this.txtBoxId);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de l\'hébergement";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Ville", true));
            this.txtBoxVille.Location = new System.Drawing.Point(418, 52);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(152, 20);
            this.txtBoxVille.TabIndex = 16;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(318, 258);
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
            this.btnAjouter.Location = new System.Drawing.Point(126, 258);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(149, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(318, 102);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Prix";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Nom", true));
            this.txtBoxNom.Location = new System.Drawing.Point(83, 99);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(221, 20);
            this.txtBoxNom.TabIndex = 14;
            // 
            // lblNbEtoiles
            // 
            this.lblNbEtoiles.AutoSize = true;
            this.lblNbEtoiles.Location = new System.Drawing.Point(318, 196);
            this.lblNbEtoiles.Name = "lblNbEtoiles";
            this.lblNbEtoiles.Size = new System.Drawing.Size(85, 13);
            this.lblNbEtoiles.TabIndex = 13;
            this.lblNbEtoiles.Text = "Nombre d\'étoiles";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(318, 151);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "Téléphone";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(318, 55);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 11;
            this.lblVille.Text = "Ville";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(8, 196);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(64, 13);
            this.lblCp.TabIndex = 10;
            this.lblCp.Text = "Code Postal";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(8, 152);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 9;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(8, 102);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // txtBoxNbEtoiles
            // 
            this.txtBoxNbEtoiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "NbEtoiles", true));
            this.txtBoxNbEtoiles.Location = new System.Drawing.Point(418, 192);
            this.txtBoxNbEtoiles.Name = "txtBoxNbEtoiles";
            this.txtBoxNbEtoiles.Size = new System.Drawing.Size(152, 20);
            this.txtBoxNbEtoiles.TabIndex = 7;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Tel", true));
            this.txtBoxTel.Location = new System.Drawing.Point(418, 148);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(152, 20);
            this.txtBoxTel.TabIndex = 6;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Prix", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(418, 99);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(152, 20);
            this.txtBoxPrix.TabIndex = 5;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Cp", true));
            this.txtBoxCp.Location = new System.Drawing.Point(83, 193);
            this.txtBoxCp.Name = "txtBoxCp";
            this.txtBoxCp.Size = new System.Drawing.Size(221, 20);
            this.txtBoxCp.TabIndex = 4;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Adresse", true));
            this.txtBoxAdresse.Location = new System.Drawing.Point(83, 149);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(221, 20);
            this.txtBoxAdresse.TabIndex = 3;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHebergement, "Id", true));
            this.txtBoxId.Location = new System.Drawing.Point(83, 52);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(221, 20);
            this.txtBoxId.TabIndex = 2;
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
            this.btnSupprimer.Text = "Supprimer l\'hébergement";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Teal;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(126, 258);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(149, 31);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(407, 489);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Ajouter un nouvel hébergement";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "Cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Code Postal";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Télephone";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbEtoilesDataGridViewTextBoxColumn
            // 
            this.nbEtoilesDataGridViewTextBoxColumn.DataPropertyName = "NbEtoiles";
            this.nbEtoilesDataGridViewTextBoxColumn.HeaderText = "Nombre d\'étoiles";
            this.nbEtoilesDataGridViewTextBoxColumn.Name = "nbEtoilesDataGridViewTextBoxColumn";
            this.nbEtoilesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindSrcHebergement
            // 
            this.bindSrcHebergement.DataSource = typeof(congres.dll.Hebergement);
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn1
            // 
            this.telDataGridViewTextBoxColumn1.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn1.HeaderText = "Télephone";
            this.telDataGridViewTextBoxColumn1.Name = "telDataGridViewTextBoxColumn1";
            this.telDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bindSrcCongressiste
            // 
            this.bindSrcCongressiste.DataSource = typeof(congres.dll.Congressiste);
            // 
            // FrmHebergements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.tabControlHebergement);
            this.Name = "FrmHebergements";
            this.Text = "Gestion des hébergements";
            this.Load += new System.EventHandler(this.FrmHebergements_Load);
            this.tabControlHebergement.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHebergement)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLesCongressistes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHebergement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSrcHebergement;
        private System.Windows.Forms.TabControl tabControlHebergement;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridHebergement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEtoilesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridCongressistes;
        private System.Windows.Forms.TextBox txtBoxNbEtoiles;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.TextBox txtBoxCp;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblNbEtoiles;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.BindingSource bindSrcLesCongressistes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bindSrcCongressiste;
    }
}