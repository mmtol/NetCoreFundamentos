using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFiles : Form
    {
        HelperMascotas helper;

        public Form22MascotasFiles()
        {
            InitializeComponent();

            helper = new HelperMascotas();
        }
        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;

            helper.Mascotas.Add(mascota);
            DibujarMascotas();
        }

        //creamos un metodo para dibujar en la lista las mascotas
        private void DibujarMascotas()
        {
            lstMascotas.Items.Clear();
            foreach (Mascota mascota in helper.Mascotas)
            {
                lstMascotas.Items.Add(mascota.Nombre+", "+mascota.Raza);
            }
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            await helper.ReadMascotasAsync();
            DibujarMascotas();
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            await helper.WriteMascotasAsync();
            lstMascotas.Items.Clear();
        }
    }
}
