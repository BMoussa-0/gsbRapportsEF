using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbrapportsEF
{
    public partial class Menu : Form
    {
        private gsbrapportsEntities mesDonnesEF;
        public Menu()
        {
            InitializeComponent();
            this.mesDonnesEF = new gsbrapportsEntities();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisiteur f = new FrmVisiteur(this.mesDonnesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapport f = new FrmRapport(this.mesDonnesEF);
            f.MdiParent = this;
            f.Show();
        }
    }
}
