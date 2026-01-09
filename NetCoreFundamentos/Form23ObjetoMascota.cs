using ProyectoClases.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascota : Form
    {
        XmlSerializer serie;
        private string img;

        public Form23ObjetoMascota()
        {
            InitializeComponent();

            serie = new XmlSerializer(typeof(Mascota));
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //abrir el openfile para seleccionar la img
            openFileDialog1.ShowDialog();
            string ruta = openFileDialog1.FileName;
            img = ruta;
            //dibujamos la img en el form
            pictureBox1.Image = Image.FromFile(ruta);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //write
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Imagen = File.ReadAllBytes(img);

            //las clases que se utilizan son de tipo string
            //para escribir necesitamos la clase StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                serie.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }

            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //leer
            Mascota mascota = new Mascota();
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)serie.Deserialize(reader);
                reader.Close();
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
                txtEdad.Text = mascota.Edad.ToString();
                MemoryStream ms = new MemoryStream(mascota.Imagen);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
    }
}
