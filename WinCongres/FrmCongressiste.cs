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
        public FrmCongressiste()
        {
            InitializeComponent();
        }

        private void FrmCongressiste_Load(object sender, EventArgs e)
        {
            this.bindSrcCongressiste.DataSource = CongressisteManager.GetCongressistes();
        }
    }
}
