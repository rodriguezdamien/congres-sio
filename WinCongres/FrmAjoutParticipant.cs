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
    public partial class FrmAjoutParticipant : Form
    {
        Session laSession;
        Activite activite;
        /// <summary>
        /// Constructeur du formulaire pour les sessions : Affiche les congressistes ne participant pas à une session pour que l'utilisateur puisse ajouter un nouveau participant.
        /// </summary>
        /// <param name="uneSession">La session où l'utilisateur souhaite ajouter un participant</param>
        public FrmAjoutParticipant(ref Session uneSession)
        {
            InitializeComponent();
            laSession = uneSession;
            bindSrcCongressistesNonParticip.DataSource = SessionManager.GetCongressistesNonParticipants(uneSession);
        }

        /// <summary>
        /// Constructeur du formulaire pour les activités : Affiche les congressistes ne participant pas à une activité pour que l'utilisateur puisse ajouter un nouveau participant.
        /// </summary>
        public FrmAjoutParticipant(ref Activite uneActivite)
        {
            InitializeComponent();
            activite = uneActivite;
            bindSrcCongressistesNonParticip.DataSource = ActiviteManager.GetCongressistesNonParticipants(uneActivite);
        }

        /// <summary>
        /// Gère le double clic sur une ligne du datagridview pour ajouter un congressiste à la session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridCongressistesNonParticip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AjouterCongressiste();
        }

        /// <summary>
        /// Gère le clic sur le bouton "Ajouter" pour ajouter un congressiste à la session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterCongressiste_Click(object sender, EventArgs e)
        {
            AjouterCongressiste();
        }

        /// <summary>
        /// Ajoute un congressiste à la session ou à l'activité et ferme le formulaire.
        /// </summary>
        private void AjouterCongressiste()
        {
            Congressiste unCongressiste = (Congressiste)bindSrcCongressistesNonParticip.Current;
            try
            {
                if (activite != null)
                {
                    ActiviteManager.AddParticipant(activite, unCongressiste);
                    activite.CongressisteParticipants.Add(unCongressiste);
                    MessageBox.Show($"{unCongressiste.Prenom} {unCongressiste.Nom} a bien été ajouté à l'activité.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SessionManager.AddParticipant(laSession, unCongressiste);
                    laSession.CongressisteParticipants.Add(unCongressiste);
                    MessageBox.Show($"{unCongressiste.Prenom} {unCongressiste.Nom} a bien été ajouté à la session.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
