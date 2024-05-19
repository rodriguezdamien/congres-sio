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
            System.Windows.Forms.Label themeLabel;
            System.Windows.Forms.Label dateSessionLabel;
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
            this.dataGridParticipants = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcParticipants = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateSessionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioBtnApresMidi = new System.Windows.Forms.RadioButton();
            this.radioBtnMatin = new System.Windows.Forms.RadioButton();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomPresident = new System.Windows.Forms.Label();
            this.lblSalle = new System.Windows.Forms.Label();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxCp = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.groupBoxParticipants = new System.Windows.Forms.GroupBox();
            this.btnAjouterParticipants = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            themeLabel = new System.Windows.Forms.Label();
            dateSessionLabel = new System.Windows.Forms.Label();
            this.tabControlSession.SuspendLayout();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeLabel
            // 
            themeLabel.AutoSize = true;
            themeLabel.Location = new System.Drawing.Point(9, 54);
            themeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new System.Drawing.Size(40, 13);
            themeLabel.TabIndex = 18;
            themeLabel.Text = "Thème";
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
            this.tabControlSession.Size = new System.Drawing.Size(1049, 410);
            this.tabControlSession.TabIndex = 0;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridSession);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSessions.Size = new System.Drawing.Size(1041, 384);
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
            this.dataGridSession.Location = new System.Drawing.Point(2, 0);
            this.dataGridSession.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.RowHeadersWidth = 62;
            this.dataGridSession.RowTemplate.Height = 28;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(1039, 434);
            this.dataGridSession.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
            this.themeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "NomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "Président";
            this.nomPresidentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPresidentDataGridViewTextBoxColumn.Width = 76;
            // 
            // nbPlaceDataGridViewTextBoxColumn
            // 
            this.nbPlaceDataGridViewTextBoxColumn.DataPropertyName = "NbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.HeaderText = "Nb. de Places";
            this.nbPlaceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nbPlaceDataGridViewTextBoxColumn.Name = "nbPlaceDataGridViewTextBoxColumn";
            this.nbPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlaceDataGridViewTextBoxColumn.Width = 99;
            // 
            // salleDataGridViewTextBoxColumn
            // 
            this.salleDataGridViewTextBoxColumn.DataPropertyName = "Salle";
            this.salleDataGridViewTextBoxColumn.HeaderText = "Salle";
            this.salleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salleDataGridViewTextBoxColumn.Name = "salleDataGridViewTextBoxColumn";
            this.salleDataGridViewTextBoxColumn.ReadOnly = true;
            this.salleDataGridViewTextBoxColumn.Width = 55;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 49;
            // 
            // dateSessionDataGridViewTextBoxColumn
            // 
            this.dateSessionDataGridViewTextBoxColumn.DataPropertyName = "DateSession";
            this.dateSessionDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateSessionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateSessionDataGridViewTextBoxColumn.Name = "dateSessionDataGridViewTextBoxColumn";
            this.dateSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSessionDataGridViewTextBoxColumn.Width = 55;
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
            this.tabPageDetail.Size = new System.Drawing.Size(1041, 384);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détails";
            this.tabPageDetail.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(dateSessionLabel);
            this.groupBox1.Controls.Add(this.dateSessionDateTimePicker);
            this.groupBox1.Controls.Add(this.radioBtnApresMidi);
            this.groupBox1.Controls.Add(this.radioBtnMatin);
            this.groupBox1.Controls.Add(themeLabel);
            this.groupBox1.Controls.Add(this.themeTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxPrix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomPresident);
            this.groupBox1.Controls.Add(this.lblSalle);
            this.groupBox1.Controls.Add(this.txtBoxVille);
            this.groupBox1.Controls.Add(this.txtBoxCp);
            this.groupBox1.Controls.Add(this.txtBoxAdresse);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de la session";
            // 
            // dateSessionDateTimePicker
            // 
            this.dateSessionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcSessions, "DateSession", true));
            this.dateSessionDateTimePicker.Location = new System.Drawing.Point(415, 91);
            this.dateSessionDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateSessionDateTimePicker.Name = "dateSessionDateTimePicker";
            this.dateSessionDateTimePicker.Size = new System.Drawing.Size(161, 20);
            this.dateSessionDateTimePicker.TabIndex = 22;
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
            // 
            // themeTextBox
            // 
            this.themeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Theme", true));
            this.themeTextBox.Location = new System.Drawing.Point(103, 52);
            this.themeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(181, 20);
            this.themeTextBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(349, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Teal;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouter.Location = new System.Drawing.Point(170, 258);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(149, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prix";
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Prix", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(103, 201);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(181, 20);
            this.txtBoxPrix.TabIndex = 14;
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
            // txtBoxVille
            // 
            this.txtBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NbPlace", true));
            this.txtBoxVille.Location = new System.Drawing.Point(415, 55);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(161, 20);
            this.txtBoxVille.TabIndex = 5;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NomPresident", true));
            this.txtBoxCp.Location = new System.Drawing.Point(103, 148);
            this.txtBoxCp.Name = "txtBoxCp";
            this.txtBoxCp.Size = new System.Drawing.Size(181, 20);
            this.txtBoxCp.TabIndex = 4;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Salle", true));
            this.txtBoxAdresse.Location = new System.Drawing.Point(103, 99);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(181, 20);
            this.txtBoxAdresse.TabIndex = 3;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimer.Location = new System.Drawing.Point(349, 258);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(176, 31);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer l\'hébergement";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Teal;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(170, 258);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(149, 31);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(398, 423);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.Text = "Ajouter une nouvelle session";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // groupBoxParticipants
            // 
            this.groupBoxParticipants.Controls.Add(this.button2);
            this.groupBoxParticipants.Controls.Add(this.btnAjouterParticipants);
            this.groupBoxParticipants.Controls.Add(this.dataGridParticipants);
            this.groupBoxParticipants.Location = new System.Drawing.Point(626, 29);
            this.groupBoxParticipants.Name = "groupBoxParticipants";
            this.groupBoxParticipants.Size = new System.Drawing.Size(410, 350);
            this.groupBoxParticipants.TabIndex = 7;
            this.groupBoxParticipants.TabStop = false;
            this.groupBoxParticipants.Text = "Liste des congressistes participants";
            // 
            // btnAjouterParticipants
            // 
            this.btnAjouterParticipants.Location = new System.Drawing.Point(68, 308);
            this.btnAjouterParticipants.Name = "btnAjouterParticipants";
            this.btnAjouterParticipants.Size = new System.Drawing.Size(124, 31);
            this.btnAjouterParticipants.TabIndex = 5;
            this.btnAjouterParticipants.Text = "Ajouter un participant";
            this.btnAjouterParticipants.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Supprimer la sélection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 480);
            this.Controls.Add(this.tabControlSession);
            this.Controls.Add(this.btnNouveau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSessions";
            this.Text = "FrmSessions";
            this.tabControlSession.ResumeLayout(false);
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcParticipants)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxParticipants.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridParticipants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomPresident;
        private System.Windows.Forms.Label lblSalle;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxCp;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.DateTimePicker dateSessionDateTimePicker;
        private System.Windows.Forms.RadioButton radioBtnApresMidi;
        private System.Windows.Forms.RadioButton radioBtnMatin;
        private System.Windows.Forms.BindingSource bindSrcParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxParticipants;
        private System.Windows.Forms.Button btnAjouterParticipants;
        private System.Windows.Forms.Button button2;
    }
}