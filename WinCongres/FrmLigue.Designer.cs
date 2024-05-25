namespace WinCongres
{
    partial class FrmLigue
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
            System.Windows.Forms.Label lblId;
            this.tabControlLigue = new System.Windows.Forms.TabControl();
            this.tabPageLigues = new System.Windows.Forms.TabPage();
            this.dataGridLigue = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcLigue = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.groupBoxCongressiste = new System.Windows.Forms.GroupBox();
            this.dataGridCongressiste = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcCongressiste = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxLigue = new System.Windows.Forms.GroupBox();
            this.txtBoxVille = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnAnnulerNouveau = new System.Windows.Forms.Button();
            this.btnConfirmNouveau = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomPresident = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprLigue = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            lblId = new System.Windows.Forms.Label();
            this.tabControlLigue.SuspendLayout();
            this.tabPageLigues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLigue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.groupBoxCongressiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).BeginInit();
            this.groupBoxLigue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(9, 54);
            lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(16, 13);
            lblId.TabIndex = 18;
            lblId.Text = "Id";
            // 
            // tabControlLigue
            // 
            this.tabControlLigue.Controls.Add(this.tabPageLigues);
            this.tabControlLigue.Controls.Add(this.tabPageDetail);
            this.tabControlLigue.Location = new System.Drawing.Point(10, 35);
            this.tabControlLigue.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlLigue.Name = "tabControlLigue";
            this.tabControlLigue.SelectedIndex = 0;
            this.tabControlLigue.Size = new System.Drawing.Size(1049, 410);
            this.tabControlLigue.TabIndex = 1;
            // 
            // tabPageLigues
            // 
            this.tabPageLigues.Controls.Add(this.dataGridLigue);
            this.tabPageLigues.Location = new System.Drawing.Point(4, 22);
            this.tabPageLigues.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLigues.Name = "tabPageLigues";
            this.tabPageLigues.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageLigues.Size = new System.Drawing.Size(1041, 384);
            this.tabPageLigues.TabIndex = 0;
            this.tabPageLigues.Text = "Liste des ligues";
            this.tabPageLigues.UseVisualStyleBackColor = true;
            // 
            // dataGridLigue
            // 
            this.dataGridLigue.AllowUserToAddRows = false;
            this.dataGridLigue.AllowUserToDeleteRows = false;
            this.dataGridLigue.AllowUserToResizeRows = false;
            this.dataGridLigue.AutoGenerateColumns = false;
            this.dataGridLigue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLigue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLigue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dataGridLigue.DataSource = this.bindSrcLigue;
            this.dataGridLigue.Location = new System.Drawing.Point(0, 0);
            this.dataGridLigue.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridLigue.MultiSelect = false;
            this.dataGridLigue.Name = "dataGridLigue";
            this.dataGridLigue.ReadOnly = true;
            this.dataGridLigue.RowHeadersWidth = 62;
            this.dataGridLigue.RowTemplate.Height = 28;
            this.dataGridLigue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLigue.Size = new System.Drawing.Size(1041, 380);
            this.dataGridLigue.TabIndex = 0;
            this.dataGridLigue.CurrentCellChanged += new System.EventHandler(this.dataGridLigue_CurrentCellChanged);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codePostalDataGridViewTextBoxColumn.Width = 88;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // bindSrcLigue
            // 
            this.bindSrcLigue.DataSource = typeof(congres.dll.Ligue);
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.groupBoxCongressiste);
            this.tabPageDetail.Controls.Add(this.groupBoxLigue);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDetail.Size = new System.Drawing.Size(1041, 384);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détails";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // groupBoxCongressiste
            // 
            this.groupBoxCongressiste.Controls.Add(this.dataGridCongressiste);
            this.groupBoxCongressiste.Location = new System.Drawing.Point(626, 29);
            this.groupBoxCongressiste.Name = "groupBoxCongressiste";
            this.groupBoxCongressiste.Size = new System.Drawing.Size(410, 350);
            this.groupBoxCongressiste.TabIndex = 7;
            this.groupBoxCongressiste.TabStop = false;
            this.groupBoxCongressiste.Text = "Liste des congressistes inscrits";
            // 
            // dataGridCongressiste
            // 
            this.dataGridCongressiste.AllowUserToAddRows = false;
            this.dataGridCongressiste.AllowUserToDeleteRows = false;
            this.dataGridCongressiste.AutoGenerateColumns = false;
            this.dataGridCongressiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCongressiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn1,
            this.prenomDataGridViewTextBoxColumn});
            this.dataGridCongressiste.DataSource = this.bindSrcCongressiste;
            this.dataGridCongressiste.Location = new System.Drawing.Point(6, 19);
            this.dataGridCongressiste.MultiSelect = false;
            this.dataGridCongressiste.Name = "dataGridCongressiste";
            this.dataGridCongressiste.ReadOnly = true;
            this.dataGridCongressiste.RowHeadersWidth = 62;
            this.dataGridCongressiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCongressiste.ShowEditingIcon = false;
            this.dataGridCongressiste.Size = new System.Drawing.Size(398, 325);
            this.dataGridCongressiste.TabIndex = 4;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn1.Width = 54;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 68;
            // 
            // bindSrcCongressiste
            // 
            this.bindSrcCongressiste.DataSource = typeof(congres.dll.Congressiste);
            // 
            // groupBoxLigue
            // 
            this.groupBoxLigue.Controls.Add(this.txtBoxVille);
            this.groupBoxLigue.Controls.Add(lblId);
            this.groupBoxLigue.Controls.Add(this.txtBoxId);
            this.groupBoxLigue.Controls.Add(this.btnAnnulerNouveau);
            this.groupBoxLigue.Controls.Add(this.btnConfirmNouveau);
            this.groupBoxLigue.Controls.Add(this.lblPrix);
            this.groupBoxLigue.Controls.Add(this.txtBoxCP);
            this.groupBoxLigue.Controls.Add(this.label4);
            this.groupBoxLigue.Controls.Add(this.lblNomPresident);
            this.groupBoxLigue.Controls.Add(this.lblNom);
            this.groupBoxLigue.Controls.Add(this.txtBoxAdresse);
            this.groupBoxLigue.Controls.Add(this.txtBoxNom);
            this.groupBoxLigue.Controls.Add(this.btnModifier);
            this.groupBoxLigue.Location = new System.Drawing.Point(5, 29);
            this.groupBoxLigue.Name = "groupBoxLigue";
            this.groupBoxLigue.Size = new System.Drawing.Size(615, 350);
            this.groupBoxLigue.TabIndex = 3;
            this.groupBoxLigue.TabStop = false;
            this.groupBoxLigue.Text = "Détails de la ligue";
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcLigue, "Ville", true));
            this.txtBoxVille.Location = new System.Drawing.Point(415, 55);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(160, 20);
            this.txtBoxVille.TabIndex = 23;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcLigue, "Id", true));
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Location = new System.Drawing.Point(103, 52);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(181, 20);
            this.txtBoxId.TabIndex = 19;
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
            this.lblPrix.Location = new System.Drawing.Point(300, 104);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(63, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Code postal";
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcLigue, "CodePostal", true));
            this.txtBoxCP.Location = new System.Drawing.Point(394, 102);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(181, 20);
            this.txtBoxCP.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ville";
            // 
            // lblNomPresident
            // 
            this.lblNomPresident.AutoSize = true;
            this.lblNomPresident.Location = new System.Drawing.Point(8, 151);
            this.lblNomPresident.Name = "lblNomPresident";
            this.lblNomPresident.Size = new System.Drawing.Size(45, 13);
            this.lblNomPresident.TabIndex = 10;
            this.lblNomPresident.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(8, 102);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcLigue, "Adresse", true));
            this.txtBoxAdresse.Location = new System.Drawing.Point(103, 148);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(181, 20);
            this.txtBoxAdresse.TabIndex = 4;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcLigue, "Nom", true));
            this.txtBoxNom.Location = new System.Drawing.Point(103, 99);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(181, 20);
            this.txtBoxNom.TabIndex = 3;
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
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprLigue
            // 
            this.btnSupprLigue.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprLigue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupprLigue.Location = new System.Drawing.Point(533, 450);
            this.btnSupprLigue.Name = "btnSupprLigue";
            this.btnSupprLigue.Size = new System.Drawing.Size(234, 34);
            this.btnSupprLigue.TabIndex = 1;
            this.btnSupprLigue.Text = "Supprimer la ligue";
            this.btnSupprLigue.UseVisualStyleBackColor = false;
            this.btnSupprLigue.Click += new System.EventHandler(this.btnSupprLigue_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(251, 450);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Ajouter une nouvelle ligue";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // FrmLigue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.tabControlLigue);
            this.Controls.Add(this.btnSupprLigue);
            this.Name = "FrmLigue";
            this.Text = "Gestion des ligues";
            this.Load += new System.EventHandler(this.FrmLigue_Load);
            this.tabControlLigue.ResumeLayout(false);
            this.tabPageLigues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLigue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcLigue)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.groupBoxCongressiste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).EndInit();
            this.groupBoxLigue.ResumeLayout(false);
            this.groupBoxLigue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLigue;
        private System.Windows.Forms.TabPage tabPageLigues;
        private System.Windows.Forms.DataGridView dataGridLigue;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.GroupBox groupBoxCongressiste;
        private System.Windows.Forms.DataGridView dataGridCongressiste;
        private System.Windows.Forms.GroupBox groupBoxLigue;
        private System.Windows.Forms.MaskedTextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnAnnulerNouveau;
        private System.Windows.Forms.Button btnConfirmNouveau;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomPresident;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Button btnSupprLigue;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.BindingSource bindSrcLigue;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcCongressiste;
        private System.Windows.Forms.Button btnNouveau;
    }
}