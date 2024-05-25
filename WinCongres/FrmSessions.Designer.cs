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
            System.Windows.Forms.Label lblTheme;
            System.Windows.Forms.Label dateSessionLabel;
            this.tabControlSession = new System.Windows.Forms.TabControl();
            this.tabPageSessions = new System.Windows.Forms.TabPage();
            this.dataGridSession = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affichageMomentJourneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessions = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.groupBoxParticipants = new System.Windows.Forms.GroupBox();
            this.btnSupprParticipant = new System.Windows.Forms.Button();
            this.btnAjouterParticipant = new System.Windows.Forms.Button();
            this.dataGridParticipants = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcParticipants = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxSalle = new System.Windows.Forms.ComboBox();
            this.bindSrcSalles = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxNbPlaces = new System.Windows.Forms.MaskedTextBox();
            this.datePickerSession = new System.Windows.Forms.DateTimePicker();
            this.radioBtnApresMidi = new System.Windows.Forms.RadioButton();
            this.radioBtnMatin = new System.Windows.Forms.RadioButton();
            this.txtBoxTheme = new System.Windows.Forms.TextBox();
            this.btnAnnulerNouveau = new System.Windows.Forms.Button();
            this.btnConfirmNouveau = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomPresident = new System.Windows.Forms.Label();
            this.lblSalle = new System.Windows.Forms.Label();
            this.txtBoxNomPresident = new System.Windows.Forms.TextBox();
            this.btnSupprSession = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.salleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            lblTheme = new System.Windows.Forms.Label();
            dateSessionLabel = new System.Windows.Forms.Label();
            this.tabControlSession.SuspendLayout();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.groupBoxParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Location = new System.Drawing.Point(9, 54);
            lblTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new System.Drawing.Size(40, 13);
            lblTheme.TabIndex = 18;
            lblTheme.Text = "Thème";
            // 
            // dateSessionLabel
            // 
            dateSessionLabel.AutoSize = true;
            dateSessionLabel.Location = new System.Drawing.Point(305, 94);
            dateSessionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateSessionLabel.Name = "dateSessionLabel";
            dateSessionLabel.Size = new System.Drawing.Size(106, 13);
            dateSessionLabel.TabIndex = 21;
            dateSessionLabel.Text = "Date de déroulement";
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.tabPageSessions);
            this.tabControlSession.Controls.Add(this.tabPageDetail);
            this.tabControlSession.Location = new System.Drawing.Point(8, 8);
            this.tabControlSession.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(1049, 430);
            this.tabControlSession.TabIndex = 0;
            this.tabControlSession.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlSession_Selecting);
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridSession);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSessions.Size = new System.Drawing.Size(1041, 404);
            this.tabPageSessions.TabIndex = 0;
            this.tabPageSessions.Text = "Liste des sessions";
            this.tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // dataGridSession
            // 
            this.dataGridSession.AllowUserToAddRows = false;
            this.dataGridSession.AllowUserToDeleteRows = false;
            this.dataGridSession.AllowUserToResizeRows = false;
            this.dataGridSession.AutoGenerateColumns = false;
            this.dataGridSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn,
            this.nomPresidentDataGridViewTextBoxColumn,
            this.LaSalle,
            this.nbPlacesDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateSessionDataGridViewTextBoxColumn,
            this.affichageMomentJourneeDataGridViewTextBoxColumn});
            this.dataGridSession.DataSource = this.bindSrcSessions;
            this.dataGridSession.Location = new System.Drawing.Point(0, 0);
            this.dataGridSession.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.RowHeadersWidth = 62;
            this.dataGridSession.RowTemplate.Height = 28;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(1041, 404);
            this.dataGridSession.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Thème";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "NomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "Président de la session";
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPresidentDataGridViewTextBoxColumn.Width = 140;
            // 
            // LaSalle
            // 
            this.LaSalle.DataPropertyName = "LaSalle";
            this.LaSalle.HeaderText = "Salle";
            this.LaSalle.Name = "LaSalle";
            this.LaSalle.ReadOnly = true;
            this.LaSalle.Width = 55;
            // 
            // nbPlacesDataGridViewTextBoxColumn
            // 
            this.nbPlacesDataGridViewTextBoxColumn.DataPropertyName = "NbPlaces";
            this.nbPlacesDataGridViewTextBoxColumn.HeaderText = "Nombre de places";
            this.nbPlacesDataGridViewTextBoxColumn.Name = "nbPlacesDataGridViewTextBoxColumn";
            this.nbPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesDataGridViewTextBoxColumn.Width = 118;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 49;
            // 
            // dateSessionDataGridViewTextBoxColumn
            // 
            this.dateSessionDataGridViewTextBoxColumn.DataPropertyName = "DateSession";
            this.dateSessionDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateSessionDataGridViewTextBoxColumn.Name = "dateSessionDataGridViewTextBoxColumn";
            this.dateSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSessionDataGridViewTextBoxColumn.Width = 55;
            // 
            // affichageMomentJourneeDataGridViewTextBoxColumn
            // 
            this.affichageMomentJourneeDataGridViewTextBoxColumn.DataPropertyName = "AffichageMomentJournee";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.HeaderText = "Moment de la journée";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.Name = "affichageMomentJourneeDataGridViewTextBoxColumn";
            this.affichageMomentJourneeDataGridViewTextBoxColumn.ReadOnly = true;
            this.affichageMomentJourneeDataGridViewTextBoxColumn.Width = 134;
            // 
            // bindSrcSessions
            // 
            this.bindSrcSessions.DataSource = typeof(congres.dll.Session);
            this.bindSrcSessions.CurrentChanged += new System.EventHandler(this.bindSrcSession_CurrentChanged);
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
            this.idDataGridViewTextBoxColumn1,
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
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 41;
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
            this.bindSrcParticipants.DataMember = "CongressisteParticipants";
            this.bindSrcParticipants.DataSource = this.bindSrcSessions;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxSalle);
            this.groupBox1.Controls.Add(this.txtBoxNbPlaces);
            this.groupBox1.Controls.Add(dateSessionLabel);
            this.groupBox1.Controls.Add(this.datePickerSession);
            this.groupBox1.Controls.Add(this.radioBtnApresMidi);
            this.groupBox1.Controls.Add(this.radioBtnMatin);
            this.groupBox1.Controls.Add(lblTheme);
            this.groupBox1.Controls.Add(this.txtBoxTheme);
            this.groupBox1.Controls.Add(this.btnAnnulerNouveau);
            this.groupBox1.Controls.Add(this.btnConfirmNouveau);
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.txtBoxPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomPresident);
            this.groupBox1.Controls.Add(this.lblSalle);
            this.groupBox1.Controls.Add(this.txtBoxNomPresident);
            this.groupBox1.Controls.Add(this.btnSupprSession);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la session";
            // 
            // cmbBoxSalle
            // 
            this.cmbBoxSalle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcSessions, "LaSalle", true));
            this.cmbBoxSalle.DataSource = this.bindSrcSalles;
            this.cmbBoxSalle.DisplayMember = "Libelle";
            this.cmbBoxSalle.FormattingEnabled = true;
            this.cmbBoxSalle.Location = new System.Drawing.Point(103, 99);
            this.cmbBoxSalle.Name = "cmbBoxSalle";
            this.cmbBoxSalle.Size = new System.Drawing.Size(181, 21);
            this.cmbBoxSalle.TabIndex = 23;
            this.cmbBoxSalle.ValueMember = "Id";
            this.cmbBoxSalle.Click += new System.EventHandler(this.ModifierChamp_Souris);
            this.cmbBoxSalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // bindSrcSalles
            // 
            this.bindSrcSalles.DataSource = typeof(congres.dll.Salle);
            // 
            // txtBoxNbPlaces
            // 
            this.txtBoxNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NbPlaces", true));
            this.txtBoxNbPlaces.Location = new System.Drawing.Point(415, 55);
            this.txtBoxNbPlaces.Name = "txtBoxNbPlaces";
            this.txtBoxNbPlaces.Size = new System.Drawing.Size(160, 20);
            this.txtBoxNbPlaces.TabIndex = 23;
            // 
            // datePickerSession
            // 
            this.datePickerSession.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcSessions, "DateSession", true));
            this.datePickerSession.Location = new System.Drawing.Point(415, 91);
            this.datePickerSession.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerSession.Name = "datePickerSession";
            this.datePickerSession.Size = new System.Drawing.Size(161, 20);
            this.datePickerSession.TabIndex = 22;
            this.datePickerSession.CloseUp += new System.EventHandler(this.ModifierChamp_Souris);
            this.datePickerSession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
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
            // txtBoxTheme
            // 
            this.txtBoxTheme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Theme", true));
            this.txtBoxTheme.Location = new System.Drawing.Point(103, 52);
            this.txtBoxTheme.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTheme.Name = "txtBoxTheme";
            this.txtBoxTheme.Size = new System.Drawing.Size(181, 20);
            this.txtBoxTheme.TabIndex = 19;
            this.txtBoxTheme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
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
            this.lblPrix.Location = new System.Drawing.Point(9, 203);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Prix";
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Prix", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(103, 201);
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
            // lblNomPresident
            // 
            this.lblNomPresident.AutoSize = true;
            this.lblNomPresident.Location = new System.Drawing.Point(8, 151);
            this.lblNomPresident.Name = "lblNomPresident";
            this.lblNomPresident.Size = new System.Drawing.Size(90, 13);
            this.lblNomPresident.TabIndex = 10;
            this.lblNomPresident.Text = "Nom du président";
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(8, 102);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(30, 13);
            this.lblSalle.TabIndex = 9;
            this.lblSalle.Text = "Salle";
            // 
            // txtBoxNomPresident
            // 
            this.txtBoxNomPresident.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NomPresident", true));
            this.txtBoxNomPresident.Location = new System.Drawing.Point(103, 148);
            this.txtBoxNomPresident.Name = "txtBoxNomPresident";
            this.txtBoxNomPresident.Size = new System.Drawing.Size(181, 20);
            this.txtBoxNomPresident.TabIndex = 4;
            this.txtBoxNomPresident.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifierChamp);
            // 
            // btnSupprSession
            // 
            this.btnSupprSession.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprSession.Location = new System.Drawing.Point(349, 258);
            this.btnSupprSession.Name = "btnSupprSession";
            this.btnSupprSession.Size = new System.Drawing.Size(176, 31);
            this.btnSupprSession.TabIndex = 1;
            this.btnSupprSession.Text = "Supprimer la session";
            this.btnSupprSession.UseVisualStyleBackColor = false;
            this.btnSupprSession.Click += new System.EventHandler(this.btnSupprSession_Click);
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
            // salleDataGridViewTextBoxColumn
            // 
            this.salleDataGridViewTextBoxColumn.DataPropertyName = "Salle";
            this.salleDataGridViewTextBoxColumn.HeaderText = "Salle";
            this.salleDataGridViewTextBoxColumn.Name = "salleDataGridViewTextBoxColumn";
            this.salleDataGridViewTextBoxColumn.ReadOnly = true;
            this.salleDataGridViewTextBoxColumn.Width = 55;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(400, 455);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.Text = "Ajouter une nouvelle session";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // FrmSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.tabControlSession);
            this.Controls.Add(this.btnNouveau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSessions";
            this.Text = "Gestion des sessions";
            this.Load += new System.EventHandler(this.FrmSessions_Load);
            this.tabControlSession.ResumeLayout(false);
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.groupBoxParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSrcSessions;
        private System.Windows.Forms.TabControl tabControlSession;
        private System.Windows.Forms.TabPage tabPageSessions;
        private System.Windows.Forms.DataGridView dataGridSession;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridParticipants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnulerNouveau;
        private System.Windows.Forms.Button btnConfirmNouveau;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomPresident;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.TextBox txtBoxNomPresident;
        private System.Windows.Forms.Button btnSupprSession;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtBoxTheme;
        private System.Windows.Forms.DateTimePicker datePickerSession;
        private System.Windows.Forms.RadioButton radioBtnApresMidi;
        private System.Windows.Forms.RadioButton radioBtnMatin;
        private System.Windows.Forms.BindingSource bindSrcParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxParticipants;
        private System.Windows.Forms.Button btnAjouterParticipant;
        private System.Windows.Forms.Button btnSupprParticipant;
        private System.Windows.Forms.MaskedTextBox txtBoxNbPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn salleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbBoxSalle;
        private System.Windows.Forms.BindingSource bindSrcSalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affichageMomentJourneeDataGridViewTextBoxColumn;
    }
}