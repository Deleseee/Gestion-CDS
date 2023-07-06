using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCD
{
    public partial class CDNuevo : Form
    {
        String ruta="";
        public CDNuevo()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            CD c;
            if (ruta.Equals("")){
                c = new CD(titulo.Text,autor.Text,fecha.Text,pais.Text,discografica.Text);
            }
            else
            {
                c = new CD(titulo.Text, autor.Text, fecha.Text, pais.Text, discografica.Text,ruta);
            }
            FileStream fs = new FileStream("cds.bin", FileMode.Append);
            BinaryFormatter formato = new BinaryFormatter();
            formato.Serialize(fs, c);
            fs.Close();
            DialogResult = DialogResult.OK;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(ruta);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
