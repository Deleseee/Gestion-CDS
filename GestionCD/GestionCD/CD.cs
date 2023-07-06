using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace GestionCD
{
    [Serializable]
    class CD
    {
        String titulo;
        String autor;
        String fecha;
        String pais;
        String discografia;
        String ruta;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public String Fecha { get => fecha; set => fecha = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Discografia { get => discografia; set => discografia = value; }
        public string Ruta { get => ruta; set => ruta = value; }

        public CD(string titulo, string autor, String fecha, string pais, string discografia, string ruta)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fecha = fecha;
            this.pais = pais;
            this.discografia = discografia;
            this.ruta = ruta;
        }

        public CD(string titulo, string autor, String fecha, string pais, string discografia)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fecha = fecha;
            this.pais = pais;
            this.discografia = discografia;
        }
        public override string ToString()
        {
            return titulo;
        }
    }
}
