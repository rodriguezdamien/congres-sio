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
        bool add = false;

        public FrmCongressiste()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affichage de la liste des congressistes.
        /// </summary>
        private void FrmCongressiste_Load(object sender, EventArgs e)
        {
            this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();
            this.bindSrcHebergement.DataSource = HebergementManager.GetHebergements();
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

        /// <summary>
        /// Ajout d'un congressiste.
        /// </summary>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            add = true;
            btnNouveau.Visible = btnModifier.Visible = false;
            tabControlCongressiste.SelectedIndex = 1;
            btnAjouter.Visible = true;
        }

        /// <summary>
        /// Annulation de la modification ou de l'ajout.
        /// </summary>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if(add)
            {
                annulationAjout();
            }
            else
            {
                //Apl d'une fonction pour annuler lors de la modification
            }
        }

        private void annulationAjout() 
        {
            add = false;
            btnNouveau.Visible = btnModifier.Visible = true;
            tabControlCongressiste.SelectedIndex = 0;
            btnAjouter.Visible = false;
        }

        private void annulationModif() { }
    }
}
