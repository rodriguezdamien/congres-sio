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
    public partial class FrmSessions : Form
    {
        public FrmSessions()
        {
            InitializeComponent();
            bindSrcSessions.DataSource = SessionManager.GetSessions();
        }

        private void bindSrcSession_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
