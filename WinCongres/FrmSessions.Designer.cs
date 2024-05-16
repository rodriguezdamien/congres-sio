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
            this.AffichageMomentJournee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.radioBtnMatin = new System.Windows.Forms.RadioButton();
            this.radioBtnApresMidi = new System.Windows.Forms.RadioButton();
            this.dateSessionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessions = new System.Windows.Forms.BindingSource(this.components);
            themeLabel = new System.Windows.Forms.Label();
            dateSessionLabel = new System.Windows.Forms.Label();
            this.tabControlSession.SuspendLayout();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.tabPageSessions);
            this.tabControlSession.Controls.Add(this.tabPageDetail);
            this.tabControlSession.Location = new System.Drawing.Point(12, 12);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(1504, 708);
            this.tabControlSession.TabIndex = 0;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridSession);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 29);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSessions.Size = new System.Drawing.Size(1496, 675);
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
            this.dataGridSession.Location = new System.Drawing.Point(3, 0);
            this.dataGridSession.MultiSelect = false;
            this.dataGridSession.Name = "dataGridSession";
            this.dataGridSession.ReadOnly = true;
            this.dataGridSession.RowHeadersWidth = 62;
            this.dataGridSession.RowTemplate.Height = 28;
            this.dataGridSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSession.Size = new System.Drawing.Size(1493, 675);
            this.dataGridSession.TabIndex = 0;
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
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.label8);
            this.tabPageDetail.Controls.Add(this.dataGridView2);
            this.tabPageDetail.Controls.Add(this.groupBox1);
            this.tabPageDetail.Controls.Add(this.btnNouveau);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(1496, 675);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détails";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(940, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Liste des congressistes participants :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(950, 85);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(530, 434);
            this.dataGridView2.TabIndex = 4;
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
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(922, 474);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détail de la session";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(524, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 48);
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
            this.btnAjouter.Location = new System.Drawing.Point(255, 397);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(224, 48);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prix";
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Prix", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(154, 309);
            this.txtBoxPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(269, 26);
            this.txtBoxPrix.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de places";
            // 
            // lblNomPresident
            // 
            this.lblNomPresident.AutoSize = true;
            this.lblNomPresident.Location = new System.Drawing.Point(12, 232);
            this.lblNomPresident.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPresident.Name = "lblNomPresident";
            this.lblNomPresident.Size = new System.Drawing.Size(134, 20);
            this.lblNomPresident.TabIndex = 10;
            this.lblNomPresident.Text = "Nom du président";
            // 
            // lblSalle
            // 
            this.lblSalle.AutoSize = true;
            this.lblSalle.Location = new System.Drawing.Point(12, 157);
            this.lblSalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalle.Name = "lblSalle";
            this.lblSalle.Size = new System.Drawing.Size(44, 20);
            this.lblSalle.TabIndex = 9;
            this.lblSalle.Text = "Salle";
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NbPlace", true));
            this.txtBoxVille.Location = new System.Drawing.Point(623, 85);
            this.txtBoxVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(240, 26);
            this.txtBoxVille.TabIndex = 5;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "NomPresident", true));
            this.txtBoxCp.Location = new System.Drawing.Point(154, 228);
            this.txtBoxCp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCp.Name = "txtBoxCp";
            this.txtBoxCp.Size = new System.Drawing.Size(269, 26);
            this.txtBoxCp.TabIndex = 4;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Salle", true));
            this.txtBoxAdresse.Location = new System.Drawing.Point(154, 152);
            this.txtBoxAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(269, 26);
            this.txtBoxAdresse.TabIndex = 3;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprimer.Location = new System.Drawing.Point(524, 397);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(264, 48);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer l\'hébergement";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Teal;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.Location = new System.Drawing.Point(255, 397);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(224, 48);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(596, 567);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(351, 52);
            this.btnNouveau.TabIndex = 5;
            this.btnNouveau.Text = "Ajouter une nouvelle session";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // themeLabel
            // 
            themeLabel.AutoSize = true;
            themeLabel.Location = new System.Drawing.Point(14, 83);
            themeLabel.Name = "themeLabel";
            themeLabel.Size = new System.Drawing.Size(58, 20);
            themeLabel.TabIndex = 18;
            themeLabel.Text = "Thème";
            // 
            // themeTextBox
            // 
            this.themeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Theme", true));
            this.themeTextBox.Location = new System.Drawing.Point(154, 80);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(269, 26);
            this.themeTextBox.TabIndex = 19;
            // 
            // radioBtnMatin
            // 
            this.radioBtnMatin.Location = new System.Drawing.Point(599, 180);
            this.radioBtnMatin.Name = "radioBtnMatin";
            this.radioBtnMatin.Size = new System.Drawing.Size(104, 24);
            this.radioBtnMatin.TabIndex = 20;
            this.radioBtnMatin.TabStop = true;
            this.radioBtnMatin.Text = "Matin";
            this.radioBtnMatin.UseVisualStyleBackColor = true;
            // 
            // radioBtnApresMidi
            // 
            this.radioBtnApresMidi.Location = new System.Drawing.Point(741, 180);
            this.radioBtnApresMidi.Name = "radioBtnApresMidi";
            this.radioBtnApresMidi.Size = new System.Drawing.Size(122, 24);
            this.radioBtnApresMidi.TabIndex = 21;
            this.radioBtnApresMidi.TabStop = true;
            this.radioBtnApresMidi.Text = "Après-midi";
            this.radioBtnApresMidi.UseVisualStyleBackColor = true;
            // 
            // dateSessionLabel
            // 
            dateSessionLabel.AutoSize = true;
            dateSessionLabel.Location = new System.Drawing.Point(458, 145);
            dateSessionLabel.Name = "dateSessionLabel";
            dateSessionLabel.Size = new System.Drawing.Size(159, 20);
            dateSessionLabel.TabIndex = 21;
            dateSessionLabel.Text = "Date de déroulement";
            // 
            // dateSessionDateTimePicker
            // 
            this.dateSessionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcSessions, "DateSession", true));
            this.dateSessionDateTimePicker.Location = new System.Drawing.Point(623, 140);
            this.dateSessionDateTimePicker.Name = "dateSessionDateTimePicker";
            this.dateSessionDateTimePicker.Size = new System.Drawing.Size(240, 26);
            this.dateSessionDateTimePicker.TabIndex = 22;
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
            // bindSrcSessions
            // 
            this.bindSrcSessions.DataSource = typeof(congres.dll.Session);
            this.bindSrcSessions.CurrentChanged += new System.EventHandler(this.bindSrcSession_CurrentChanged);
            // 
            // FrmSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 743);
            this.Controls.Add(this.tabControlSession);
            this.Name = "FrmSessions";
            this.Text = "FrmSessions";
            this.tabControlSession.ResumeLayout(false);
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSession)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}