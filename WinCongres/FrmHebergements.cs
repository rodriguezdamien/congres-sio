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


            //GetCongresstistesByHebergement

            this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();

            
        }

        private void dataGridHebergement_CurrentCellChanged(object sender, EventArgs e)
        {


            Hebergement unH = (Hebergement)bindSrcHebergement.Current;

            unH.LesCongressistes.Clear();

            this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();
   
            foreach (Congressiste unC in this.bindSrcCongressiste)
            {
                if (unC.IdHebergement == unH.Id)
                {
                    unH.LesCongressistes.Add(unC);
                }
            }
            this.bindSrcLesCongressistes.DataSource = unH.LesCongressistes;

        }

        private void bindSrcHebergement_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
