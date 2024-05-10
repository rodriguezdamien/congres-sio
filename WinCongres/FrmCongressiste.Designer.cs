namespace WinCongres
{
    partial class FrmCongressiste
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
            this.tabControlCongressiste = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.dataGridCongressiste = new System.Windows.Forms.DataGridView();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBxCongressiste = new System.Windows.Forms.ComboBox();
            this.comboBxLigue = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblNbEtoiles = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.txtBoxCp = new System.Windows.Forms.TextBox();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcCongressiste = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlCongressiste.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressiste)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCongressiste
            // 
            this.tabControlCongressiste.Controls.Add(this.tabPageListe);
            this.tabControlCongressiste.Controls.Add(this.tabPageDetail);
            this.tabControlCongressiste.Location = new System.Drawing.Point(26, 36);
            this.tabControlCongressiste.Name = "tabControlCongressiste";
            this.tabControlCongressiste.SelectedIndex = 0;
            this.tabControlCongressiste.Size = new System.Drawing.Size(1019, 438);
            this.tabControlCongressiste.TabIndex = 1;
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.dataGridCongressiste);
            this.tabPageListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListe.Size = new System.Drawing.Size(1011, 412);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste des congressistes";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // dataGridCongressiste
            // 
            this.dataGridCongressiste.AutoGenerateColumns = false;
            this.dataGridCongressiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCongressiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.accompteDataGridViewTextBoxColumn});
            this.dataGridCongressiste.DataSource = this.bindSrcCongressiste;
            this.dataGridCongressiste.Location = new System.Drawing.Point(0, 0);
            this.dataGridCongressiste.MultiSelect = false;
            this.dataGridCongressiste.Name = "dataGridCongressiste";
            this.dataGridCongressiste.ReadOnly = true;
            this.dataGridCongressiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCongressiste.Size = new System.Drawing.Size(1011, 412);
            this.dataGridCongressiste.TabIndex = 0;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.label1);
            this.tabPageDetail.Controls.Add(this.dataGridView1);
            this.tabPageDetail.Controls.Add(this.label8);
            this.tabPageDetail.Controls.Add(this.dataGridView2);
            this.tabPageDetail.Controls.Add(this.groupBox1);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(1011, 412);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Information congressiste";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inscriptions aux activités :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(639, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 138);
            this.dataGridView1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Inscriptions aux sessions:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(643, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(353, 138);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBxCongressiste);
            this.groupBox1.Controls.Add(this.comboBxLigue);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.txtBoxNom);
            this.groupBox1.Controls.Add(this.lblNbEtoiles);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblCp);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblNom);
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
            this.groupBox1.Text = "Informations du congressiste";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Accompte", true));
            this.textBox1.Location = new System.Drawing.Point(418, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 20;
            // 
            // comboBxCongressiste
            // 
            this.comboBxCongressiste.FormattingEnabled = true;
            this.comboBxCongressiste.Location = new System.Drawing.Point(449, 52);
            this.comboBxCongressiste.Name = "comboBxCongressiste";
            this.comboBxCongressiste.Size = new System.Drawing.Size(121, 21);
            this.comboBxCongressiste.TabIndex = 19;
            this.comboBxCongressiste.Text = "Hébergement";
            // 
            // comboBxLigue
            // 
            this.comboBxLigue.FormattingEnabled = true;
            this.comboBxLigue.Location = new System.Drawing.Point(321, 52);
            this.comboBxLigue.Name = "comboBxLigue";
            this.comboBxLigue.Size = new System.Drawing.Size(121, 21);
            this.comboBxLigue.TabIndex = 18;
            this.comboBxLigue.Text = "Ligue";
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
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuler.Location = new System.Drawing.Point(349, 258);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(149, 31);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(318, 102);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(43, 13);
            this.lblPrix.TabIndex = 15;
            this.lblPrix.Text = "Prénom";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Nom", true));
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
            this.lblNbEtoiles.Size = new System.Drawing.Size(55, 13);
            this.lblNbEtoiles.TabIndex = 13;
            this.lblNbEtoiles.Text = "Accompte";
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
            // txtBoxTel
            // 
            this.txtBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Tel", true));
            this.txtBoxTel.Location = new System.Drawing.Point(418, 148);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(152, 20);
            this.txtBoxTel.TabIndex = 6;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Prenom", true));
            this.txtBoxPrix.Location = new System.Drawing.Point(418, 99);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(152, 20);
            this.txtBoxPrix.TabIndex = 5;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Cp", true));
            this.txtBoxCp.Location = new System.Drawing.Point(83, 193);
            this.txtBoxCp.Name = "txtBoxCp";
            this.txtBoxCp.Size = new System.Drawing.Size(221, 20);
            this.txtBoxCp.TabIndex = 4;
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Adresse", true));
            this.txtBoxAdresse.Location = new System.Drawing.Point(83, 149);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(221, 20);
            this.txtBoxAdresse.TabIndex = 3;
            // 
            // txtBoxId
            // 
            this.txtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcCongressiste, "Id", true));
            this.txtBoxId.Location = new System.Drawing.Point(83, 52);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(221, 20);
            this.txtBoxId.TabIndex = 2;
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
            this.btnNouveau.Location = new System.Drawing.Point(407, 489);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(234, 34);
            this.btnNouveau.TabIndex = 2;
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
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 47;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "Cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 45;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // accompteDataGridViewTextBoxColumn
            // 
            this.accompteDataGridViewTextBoxColumn.DataPropertyName = "Accompte";
            this.accompteDataGridViewTextBoxColumn.HeaderText = "Accompte";
            this.accompteDataGridViewTextBoxColumn.Name = "accompteDataGridViewTextBoxColumn";
            this.accompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.accompteDataGridViewTextBoxColumn.Width = 80;
            // 
            // bindSrcCongressiste
            // 
            this.bindSrcCongressiste.DataSource = typeof(congres.dll.Congressiste);
            // 
            // FrmCongressiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 541);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.tabControlCongressiste);
            this.Name = "FrmCongressiste";
            this.Text = "Gestion des congressistes";
            this.Load += new System.EventHandler(this.FrmCongressiste_Load);
            this.tabControlCongressiste.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressiste)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCongressiste;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.DataGridView dataGridCongressiste;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblNbEtoiles;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.TextBox txtBoxCp;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.BindingSource bindSrcCongressiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBxCongressiste;
        private System.Windows.Forms.ComboBox comboBxLigue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNouveau;
    }
}