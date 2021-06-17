using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tápanyag_kalkulátor
{
    public partial class Tapanyag_kalkulator : Form
    {
        public Tapanyag_kalkulator()
        {
            InitializeComponent();
        }

        private void alapanyagokÉlelmiszerekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Alapanyagok AlapanyagokAblak = new Alapanyagok();
            AlapanyagokAblak.MdiParent = this;
            AlapanyagokAblak.Dock = DockStyle.Fill;
            AlapanyagokAblak.Show();
        }

        private void kalkulátorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Kalkulator KalkulatorAblak = new Kalkulator();
            KalkulatorAblak.MdiParent = this;
            KalkulatorAblak.Dock = DockStyle.Fill;
            KalkulatorAblak.Show();
        }

        private void Tapanyag_kalkulator_Load(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Alapanyagok AlapanyagokAblak = new Alapanyagok();
            AlapanyagokAblak.MdiParent = this;
            AlapanyagokAblak.Dock = DockStyle.Fill;
            AlapanyagokAblak.Show();
        }

        private void receptekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Receptek ReceptekAblak = new Receptek();
            ReceptekAblak.MdiParent = this;
            ReceptekAblak.Dock = DockStyle.Fill;
            ReceptekAblak.Show();
        }
    }
}