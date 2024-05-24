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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void menuBtnSessions_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSessions"] == null)
            {
                FrmSessions unFrmSessions = new FrmSessions();
                unFrmSessions.MdiParent = this;
                unFrmSessions.Show();
            }
            else
            {
                Application.OpenForms["FrmSessions"].Focus();
            }
        }
        private void menuBtnActivites_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmActivites"] == null)
            {
                FrmActivites unFrmActivites = new FrmActivites();
                unFrmActivites.MdiParent = this;
                unFrmActivites.Show();
            }
            else
            {
                Application.OpenForms["FrmActivites"].Focus();
            }
        }
        private void menuBtnHebergements_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmHebergements"] == null)
            {
                FrmHebergements unFrmHebergement = new FrmHebergements();
                unFrmHebergement.MdiParent = this;
                unFrmHebergement.Show();
            }
            else
            {
                Application.OpenForms["FrmHebergements"].Focus();
            }
        }
        private void menuBtnInscriptions_Click(object sender, EventArgs e)
        {

        }
        private void menuBtnLigues_Click(object sender, EventArgs e)
        {

        }

        private void btnCongressiste_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmCongressiste"] == null)
            {
                FrmCongressiste unFrmHebergement = new FrmCongressiste();
                unFrmHebergement.MdiParent = this;
                unFrmHebergement.Show();
            }
            else
            {
                Application.OpenForms["FrmCongressiste"].Focus();
            }
        }

        private void menuBtnSalle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmSalle"] == null)
            {
                FrmSalle unFrmSalle = new FrmSalle();
                unFrmSalle.MdiParent = this;
                unFrmSalle.Show();
            }
            else
            {
                Application.OpenForms["FrmSalle"].Focus();
            }
        }
    }
}
