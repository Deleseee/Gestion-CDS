using System;
using System.Collections;
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCd();
        }

        private void busquedaModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarCd();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            nuevoCd();
        }

        private void busqMod_Click(object sender, EventArgs e)
        {
            buscarCd();
        }
        private void nuevoCd()
        {
            CDNuevo nuevo = new CDNuevo();
            nuevo.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("CD añadido");
            }
        }
        private void buscarCd()
        {
            BusqModCD busqMod = new BusqModCD();
            busqMod.ShowDialog();
        }
    }
}
