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
    public partial class FrmSessionsAjoutParticipant : Form
    {
        Session laSession;
        /// <summary>
        /// Constructeur du formulaire : Affiche les congressistes ne participant pas à une session pour que l'utilisateur puisse ajouter un nouveau participant.
        /// </summary>
        /// <param name="uneSession">La session où l'utilisateur souhaite ajouter un participant</param>
        public FrmSessionsAjoutParticipant(ref Session uneSession)
        {
            InitializeComponent();
            laSession = uneSession;
            bindSrcCongressistesNonParticip.DataSource = SessionManager.GetCongressistesNonParticipants(uneSession);
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
        /// Ajoute un congressiste à la session et ferme le formulaire.
        /// </summary>
        private void AjouterCongressiste()
        {
            Congressiste unCongressiste = (Congressiste)bindSrcCongressistesNonParticip.Current;
            try
            {
                SessionManager.AddParticipant(laSession, unCongressiste);
                laSession.CongressisteParticipants.Add(unCongressiste);
                MessageBox.Show($"{unCongressiste.Prenom} {unCongressiste.Nom} a bien été ajouté à la session.", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
