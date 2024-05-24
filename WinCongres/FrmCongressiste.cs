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
    public partial class FrmCongressiste : Form
    {

        public FrmCongressiste()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affichage de la liste des congressistes.
        /// </summary>
        private void FrmCongressiste_Load(object sender, EventArgs e)
        {
            try
            {


                this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();
                this.bindSrcHebergement.DataSource = HebergementManager.GetHebergements();
                this.bindSrcHebergement.Add(new Hebergement("Sans hébergement"));
                this.bindSrcLigue.DataSource = LigueManager.GetLigues();

                foreach (Congressiste unC in this.bindSrcCongressiste)
                {
                    int i = 0;
                    while (((Hebergement)this.bindSrcHebergement[i]).Id != unC.IdHebergement)
                    {
                        i++;
                    }
                    unC.sonHebergement = (Hebergement)this.bindSrcHebergement[i];
                }

                foreach (Congressiste unC in this.bindSrcCongressiste)
                {
                    int i = 0;
                    while (((Ligue)this.bindSrcLigue[i]).Id != unC.IdLigue)
                    {
                        i++;
                    }
                    unC.laLigue = (Ligue)this.bindSrcLigue[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ajout d'un congressiste.
        /// </summary>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            btnNouveau.Visible = btnModifier.Visible = false;
            tabControlCongressiste.SelectedIndex = 1;
            btnAjouter.Visible = true;
            comboBxLigue.Enabled = comboBxHebergement.Enabled = true;
            txtBoxId.Enabled = false;
            bindSrcCongressiste.AddNew();
        }

        /// <summary>
        /// Annulation de la modification ou de l'ajout.
        /// </summary>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnNouveau.Visible = btnModifier.Visible = true;
            btnAjouter.Visible = false;
            bindSrcCongressiste.CancelEdit();
            bindSrcCongressiste.ResetBindings(false);
            tabControlCongressiste.SelectedIndex = 0;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bindSrcCongressiste.EndEdit();

            ((Congressiste)bindSrcCongressiste.Current).IdLigue = ((Ligue)bindSrcLigue.Current).Id;
            ((Congressiste)bindSrcCongressiste.Current).IdHebergement = ((Hebergement)bindSrcHebergement.Current).Id;
            

            ((Congressiste)bindSrcCongressiste.Current).Id = CongressisteManager.AddCongressiste((Congressiste)bindSrcCongressiste.Current);

            MessageBox.Show("Employé ajouté.", "Information", MessageBoxButtons.OK);
            btnModifier.Visible = false;
            tabControlCongressiste.SelectedIndex = 0;
            btnAjouter.Visible = false;
            comboBxLigue.Enabled = true;
        }

        private void dataGridCongressiste_CurrentCellChanged(object sender, EventArgs e)
        {
            Congressiste unC = (Congressiste)bindSrcCongressiste.Current;
            unC.SessionsInscrit = CongressisteManager.GetSessionsInscrit(unC.Id);
            unC.ActivitesInscrit = CongressisteManager.GetActivitesInscrit(unC.Id);
            bindSrcSession.DataSource = unC.SessionsInscrit;
            bindSrcActivites.DataSource = unC.ActivitesInscrit;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bindSrcHebergement.EndEdit();
            CongressisteManager.UpdtCongressiste((Congressiste)bindSrcCongressiste.Current);


            MessageBox.Show("Informations du congressiste modifié.", "Information", MessageBoxButtons.OK);
            bindSrcHebergement.ResetCurrentItem();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Êtes-vous sûr de vouloir supprimer {((Congressiste)bindSrcCongressiste.Current).Nom} {((Congressiste)bindSrcCongressiste.Current).Prenom} de la liste des congressistes ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    // Supprimer l'hébergement
                    bindSrcCongressiste.EndEdit();
                    CongressisteManager.DelCongressiste(((Congressiste)bindSrcCongressiste.Current).Id);


                    MessageBox.Show("Congresiste supprimé.", "Information", MessageBoxButtons.OK);
                    bindSrcCongressiste.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
