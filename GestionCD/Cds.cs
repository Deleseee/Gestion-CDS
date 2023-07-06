using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCD
{
    [Serializable]
    public class Cds
    {

        String titulo;
        String autor;
        String fechaComrpa;
        String pais;
        String discografica;
        String caratula;
        String formato;
        String prestamo;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string FechaComrpa { get => fechaComrpa; set => fechaComrpa = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Discografica { get => discografica; set => discografica = value; }
        public string Caratula { get => caratula; set => caratula = value; }
        public String Formato { get => formato; set => formato = value; }
        public String Prestamo { get => prestamo; set => prestamo = value; }

        public Cds(string titulo, string autor, string fechaComrpa, string pais, string discografica, string caratula, String formato, String prestamo)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaComrpa = fechaComrpa;
            this.pais = pais;
            this.discografica = discografica;
            this.caratula = caratula;
            this.formato = formato;
            this.prestamo = prestamo;
        }

        public override string ToString()
        {
            return titulo;
        }

    }
}
