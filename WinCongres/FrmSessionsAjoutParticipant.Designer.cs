namespace WinCongres
{
    partial class FrmSessionsAjoutParticipant
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
            this.dataGridCongressistesNonParticip = new System.Windows.Forms.DataGridView();
            this.lblHowTo = new System.Windows.Forms.Label();
            this.btnAjouterCongressiste = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcCongressistesNonParticip = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistesNonParticip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressistesNonParticip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCongressistesNonParticip
            // 
            this.dataGridCongressistesNonParticip.AllowUserToAddRows = false;
            this.dataGridCongressistesNonParticip.AutoGenerateColumns = false;
            this.dataGridCongressistesNonParticip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCongressistesNonParticip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCongressistesNonParticip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.dataGridCongressistesNonParticip.DataSource = this.bindSrcCongressistesNonParticip;
            this.dataGridCongressistesNonParticip.Location = new System.Drawing.Point(12, 41);
            this.dataGridCongressistesNonParticip.MultiSelect = false;
            this.dataGridCongressistesNonParticip.Name = "dataGridCongressistesNonParticip";
            this.dataGridCongressistesNonParticip.ReadOnly = true;
            this.dataGridCongressistesNonParticip.RowHeadersWidth = 62;
            this.dataGridCongressistesNonParticip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCongressistesNonParticip.ShowEditingIcon = false;
            this.dataGridCongressistesNonParticip.Size = new System.Drawing.Size(380, 338);
            this.dataGridCongressistesNonParticip.TabIndex = 5;
            this.dataGridCongressistesNonParticip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCongressistesNonParticip_CellDoubleClick);
            // 
            // lblHowTo
            // 
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.Location = new System.Drawing.Point(43, 9);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(322, 26);
            this.lblHowTo.TabIndex = 6;
            this.lblHowTo.Text = "Double-cliquez ou sélectionnez un congressiste\r\npuis cliquez sur \"Ajouter\" pour a" +
    "jouter un congressiste à la session.";
            this.lblHowTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjouterCongressiste
            // 
            this.btnAjouterCongressiste.Location = new System.Drawing.Point(101, 391);
            this.btnAjouterCongressiste.Name = "btnAjouterCongressiste";
            this.btnAjouterCongressiste.Size = new System.Drawing.Size(161, 34);
            this.btnAjouterCongressiste.TabIndex = 7;
            this.btnAjouterCongressiste.Text = "Ajouter la sélection";
            this.btnAjouterCongressiste.UseVisualStyleBackColor = true;
            this.btnAjouterCongressiste.Click += new System.EventHandler(this.btnAjouterCongressiste_Click);
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
            // bindSrcCongressistesNonParticip
            // 
            this.bindSrcCongressistesNonParticip.DataSource = typeof(congres.dll.Congressiste);
            // 
            // FrmSessionsAjoutParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 437);
            this.Controls.Add(this.btnAjouterCongressiste);
            this.Controls.Add(this.lblHowTo);
            this.Controls.Add(this.dataGridCongressistesNonParticip);
            this.Name = "FrmSessionsAjoutParticipant";
            this.Text = "Ajouter un participant à la session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCongressistesNonParticip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCongressistesNonParticip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCongressistesNonParticip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcCongressistesNonParticip;
        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.Button btnAjouterCongressiste;
    }
}