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
    public partial class FrmHebergements : Form
    {
        public FrmHebergements()
        {
            InitializeComponent();
        }

        private void FrmHebergements_Load(object sender, EventArgs e)
        {
            this.bindSrcHebergement.DataSource = HebergementManager.GetHebergements();
        }

        private void dataGridHebergement_CurrentCellChanged(object sender, EventArgs e)
        {

            Hebergement unH = (Hebergement)bindSrcHebergement.Current;

            if(unH.LesCongressistes != null)
            {
                unH.LesCongressistes.Clear();

            }


            this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();

            foreach (Congressiste unC in this.bindSrcCongressiste)
            {
                if (unC.IdHebergement == unH.Id)
                {
                    unH.LesCongressistes.Add(unC);
                }
            }
            this.bindSrcCongressiste.DataSource = unH.LesCongressistes;
           

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            tabControlHebergement.SelectedIndex = 1;
            btnNouveau.Visible = btnSupprimer.Visible = btnModifier.Visible = false;
            btnAjouter.Visible = true;
            bindSrcHebergement.AddNew();
        }

        private void AnnulerModification(object sender, EventArgs e)
        {
            btnNouveau.Visible = btnSupprimer.Visible = btnModifier.Visible = true;
            btnAjouter.Visible = false;
            bindSrcHebergement.ResetBindings(false);
            bindSrcHebergement.CancelEdit();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Ajouter un nouveau hébergement
                bindSrcHebergement.EndEdit();
                ((Hebergement)bindSrcHebergement.Current).Id = HebergementManager.AddHebergement((Hebergement)bindSrcHebergement.Current);


                MessageBox.Show("Hébergemement ajouté.", "Information", MessageBoxButtons.OK);
                bindSrcHebergement.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Modifier l'hébergement
                bindSrcHebergement.EndEdit();
                HebergementManager.EditHebergement((Hebergement)bindSrcHebergement.Current);


                MessageBox.Show("Hébergemement modifié.", "Information", MessageBoxButtons.OK);
                bindSrcHebergement.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'hébergement sélectionné ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Supprimer l'hébergement
                    bindSrcHebergement.EndEdit();
                    HebergementManager.DeleteHebergement((Hebergement)bindSrcHebergement.Current);

                    MessageBox.Show("Hébergemement supprimé.", "Information", MessageBoxButtons.OK);
                    bindSrcHebergement.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
