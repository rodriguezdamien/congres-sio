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
        /// Actions qui seront effectuées lors du double clic sur une cellule du tableau des congressistes non participants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridCongressistesNonParticip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Congressiste unCongressiste = (Congressiste)bindSrcCongressistesNonParticip.Current;
            try
            {
                SessionManager.AddParticipant(laSession, unCongressiste);
                laSession.CongressisteParticipants.Add(unCongressiste);
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
