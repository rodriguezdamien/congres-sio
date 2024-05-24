using congres.dll;
using congres.dll.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCongres
{
    public partial class FrmLigue : Form
    {
        public FrmLigue()
        {
            InitializeComponent();
        }

        private void FrmLigue_Load(object sender, EventArgs e)
        {
            this.bindSrcLigue.DataSource = LigueManager.GetLigues();
        }

        private void dataGridLigue_CurrentCellChanged(object sender, EventArgs e)
        {
            this.bindSrcCongressiste.DataSource = LigueManager.GetCongressisteByLigue(((Ligue)bindSrcLigue.Current).Id);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = false;
            btnConfirmNouveau.Visible = true;
            tabControlLigue.SelectedIndex = 1;
            bindSrcLigue.AddNew();
        }

        private void btnAnnulerNouveau_Click(object sender, EventArgs e)
        {
            btnModifier.Visible = true;
            btnConfirmNouveau.Visible = false;
            bindSrcLigue.ResetBindings(false);
            bindSrcLigue.CancelEdit();
        }

        private void btnSupprLigue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Êtes-vous sûr de vouloir supprimer {((Ligue)bindSrcLigue.Current).Nom} de la liste des ligues ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    // Supprimer l'hébergement
                    bindSrcLigue.EndEdit();
                    LigueManager.DelLigue(((Ligue)bindSrcLigue.Current).Id);


                    MessageBox.Show("Ligue supprimé.", "Information", MessageBoxButtons.OK);
                    bindSrcLigue.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnConfirmNouveau_Click(object sender, EventArgs e)
        {
            bindSrcLigue.EndEdit();

            ((Ligue)bindSrcLigue.Current).Id = LigueManager.AddLigue((Ligue)bindSrcLigue.Current);

            MessageBox.Show("Employé ajouté.", "Information", MessageBoxButtons.OK);
            btnModifier.Visible = true;
            btnConfirmNouveau.Visible = false;
            tabControlLigue.SelectedIndex = 0;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bindSrcLigue.EndEdit();
            LigueManager.UpdtLigue((Ligue)bindSrcLigue.Current);

            MessageBox.Show("Informations de la ligue modifiées.", "Information", MessageBoxButtons.OK);
            bindSrcLigue.ResetCurrentItem();
        }
    }
}
