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
    public partial class FrmActivites : Form
    {
        private bool isEditing = false;

        /// <summary>
        /// Constructeur du formulaire : Affiche les activités
        /// </summary>
        public FrmActivites()
        {
            InitializeComponent();
        }

        private void FrmActivites_Load(object sender, EventArgs e)
        {
            try
            {
                this.bindSrcActivites.DataSource = ActiviteManager.GetActivites();
                foreach(Activite uneActivite in bindSrcActivites)
                {
                    uneActivite.NbPlacesRestantes = ActiviteManager.GetPlacesRestantes(uneActivite);
                }
                datePickerActivite.MinDate = new DateTime(DateTime.Now.Year, 6, 1);
                datePickerActivite.MaxDate = new DateTime(DateTime.Now.Year, 6, 30);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Actions qui seront effectuées au moment du changement de l'activité sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindSrcActivite_CurrentChanged(object sender, EventArgs e)
        {
            //Illisible, mais permet de récupérer les participants de l'activité sélectionnée, puis de les afficher dans le tableau des participants
            ((Activite)bindSrcActivites.Current).CongressisteParticipants = ActiviteManager.GetParticipantsActivite((Activite)bindSrcActivites.Current);
            bindSrcParticipants.DataSource = ((Activite)bindSrcActivites.Current).CongressisteParticipants;
            //Si l'activité est le matin, le radio bouton matin est sélectionné. Sinon, le radio bouton après-midi est sélectionné.
            if (((Activite)bindSrcActivites.Current).EstMatin)
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
            Activite uneActivite = (Activite)bindSrcActivites.Current;
            FrmAjoutParticipant frmActivitesAjoutParticipant = new FrmAjoutParticipant(ref uneActivite);
            frmActivitesAjoutParticipant.ShowDialog();
            bindSrcParticipants.ResetBindings(false);
            if (uneActivite.NbPlacesRestantes <= 0)
                btnAjouterParticipant.Enabled = false;
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
            Activite activite = (Activite)bindSrcActivites.Current;
            if (MessageBox.Show($"Voulez-vous vraiment supprimer {congressisteASuppr.Prenom} {congressisteASuppr.Nom} de cette activité ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActiviteManager.DeleteParticipant(activite, congressisteASuppr);
                bindSrcParticipants.RemoveCurrent();
                activite.NbPlacesRestantes++;
                btnAjouterParticipant.Enabled = true;
                MessageBox.Show("Le participant a bien été supprimé.", "Participant supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Ajouter une activité"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bindSrcActivites.AddNew();
            //Désactivation des boutons de modifications
            btnNouveau.Enabled = false;
            btnModifier.Visible = false;
            btnSupprActivite.Visible = false;
            //On bloque l'ajout de participant mais il serait totalement faisable d'ajouter des participants en même temps que la création de l'activité.
            btnAjouterParticipant.Enabled = false;
            btnSupprParticipant.Enabled = false;
            //Activation des boutons de création
            btnConfirmNouveau.Visible = true;
            btnAnnulerNouveau.Visible = true;
            tabControlActivite.SelectedIndex = 1;
            datePickerActivite.Value = new DateTime(DateTime.Now.Year, 6, 1);
            isEditing = true;
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Ajouter" lors de la création d'une activité
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
                if (string.IsNullOrWhiteSpace(txtBoxNbPlaces.Text) || string.IsNullOrWhiteSpace(txtBoxPrix.Text) || string.IsNullOrEmpty(txtBoxNom.Text))
                    throw new Exception("Veuillez remplir tous les champs.");
                //Vérification de la date de l'activité, elle ne peut pas être antérieure à la date actuelle.
                if (datePickerActivite.Value < DateTime.Now)
                    throw new Exception("La date de l'activité ne peut pas être antérieure à la date actuelle.");
                //Vérification de la sélection du moment de la journée, il faut qu'au moins un soit sélectionné.
                if (!radioBtnMatin.Checked && !radioBtnApresMidi.Checked)
                    throw new Exception("Veuillez sélectionner le moment de la journée de l'activité.");
                if (!int.TryParse(txtBoxNbPlaces.Text, out _) || !decimal.TryParse(txtBoxPrix.Text, out _))
                    throw new Exception("Veuillez saisir des valeurs numériques pour le nombre de places et le prix.");
                bindSrcActivites.EndEdit();
                Activite nouvelleActivite = (Activite)bindSrcActivites.Current;
                if (radioBtnMatin.Checked)
                    nouvelleActivite.EstMatin = true;
                else
                    nouvelleActivite.EstMatin = false;
                nouvelleActivite.DateActivite = nouvelleActivite.DateActivite.Date;
                ActiviteManager.AddActivite(ref nouvelleActivite);
                //Réactivation des boutons de modifications
                btnNouveau.Enabled = true;
                btnModifier.Visible = true;
                btnSupprActivite.Visible = true;
                nouvelleActivite.NbPlacesRestantes = ActiviteManager.GetPlacesRestantes(nouvelleActivite);
                if (nouvelleActivite.NbPlacesRestantes <= 0)
                    btnAjouterParticipant.Enabled = false;
                else
                btnAjouterParticipant.Enabled = true;
                btnSupprParticipant.Enabled = true;
                //Désactivation des boutons de création
                btnConfirmNouveau.Visible = false;
                btnAnnulerNouveau.Visible = false;
                //Remise à false de isEditing pour "sortir" du "mode" édition
                isEditing = false;
                MessageBox.Show("l'activité a bien été ajoutée", "Activite ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Annuler" lors de la création d'une activité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnAnnulerNouveau_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment annuler la création de l'activité ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                AnnulerModif(sender, e);
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Modifier l'activité"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                //Vérification des champs textes, il ne faut aucun champ vide.
                if (string.IsNullOrWhiteSpace(txtBoxNbPlaces.Text) || string.IsNullOrWhiteSpace(txtBoxPrix.Text) || string.IsNullOrEmpty(txtBoxNom.Text))
                    throw new Exception("Veuillez remplir tous les champs.");
                if (!int.TryParse(txtBoxNbPlaces.Text, out _) || !decimal.TryParse(txtBoxPrix.Text, out _))
                    throw new Exception("Veuillez saisir des valeurs numériques pour le nombre de places et le prix.");
                //Vérification de la date de l'activité, elle ne peut pas être antérieure à la date actuelle.
                if (datePickerActivite.Value < DateTime.Now)
                    throw new Exception("La date de la activité ne peut pas être antérieure à la date actuelle.");
                //Vérification de la sélection du moment de la journée, il faut qu'au moins un soit sélectionné.
                if (!radioBtnMatin.Checked && !radioBtnApresMidi.Checked)
                    throw new Exception("Veuillez sélectionner le moment de la journée de l'activité.");
                if (int.Parse(txtBoxNbPlaces.Text) < ((Activite)bindSrcActivites.Current).CongressisteParticipants.Count)
                    throw new Exception("La session ne peut pas avoir moins de places que de congressistes inscrits.");
                bindSrcActivites.EndEdit();
                Activite activiteModifiee = (Activite)bindSrcActivites.Current;
                if (radioBtnMatin.Checked)
                    activiteModifiee.EstMatin = true;
                else
                    activiteModifiee.EstMatin = false;
                activiteModifiee.DateActivite = activiteModifiee.DateActivite.Date;
                ActiviteManager.UpdateActivite(activiteModifiee);
                isEditing = false;
                activiteModifiee.NbPlacesRestantes = ActiviteManager.GetPlacesRestantes(activiteModifiee);
                if (activiteModifiee.NbPlacesRestantes <= 0)
                    btnAjouterParticipant.Enabled = false;
                else
                    btnAjouterParticipant.Enabled = true;
                btnModifier.Enabled = false;
                MessageBox.Show("l'activité a bien été modifiée", "Activite modifiée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées lors du clic sur le bouton "Supprimer l'activité"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void btnSupprActivite_Click(object sender, EventArgs e)
        {
            Activite activiteASuppr = (Activite)bindSrcActivites.Current;
            if (MessageBox.Show("Voulez-vous vraiment supprimer l'activité ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActiviteManager.DeleteActivite(activiteASuppr);
                bindSrcActivites.RemoveCurrent();
                MessageBox.Show("L'activité a bien été supprimée.", "Activite supprimée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Actions qui seront effectuées à chaque fois que l'utilisateur change d'onglet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlActivite_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (((Activite)bindSrcActivites.Current).NbPlacesRestantes <= 0)
                btnAjouterParticipant.Enabled = false;
            else
                btnAjouterParticipant.Enabled = true;
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
        /// Fonction qui permet d'annuler les modifications en cours (Changement d'onglet, annulation de création ou de modification de l'activité)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnnulerModif(object sender,EventArgs e)
        {
            if (((Activite)bindSrcActivites.Current).Id == 0)
                bindSrcActivites.RemoveCurrent();
            bindSrcActivites.CancelEdit();
            bindSrcActivites.ResetBindings(false);
            //Réactivation des boutons de modifications
            btnNouveau.Enabled = true;
            btnModifier.Visible = true;
            btnSupprActivite.Visible = true;
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