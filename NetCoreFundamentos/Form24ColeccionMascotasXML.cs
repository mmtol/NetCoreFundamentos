using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;

namespace NetCoreFundamentos
{
    public partial class Form24ColeccionMascotasXML : Form
    {
        XmlSerializer serie;
        ColeccionMascotas mascotas;

        public Form24ColeccionMascotasXML()
        {
            InitializeComponent();

            serie = new XmlSerializer(typeof(ColeccionMascotas));
            mascotas = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            lstMascotas.Items.Clear();
            foreach (Mascota mascota in mascotas)
            {
                lstMascotas.Items.Add(mascota.Nombre + ", " + mascota.Raza);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);

            mascotas.Add(mascota);
            DibujarMascotas();

            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccmascotas.xml"))
            {
                mascotas = (ColeccionMascotas)serie.Deserialize(reader);
                reader.Close();

                DibujarMascotas();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("coleccmascotas.xml"))
            {
                serie.Serialize(writer, mascotas);
                await writer.FlushAsync();
                writer.Close();

                lstMascotas.Items.Clear();
                mascotas.Clear();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //abrir el openfile para seleccionar la img
            openFileDialog1.ShowDialog();
            string ruta = openFileDialog1.FileName;
            //dibujamos la img en el form
            pictureBox1.Image = Image.FromFile(ruta);
        }
    }
}
