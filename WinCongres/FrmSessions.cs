using congres.dll.Managers;
using congres.dll;
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
    public partial class FrmSessions : Form
    {
        private bool isEditing = false;

        public FrmSessions()
        {
            InitializeComponent();
            bindSrcSessions.DataSource = SessionManager.GetSessions();
        }
        /// <summary>
        /// Actions qui seront effectuées au moment du changement de la session sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindSrcSession_CurrentChanged(object sender, EventArgs e)
        {
            List<Congressiste> participants = SessionManager.GetParticipantsSession((Session)bindSrcSessions.Current);
            bindSrcParticipants.DataSource = participants;
            //Si la session est le matin, le radio bouton matin est sélectionné. Sinon, le radio bouton après-midi est sélectionné.
            if (((Session)bindSrcSessions.Current).EstMatin)
                radioBtnMatin.Checked = true;
            else
                radioBtnApresMidi.Checked = true;
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Ajouter un participant"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnAjouterParticipant_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Pas encore implémenté");
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer la sélection"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnSupprParticipant_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Pas encore implémenté");
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Ajouter une session"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bindSrcSessions.AddNew();
            //Désactivation des boutons de modifications
            btnNouveau.Enabled = false;
            btnModifier.Visible = false;
            btnSupprSession.Visible = false;
            //On bloque l'ajout de participant mais il serait totalement faisable d'ajouter des participants en même temps que la création de la session.
            btnAjouterParticipant.Enabled = false;
            btnSupprParticipant.Enabled = false;
            //Activation des boutons de création
            btnConfirmNouveau.Visible = true;
            btnAnnulerNouveau.Visible = true;
            tabControlSession.SelectedIndex = 1;
            datePickerSession.Value = DateTime.Now;
            isEditing = true;
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Ajouter" lors de la création d'une session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnConfirmNouveau_Click(object sender, EventArgs e)
        {
                //TODO : AJOUTER LA VERIFCATION DES CHAMPS
                bindSrcSessions.EndEdit();
                Session nouvelleSession = (Session)bindSrcSessions.Current;
                if (radioBtnMatin.Checked)
                    nouvelleSession.EstMatin = true;
                else
                    nouvelleSession.EstMatin = false;
                SessionManager.AddSession(ref nouvelleSession);
                //Réactivation des boutons de modifications
                btnNouveau.Enabled = true;
                btnModifier.Visible = true;
                btnSupprSession.Visible = true;
                btnAjouterParticipant.Enabled = true;
                btnSupprParticipant.Enabled = true;
                //Désactivation des boutons de création
                btnConfirmNouveau.Visible = false;
                btnAnnulerNouveau.Visible = false;
                //Remise à false de isEditing pour "sortir" du "mode" édition
                isEditing = false;
                MessageBox.Show("La session a bien été ajoutée", "Session ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Annuler" lors de la création d'une session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnAnnulerNouveau_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Pas encore implémenté");
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer la session"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Pas encore implémenté");
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer la session"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnSupprSession_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Pas encore implémenté");
        }

        /// <summary>
        /// Actions qui seront effectuées à chaque fois que l'utilisateur change d'onglet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlSession_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Possibilité de mettre le MessageBox ici ?
            if (isEditing)
            {
                if (MessageBox.Show("Des modifications n'ont pas été validés, êtes vous sûr de vouloir continuer ? \n\n Toutes les modifications seront perdues. ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    AnnulerNouveau(sender, e);
                else
                    e.Cancel = true;
            }
        }

        private void AnnulerNouveau(object sender,EventArgs e)
        {
            bindSrcSessions.CancelEdit();
            //Réactivation des boutons de modifications
            btnNouveau.Enabled = true;
            btnModifier.Visible = true;
            btnSupprSession.Visible = true;
            btnAjouterParticipant.Enabled = true;
            btnSupprParticipant.Enabled = true;
            //Désactivation des boutons de création
            btnConfirmNouveau.Visible = false;
            btnAnnulerNouveau.Visible = false;
            //Remise à false de isEditing pour "sortir" du "mode" édition
            isEditing = false;
        }
    }
}
