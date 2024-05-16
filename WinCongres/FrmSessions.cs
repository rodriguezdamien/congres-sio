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
        public FrmSessions()
        {
            InitializeComponent();
            bindSrcSessions.DataSource = SessionManager.GetSessions();
        }
        /// <summary>
        /// Actions qui seront effectués au moment du changement de l'objet sélectionné dans le Binding :
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindSrcSession_CurrentChanged(object sender, EventArgs e)
        {
            //Si la session est le matin, le radio bouton matin est sélectionné. Sinon, le radio bouton après-midi est sélectionné.
            if (((Session)bindSrcSessions.Current).EstMatin)
                radioBtnMatin.Checked = true;
            else
                radioBtnApresMidi.Checked = true;
        }
    }
}
