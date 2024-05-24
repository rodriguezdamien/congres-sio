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

        /// <summary>
        /// Constructeur du formulaire : Affiche les sessions
        /// </summary>
        public FrmSessions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSessions_Load(object sender, EventArgs e)
        {
            try
            {
                bindSrcSessions.DataSource = SessionManager.GetSessions();
                bindSrcSalles.DataSource = SalleManager.GetSalles();
                foreach (Session session in bindSrcSessions)
                {
                    int i = 0;
                    while (((Salle)bindSrcSalles[i]).Id != session.IdSalle)
                    {
                        i++;
                    }
                    session.LaSalle = (Salle)bindSrcSalles[i];
                }
            }
            finally { }
        }

        /// <summary>
        /// Actions qui seront effectuées au moment du changement de la session sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindSrcSession_CurrentChanged(object sender, EventArgs e)
        {
            //Illisible, mais permet de récupérer les participants de la session sélectionnée, puis de les afficher dans le tableau des participants
            ((Session)bindSrcSessions.Current).CongressisteParticipants = SessionManager.GetParticipantsSession((Session)bindSrcSessions.Current);
            bindSrcParticipants.DataSource = ((Session)bindSrcSessions.Current).CongressisteParticipants;
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
            Session uneSession = (Session)bindSrcSessions.Current;
            FrmAjoutParticipant frmSessionsAjoutParticipant = new FrmAjoutParticipant(ref uneSession);
            frmSessionsAjoutParticipant.ShowDialog();
            bindSrcParticipants.ResetBindings(false);
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer la sélection"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnSupprParticipant_Click(object sender, EventArgs e)
        {
            Congressiste congressisteASuppr = (Congressiste)bindSrcParticipants.Current;
            Session session = (Session)bindSrcSessions.Current;
            if (MessageBox.Show($"Voulez-vous vraiment supprimer {congressisteASuppr.Prenom} {congressisteASuppr.Nom} de cette session ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.DeleteParticipant(session, congressisteASuppr);
                bindSrcParticipants.RemoveCurrent();
                MessageBox.Show("Le participant a bien été supprimé.", "Participant supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            try
            {
                //Vérification des champs (y a des meilleures manières de faire je conçois mais bon)
                //Vérification des champs textes, il ne faut aucun champ vide.
                if (string.IsNullOrWhiteSpace(txtBoxNbPlaces.Text) || string.IsNullOrWhiteSpace(txtBoxNomPresident.Text) || string.IsNullOrWhiteSpace(txtBoxPrix.Text) || string.IsNullOrEmpty(txtBoxTheme.Text))
                    throw new Exception("Veuillez remplir tous les champs.");
                //Vérification de la date de la session, elle ne peut pas être antérieure à la date actuelle.
                if (datePickerSession.Value < DateTime.Now)
                    throw new Exception("La date de la session ne peut pas être antérieure à la date actuelle.");
                //Vérification de la sélection du moment de la journée, il faut qu'au moins un soit sélectionné.
                if (!radioBtnMatin.Checked && !radioBtnApresMidi.Checked)
                    throw new Exception("Veuillez sélectionner le moment de la journée de la session.");
                
                bindSrcSessions.EndEdit();
                Session nouvelleSession = (Session)bindSrcSessions.Current;
                if (radioBtnMatin.Checked)
                    nouvelleSession.EstMatin = true;
                else
                    nouvelleSession.EstMatin = false;
                nouvelleSession.DateSession = nouvelleSession.DateSession.Date;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Annuler" lors de la création d'une session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnAnnulerNouveau_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment annuler la création de la session ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                AnnulerModif(sender, e);
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Modifier la session"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                //Vérification des champs textes, il ne faut aucun champ vide.
                if (string.IsNullOrWhiteSpace(txtBoxNbPlaces.Text) || string.IsNullOrWhiteSpace(txtBoxNomPresident.Text) || string.IsNullOrWhiteSpace(txtBoxPrix.Text) || string.IsNullOrEmpty(txtBoxTheme.Text))
                    throw new Exception("Veuillez remplir tous les champs.");
                //Vérification de la date de la session, elle ne peut pas être antérieure à la date actuelle.
                if (datePickerSession.Value < DateTime.Now)
                    throw new Exception("La date de la session ne peut pas être antérieure à la date actuelle.");
                //Vérification de la sélection du moment de la journée, il faut qu'au moins un soit sélectionné.
                if (!radioBtnMatin.Checked && !radioBtnApresMidi.Checked)
                    throw new Exception("Veuillez sélectionner le moment de la journée de la session.");
                
                bindSrcSessions.EndEdit();
                Session sessionModifie = (Session)bindSrcSessions.Current;
                if (radioBtnMatin.Checked)
                    sessionModifie.EstMatin = true;
                else
                    sessionModifie.EstMatin = false;
                sessionModifie.DateSession = sessionModifie.DateSession.Date;
                SessionManager.UpdateSession(sessionModifie);
                isEditing = false;
                btnModifier.Enabled = false;
                MessageBox.Show("La session a bien été modifiée", "Session modifiée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer la session"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnSupprSession_Click(object sender, EventArgs e)
        {
            Session sessionASuppr = (Session)bindSrcSessions.Current;
            if (MessageBox.Show("Voulez-vous vraiment supprimer la session ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.DeleteSession(sessionASuppr);
                bindSrcSessions.RemoveCurrent();
                MessageBox.Show("La session a bien été supprimée.", "Session supprimée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    AnnulerModif(sender, e);
                else
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Fonction qui permet d'annuler les modifications en cours (Changement d'onglet, annulation de création ou de modification de session)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnnulerModif(object sender,EventArgs e)
        {
            bindSrcSessions.CancelEdit();
            bindSrcSessions.ResetBindings(false);
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
            btnModifier.Enabled = false;
        }

        private void ModifierChamp(object sender, KeyEventArgs e)
        {
            isEditing = true;
            btnModifier.Enabled = true;
        }

        /// <summary>
        /// Permet de savoir si un utilisateur a modifié un champ avec sa souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierChamp_Souris(object sender, EventArgs e)
        {
            isEditing = true;
            btnModifier.Enabled = true;
        }
    }
}