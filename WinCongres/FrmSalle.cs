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
    public partial class FrmSalle : Form
    {
        public FrmSalle()
        {
            InitializeComponent();
        }

        private void FrmSalle_Load(object sender, EventArgs e)
        {
            this.bindSrcSalle.DataSource = SalleManager.GetSalles();
        }



        private void btnNouveau_Click(object sender, EventArgs e)
        {
            tabControlSalle.SelectedIndex = 1;
            btnNouveau.Visible = btnSupprimer.Visible = btnModifier.Visible = false;
            btnAjouter.Visible = true;
            bindSrcSalle.AddNew();
        }

        private void AnnulerModification(object sender, EventArgs e)
        {
            btnNouveau.Visible = btnSupprimer.Visible = btnModifier.Visible = true;
            btnAjouter.Visible = false;
            bindSrcSalle.ResetBindings(false);
            bindSrcSalle.CancelEdit();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Ajouter un nouveau hébergement
                bindSrcSalle.EndEdit();
                ((Salle)bindSrcSalle.Current).Id = SalleManager.AddSalle((Salle)bindSrcSalle.Current);


                MessageBox.Show("Salle ajoutée.", "Information", MessageBoxButtons.OK);
                bindSrcSalle.ResetCurrentItem();
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
                // Modifier la salle
                bindSrcSalle.EndEdit();
                SalleManager.EditSalle((Salle)bindSrcSalle.Current);


                MessageBox.Show("Salle modifiée.", "Information", MessageBoxButtons.OK);
                bindSrcSalle.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer la salle sélectionnée ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Supprimer la salle
                    bindSrcSalle.EndEdit();
                    SalleManager.DeleteSalle((Salle)bindSrcSalle.Current);

                    MessageBox.Show("Salle supprimée.", "Information", MessageBoxButtons.OK);
                    bindSrcSalle.RemoveCurrent();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridSalle_CurrentCellChanged(object sender, EventArgs e)
        {
            Salle uneS = (Salle)bindSrcSalle.Current;
            uneS.LesSessions = SalleManager.GetSessionsBySalle(uneS);
            bindSrcSession.DataSource = uneS.LesSessions;
        }
    }
}
