using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class LLamadodecarpeta : Form
    {
        public LLamadodecarpeta()
        {
            InitializeComponent();
        }

        private void LLamadodecarpeta_Load(object sender, EventArgs e)
        {

        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            string Carpeta = this.txtCargar.Text;
            DirectoryInfo di = new DirectoryInfo(Carpeta);
            this.Carpetas.Items.Clear();
            foreach (var archivo in di.GetDirectories())
            {
                this.Carpetas.Items.Add(archivo);
            }
        }

        private void Carpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Carpeta1 = this.txtCargar.Text + Carpetas.SelectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(Carpeta1);
            this.Archivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {

                this.Archivos.Items.Add(archivo);
            }
        }

        private void Archivos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            {
                try
                {
                    string file = this.txtCargar.Text + Carpetas.SelectedItem.ToString() + Archivos.SelectedItem.ToString();
                    FileStream archivo = new FileStream(file, FileMode.Open);
                    StreamReader sr = new StreamReader(archivo);
                    string cad, aux = "";
                    cad = sr.ReadLine();
                    while (cad != null)
                    {
                        aux += cad + Environment.NewLine;
                        cad = sr.ReadLine();
                    }
                    this.Texto.Text = aux;
                    sr.Close();

                }
                catch (IOException e1)
                {
                    MessageBox.Show(e1.Message.ToString());
                }
            }

        }
    }
}

