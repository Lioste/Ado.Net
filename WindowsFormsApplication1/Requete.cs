using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Requete : Form
    {
        public Requete()
        {
            InitializeComponent();
        }

        private void Requete_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fOURNISSEURTableAdapter.Fill(this.dataSet1.FOURNISSEUR);

        }
    }
}
