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
    public partial class Form23ObjetoMascota : Form
    {
        XmlSerializer serie;

        public Form23ObjetoMascota()
        {
            InitializeComponent();

            serie = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)serie.Deserialize(reader);
                reader.Close();
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
                txtEdad.Text = mascota.Edad.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);

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
        }
    }
}
