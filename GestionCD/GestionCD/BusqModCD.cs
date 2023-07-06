using System;
using System.Collections;
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
    public partial class BusqModCD : Form
    {   
        ArrayList c = new ArrayList();
        public BusqModCD()
        {
            InitializeComponent();
        }

        private void BusqModCD_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("cds.bin", FileMode.Open);
            BinaryFormatter formato = new BinaryFormatter();
            CD cd = null;
            cd = (CD)formato.Deserialize(fs);
            c.Add(cd);
            fs.Close();
            foreach (CD cds in c){
                listBox1.Items.Add(cds);
            }
        }
    }
}
