using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCD
{
    public partial class CDNuevo : Form
    {
        int cont=1;
        String rutaCaratula="";
        String rg = "..\\..\\img\\";
        String selec1="";
        String selec2="";
        public CDNuevo()
        {
            InitializeComponent();
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                foreach (CheckBox check in groupBox1.Controls.OfType<CheckBox>())
                {
                    if (check.Checked == true)
                    {
                        selec1 += check.Text+" ";
                    }
                }
                foreach (RadioButton check in groupBox1.Controls.OfType<RadioButton>())
                {
                    if (check.Checked == true)
                    {
                        selec2 += check.Text;
                    }
                }
                Cds c = new Cds(titulo.Text, autor.Text, fecha.Text, pais.Text, discografica.Text,rutaCaratula,selec1,selec2);
                FileStream fs = new FileStream("ficheroCD.bin", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, c);
                    fs.Close();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (SerializationException)
                {
                   MessageBox.Show("Error al serializar el fichero");
                   fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos que faltan");
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        private bool validar()
        {
            bool validacion=false;
            cont = 0;
            if (titulo.Text.Equals(""))
            {
                errorProvider1.SetError(titulo, "El titulo no debe quedarse en blanco");
            }
            else
            {
                errorProvider1.Clear();
                cont++;
            }
            if (autor.Text.Equals(""))
            {
                errorProvider2.SetError(autor, "El autor no debe quedarse en blanco");
            }
            else
            {
                errorProvider2.Clear();
                cont++;
            }
            if (pais.Text.Equals(""))
            {
                errorProvider3.SetError(pais, "El pais no debe quedarse en blanco");
            }
            else
            {
                errorProvider3.Clear();
                cont++;
            }
            if (discografica.Text.Equals(""))
            {
                errorProvider4.SetError(discografica, "La discografica no debe quedarse en blanco");
            }
            else
            {
                errorProvider4.Clear();
                cont++;
            }
            if (!cd.Checked&&!vinilo.Checked)
            {
                errorProvider6.SetError(vinilo, "Debe seleccionar una opcion");
            }
            else
            {
                errorProvider6.Clear();
                cont++;
            }
            if (cont==5) { 
                validacion = true;
            }
            return validacion;
        }

        private void imagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String r = openFileDialog1.FileName;
                String n = rg+openFileDialog1.SafeFileName;
                if (!File.Exists(n))
                {
                    File.Copy(r, n);
                }
                rutaCaratula = n;
                img.Image = Image.FromFile(rutaCaratula);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
