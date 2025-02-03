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
    public partial class FrmRapport : Form
    {   
        private gsbrapportsEntities mesDonneesEf;
        public FrmRapport(gsbrapportsEntities mesDonneesEf)
        {
            InitializeComponent();
            this.mesDonneesEf = mesDonneesEf;
            this.bdgsRapport.DataSource = mesDonneesEf.rapports.ToList();
            var visiteurs = mesDonneesEf.visiteurs.ToList();
            foreach (var visiteur in visiteurs) 
            { this.cmbVisiteur.Items.Add(visiteur.id); }
            this.cmbVisiteur.SelectedIndexChanged += cmbVisiteur_SelectedIndexChanged;
        }

        private void dtgvRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmRapport_Load(object sender, EventArgs e)
        {

        }

        private void cmbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbVisiteur.SelectedItem != null)
                {
                    string visiteurId = cmbVisiteur.SelectedItem.ToString();
          
                    var rapportsFiltres = mesDonneesEf.rapports
                                            .Where(r => r.idVisiteur == visiteurId)
                                            .ToList();

                    this.bdgsRapport.DataSource = rapportsFiltres;
                }
            }
        }
    }
}
