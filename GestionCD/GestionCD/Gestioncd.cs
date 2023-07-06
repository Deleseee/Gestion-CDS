using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCD
{
    public partial class Gestioncd : Form
    {
        public Gestioncd()
        {
            InitializeComponent();
        }

        private void Gestioncd_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCd();
        }

        private void busquedaModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevoCd();
        }

        private void busqMod_Click(object sender, EventArgs e)
        {
            busqueda();
        }
        private void nuevoCd()
        {
            CDNuevo nuevo = new CDNuevo();
            nuevo.ShowDialog();
        }
        private void busqueda()
        {
            BusqModCD busqMod = new BusqModCD();
            if(busqMod.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se ha añadido un nuevo CD");
            }
        }
    }
}
