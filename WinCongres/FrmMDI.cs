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
            FrmSessions unFrmSessions = new FrmSessions();

        }
        private void menuBtnActivites_Click(object sender, EventArgs e)
        {

        }
        private void menuBtnHebergements_Click(object sender, EventArgs e)
        {

        }
        private void menuBtnInscriptions_Click(object sender, EventArgs e)
        {

        }
        private void menuBtnLigues_Click(object sender, EventArgs e)
        {

        }


    }
}
