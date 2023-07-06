using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace GestionCD
{
    public partial class BusqModCD : Form
    {
        String rutaCaratula = "";
        String caratula="";
        String rg = "..\\..\\img\\";
        String selec1 = "";
        String selec2 = "";
        String seleccionado="";
        public BusqModCD()
        {
            InitializeComponent();
        }

        private void BusqModCD_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ficheroCD.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                try
                {
                    Cds c = (Cds)bf.Deserialize(fs);
                    listacds.Items.Add(c);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error");
                }
            }
            fs.Close();
        }

        private void listacds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listacds.SelectedItems.Count>0) {
                titulo.Text = ((Cds)listacds.SelectedItem).Titulo;
                autor.Text = ((Cds)listacds.SelectedItem).Autor;
                fecha.Text = ((Cds)listacds.SelectedItem).FechaComrpa;
                pais.Text = ((Cds)listacds.SelectedItem).Pais;
                discografica.Text = ((Cds)listacds.SelectedItem).Discografica;
                caratula = (((Cds)listacds.SelectedItem).Caratula);
                if (!caratula.Equals("")) {
                    img.Image = Image.FromFile(caratula);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    img.Image = null;
                }
                if (((Cds)listacds.SelectedItem).Formato.Contains("CD"))
                {
                    cd.Checked = true;
                }
                if (((Cds)listacds.SelectedItem).Formato.Contains("Vinilo"))
                {
                    vinilo.Checked = true;
                }
                switch (((Cds)listacds.SelectedItem).Prestamo)
                {
                    case "Casa":
                        casa.Checked = true;
                        break;
                    case "Prestado":
                        prestado.Checked = true;
                        break;
                    case "Baja":
                        baja.Checked = true;
                        break;
                }
                modificar.Visible = true;
                seleccionado = listacds.SelectedItems.ToString();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        
        private void modificar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Enabled = true;
            }
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = true;
            }
            titulo.Focus();
            guardar.Visible = true;
            imagen.Visible = true;
        }

        private void imagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String r = openFileDialog1.FileName;
                String n = rg + openFileDialog1.SafeFileName;
                if (!File.Exists(n))
                {
                    File.Copy(r, n);
                }
                rutaCaratula = n;
                img.Image = Image.FromFile(rutaCaratula);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                ((Cds)listacds.SelectedItem).Titulo = titulo.Text;
                ((Cds)listacds.SelectedItem).Autor = autor.Text;
                ((Cds)listacds.SelectedItem).FechaComrpa = fecha.Text;
                ((Cds)listacds.SelectedItem).Pais = pais.Text;
                ((Cds)listacds.SelectedItem).Discografica = discografica.Text;
                ((Cds)listacds.SelectedItem).Caratula = caratula;
                foreach (CheckBox check in groupBox1.Controls.OfType<CheckBox>())
                {
                    if (check.Checked == true)
                    {
                        selec1 += check.Text + " ";
                    }
                }
                foreach (RadioButton check in groupBox1.Controls.OfType<RadioButton>())
                {
                    if (check.Checked == true)
                    {
                        selec2 += check.Text;
                    }
                }
                ((Cds)listacds.SelectedItem).Formato = selec1;
                ((Cds)listacds.SelectedItem).Prestamo = selec2;
                FileStream fs = new FileStream("ficheroCD.bin", FileMode.Create); ;
                foreach (Cds i in listacds.Items)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        bf.Serialize(fs, i);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error al serializar el fichero");
                    }
                }
                fs.Close();
                Close();
            }
        }
        private bool validar()
        {
            bool validacion = false;
            int cont = 0;
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
            if (!cd.Checked && !vinilo.Checked)
            {
                errorProvider5.SetError(vinilo, "Debe seleccionar una opcion");
            }
            else
            {
                errorProvider5.Clear();
                cont++;
            }
            if (cont == 5)
            {
                validacion = true;
            }
            return validacion;
        }
    }
}
