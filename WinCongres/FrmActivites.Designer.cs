namespace WinCongres
{
    partial class FrmActivites
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
            System.Windows.Forms.Label lblNom;
            this.dateActiviteLabel = new System.Windows.Forms.Label();
            this.tabControlActivite = new System.Windows.Forms.TabControl();
            this.tabPageActivites = new System.Windows.Forms.TabPage();
            this.dataGridActivite = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffichageMomentJournee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.groupBoxParticipants = new System.Windows.Forms.GroupBox();
            this.btnSupprParticipant = new System.Windows.Forms.Button();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.dataGridParticipants = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickerActivite = new System.Windows.Forms.DateTimePicker();
            this.radioBtnApresMidi = new System.Windows.Forms.RadioButton();
            this.radioBtnMatin = new System.Windows.Forms.RadioButton();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.btnAnnulerNouveau = new System.Windows.Forms.Button();
            this.btnConfirmNouveau = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNbPlaces = new System.Windows.Forms.TextBox();
            this.btnSupprActivite = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivites = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcParticipants = new System.Windows.Forms.BindingSource(this.components);
            lblNom = new System.Windows.Forms.Label();
            this.tabControlActivite.SuspendLayout();
            this.tabPageActivites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.groupBoxParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(9, 54);
            lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(29, 13);
            lblNom.TabIndex = 18;
            lblNom.Text = "Nom";
            // 
            // dateActiviteLabel
            // 
            this.dateActiviteLabel.AutoSize = true;
            this.dateActiviteLabel.Location = new System.Drawing.Point(305, 94);
            this.dateActiviteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateActiviteLabel.Name = "dateActiviteLabel";
            this.dateActiviteLabel.Size = new System.Drawing.Size(106, 13);
            this.dateActiviteLabel.TabIndex = 21;
            this.dateActiviteLabel.Text = "Date de déroulement";
            // 
            // tabControlActivite
            // 
            this.tabControlActivite.Controls.Add(this.tabPageActivites);
            this.tabControlActivite.Controls.Add(this.tabPageDetail);
            this.tabControlActivite.Location = new System.Drawing.Point(8, 8);
            this.tabControlActivite.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlActivite.Name = "tabControlActivite";
            this.tabControlActivite.SelectedIndex = 0;
            this.tabControlActivite.Size = new System.Drawing.Size(1049, 430);
            this.tabControlActivite.TabIndex = 0;
            this.tabControlActivite.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlActivite_Selecting);
            // 
            // tabPageActivites
            // 
            this.tabPageActivites.Controls.Add(this.dataGridActivite);
            this.tabPageActivites.Location = new System.Drawing.Point(4, 22);
            this.tabPageActivites.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageActivites.Name = "tabPageActivites";
            this.tabPageActivites.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageActivites.Size = new System.Drawing.Size(1041, 404);
            this.tabPageActivites.TabIndex = 0;
            this.tabPageActivites.Text = "Liste des activités";
            this.tabPageActivites.UseVisualStyleBackColor = true;
            // 
            // dataGridActivite
            // 
            this.dataGridActivite.AllowUserToAddRows = false;
            this.dataGridActivite.AllowUserToDeleteRows = false;
            this.dataGridActivite.AllowUserToResizeRows = false;
            this.dataGridActivite.AutoGenerateColumns = false;
            this.dataGridActivite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.nbPlaces,
            this.Prix,
            this.DateActivite,
            this.AffichageMomentJournee});
            this.dataGridActivite.DataSource = this.bindSrcActivites;
            this.dataGridActivite.Location = new System.Drawing.Point(0, 0);
            this.dataGridActivite.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridActivite.MultiSelect = false;
            this.dataGridActivite.Name = "dataGridActivite";
            this.dataGridActivite.ReadOnly = true;
            this.dataGridActivite.RowHeadersWidth = 62;
            this.dataGridActivite.RowTemplate.Height = 28;
            this.dataGridActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridActivite.Size = new System.Drawing.Size(1041, 404);
            this.dataGridActivite.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 54;
            // 
            // DateActivite
            // 
            this.DateActivite.DataPropertyName = "DateActivite";
            this.DateActivite.HeaderText = "Date";
            this.DateActivite.Name = "DateActivite";
            this.DateActivite.ReadOnly = true;
            this.DateActivite.Width = 55;
            // 
            // AffichageMomentJournee
            // 
            this.AffichageMomentJournee.DataPropertyName = "AffichageMomentJournee";
            this.AffichageMomentJournee.HeaderText = "Moment";
            this.AffichageMomentJournee.MinimumWidth = 8;
            this.AffichageMomentJournee.Name = "AffichageMomentJournee";
            this.AffichageMomentJournee.ReadOnly = true;
            this.AffichageMomentJournee.Width = 70;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.groupBoxParticipants);
            this.tabPageDetail.Controls.Add(this.groupBox1);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDetail.Size = new System.Drawing.Size(1041, 404);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détails";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // groupBoxParticipants
            // 
            this.groupBoxParticipants.Controls.Add(this.btnSupprParticipant);
            this.groupBoxParticipants.Controls.Add(this.btnAjouterParticipant);
            this.groupBoxParticipants.Controls.Add(this.dataGridParticipants);
            this.groupBoxParticipants.Location = new System.Drawing.Point(626, 29);
            this.groupBoxParticipants.Name = "groupBoxParticipants";
            this.groupBoxParticipants.Size = new System.Drawing.Size(410, 350);
            this.groupBoxParticipants.TabIndex = 7;
            this.groupBoxParticipants.TabStop = false;
            this.groupBoxParticipants.Text = "Liste des congressistes participants";
            // 
            // btnSupprParticipant
            // 
            this.btnSupprParticipant.Location = new System.Drawing.Point(216, 308);
            this.btnSupprParticipant.Name = "btnSupprParticipant";
            this.btnSupprParticipant.Size = new System.Drawing.Size(124, 31);
            this.btnSupprParticipant.TabIndex = 6;
            this.btnSupprParticipant.Text = "Supprimer la sélection";
            this.btnSupprParticipant.UseVisualStyleBackColor = true;
            this.btnSupprParticipant.Click += new System.EventHandler(this.btnSupprParticipant_Click);
            // 
            // btnAjouterParticipant
            // 
            this.btnAjouterParticipant.Location = new System.Drawing.Point(68, 308);
            this.btnAjouterParticipant.Name = "btnAjouterParticipant";
            this.btnAjouterParticipant.Size = new System.Drawing.Size(124, 31);
            this.btnAjouterParticipant.TabIndex = 5;
            this.btnAjouterParticipant.Text = "Ajouter un participant";
            this.btnAjouterParticipant.UseVisualStyleBackColor = true;
            this.btnAjouterParticipant.Click += new System.EventHandler(this.btnAjouterParticipant_Click);
            // 
            // dataGridParticipants
            // 
            this.dataGridParticipants.AllowUserToAddRows = false;
            this.dataGridParticipants.AutoGenerateColumns = false;
            this.dataGridParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.dataGridParticipants.DataSource = this.bindSrcParticipants;
            this.dataGridParticipants.Location = new System.Drawing.Point(6, 19);
            this.dataGridParticipants.MultiSelect = false;
            this.dataGridParticipants.Name = "dataGridParticipants";
            this.dataGridParticipants.ReadOnly = true;
            this.dataGridParticipants.RowHeadersWidth = 62;
            this.dataGridParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParticipants.ShowEditingIcon = false;
            this.dataGridParticipants.Size = new System.Drawing.Size(398, 283);
            this.dataGridParticipants.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateActiviteLabel);
            this.groupBox1.Controls.Add(this.datePickerActivite);
            this.groupBox1.Controls.Add(this.radioBtnApresMidi);
            this.groupBox1.Controls.Add(this.radioBtnMatin);
            this.groupBox1.Controls.Add(lblNom);
            this.groupBox1.Controls.Add(this.txtBoxNom);
            this.groupBox1.Controls.Add(this.btnAnnulerNouveau);
            this.groupBox1.Controls.Add(this.btnConfirmNouveau);
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.txtBoxPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxNbPlaces);
            this.groupBox1.Controls.Add(this.btnSupprActivite);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de l\'activité";
            // 
            // datePickerActivite
            // 
            this.datePickerActivite.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcActivites, "DateActivite", true));
            this.datePickerActivite.Location = new System.Drawing.Point(415, 91);
            this.datePickerActivite.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerActivite.Name = "datePickerActivite";
            this.datePickerActivite.Size = new System.Drawing.Size(161, 20);
            this.datePickerActivite.TabIndex = 22;
            this.datePickerActivite.CloseUp += new System.EventHandler(this.ModifierChamp_Souris);
            this.datePickerActivite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // radioBtnApresMidi
            // 
            this.radioBtnApresMidi.Location = new System.Drawing.Point(494, 117);
            this.radioBtnApresMidi.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnApresMidi.Name = "radioBtnApresMidi";
            this.radioBtnApresMidi.Size = new System.Drawing.Size(81, 16);
            this.radioBtnApresMidi.TabIndex = 21;
            this.radioBtnApresMidi.TabStop = true;
            this.radioBtnApresMidi.Text = "Après-midi";
            this.radioBtnApresMidi.UseVisualStyleBackColor = true;
            this.radioBtnApresMidi.Click += new System.EventHandler(this.ModifierChamp_Souris);
            // 
            // radioBtnMatin
            // 
            this.radioBtnMatin.Location = new System.Drawing.Point(399, 117);
            this.radioBtnMatin.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnMatin.Name = "radioBtnMatin";
            this.radioBtnMatin.Size = new System.Drawing.Size(69, 16);
            this.radioBtnMatin.TabIndex = 20;
            this.radioBtnMatin.TabStop = true;
            this.radioBtnMatin.Text = "Matin";
            this.radioBtnMatin.UseVisualStyleBackColor = true;
            this.radioBtnMatin.Click += new System.EventHandler(this.ModifierChamp_Souris);
            this.radioBtnMatin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "Nom", true));
            this.txtBoxNom.Location = new System.Drawing.Point(103, 52);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(181, 20);
            this.txtBoxNom.TabIndex = 19;
            this.txtBoxNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // btnAnnulerNouveau
            // 
            this.btnAnnulerNouveau.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnulerNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerNouveau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnulerNouveau.Location = new System.Drawing.Point(349, 258);
            this.btnAnnulerNouveau.Name = "btnAnnulerNouveau";
            this.btnAnnulerNouveau.Size = new System.Drawing.Size(149, 31);
            this.btnAnnulerNouveau.TabIndex = 3;
            this.btnAnnulerNouveau.Text = "Annuler";
            this.btnAnnulerNouveau.UseVisualStyleBackColor = false;
            this.btnAnnulerNouveau.Visible = false;
            this.btnAnnulerNouveau.Click += new System.EventHandler(this.btnAnnulerNouveau_Click);
            // 
            // btnConfirmNouveau
            // 
            this.btnConfirmNouveau.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmNouveau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmNouveau.Location = new System.Drawing.Point(170, 258);
            this.btnConfirmNouveau.Name = "btnConfirmNouveau";
            this.btnConfirmNouveau.Size = new System.Drawing.Size(149, 31);
            this.btnConfirmNouveau.TabIndex = 2;
            this.btnConfirmNouveau.Text = "Ajouter";
            this.btnConfirmNouveau.UseVisualStyleBackColor = false;
            this.btnConfirmNouveau.Visible = false;
            this.btnConfirmNouveau.Click += new System.EventHandler(this.btnConfirmNouveau_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(14, 94);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Prix";
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "Prix", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(103, 91);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(181, 20);
            this.txtBoxPrix.TabIndex = 14;
            this.txtBoxPrix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de places";
            // 
            // txtBoxNbPlaces
            // 
            this.txtBoxNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "NbPlace", true));
            this.txtBoxNbPlaces.Location = new System.Drawing.Point(415, 55);
            this.txtBoxNbPlaces.Name = "txtBoxNbPlaces";
            this.txtBoxNbPlaces.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNbPlaces.TabIndex = 5;
            this.txtBoxNbPlaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // btnSupprActivite
            // 
            this.btnSupprActivite.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprActivite.Location = new System.Drawing.Point(349, 258);
            this.btnSupprActivite.Name = "btnSupprActivite";
            this.btnSupprActivite.Size = new System.Drawing.Size(176, 31);
            this.btnSupprActivite.TabIndex = 1;
            this.btnSupprActivite.Text = "Supprimer l\'activité";
            this.btnSupprActivite.UseVisualStyleBackColor = false;
            this.btnSupprActivite.Click += new System.EventHandler(this.btnSupprActivite_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Teal;
            this.btnModifier.Enabled = false;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(170, 258);
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
            this.btnNouveau.Location = new System.Drawing.Point(400, 455);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.Text = "Ajouter une nouvelle activité";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // nbPlaces
            // 
            this.nbPlaces.DataPropertyName = "NbPlace";
            this.nbPlaces.HeaderText = "Nb. de Places";
            this.nbPlaces.MinimumWidth = 8;
            this.nbPlaces.Name = "nbPlaces";
            this.nbPlaces.ReadOnly = true;
            this.nbPlaces.Width = 99;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 49;
            // 
            // bindSrcActivites
            // 
            this.bindSrcActivites.DataSource = typeof(congres.dll.Activite);
            this.bindSrcActivites.CurrentChanged += new System.EventHandler(this.bindSrcActivite_CurrentChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 68;
            // 
            // bindSrcParticipants
            // 
            this.bindSrcParticipants.DataSource = typeof(congres.dll.Congressiste);
            // 
            // FrmActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.tabControlActivite);
            this.Controls.Add(this.btnNouveau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActivites";
            this.Text = "Gestion des activités";
            this.tabControlActivite.ResumeLayout(false);
            this.tabPageActivites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActivite)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.groupBoxParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSrcActivites;
        private System.Windows.Forms.TabControl tabControlActivite;
        private System.Windows.Forms.TabPage tabPageActivites;
        private System.Windows.Forms.DataGridView dataGridActivite;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridParticipants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnulerNouveau;
        private System.Windows.Forms.Button btnConfirmNouveau;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNbPlaces;
        private System.Windows.Forms.Button btnSupprActivite;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.DateTimePicker datePickerActivite;
        private System.Windows.Forms.RadioButton radioBtnApresMidi;
        private System.Windows.Forms.RadioButton radioBtnMatin;
        private System.Windows.Forms.GroupBox groupBoxParticipants;
        private System.Windows.Forms.Button btnAjouterParticipant;
        private System.Windows.Forms.Button btnSupprParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateActivite;
        private System.Windows.Forms.DataGridViewTextBoxColumn AffichageMomentJournee;
        private System.Windows.Forms.Label dateActiviteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcParticipants;
    }
}