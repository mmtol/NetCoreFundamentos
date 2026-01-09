using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Ruta { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            //cuando hablamos de ruta o caracteres especiales dentro de string,
            //tenemos 2 formas de escribir dichos caracteres
            //1) C:\Carpeta\1.txt
                //Ruta = "C:\\Carpeta\\1.txt";
            //2) Utilizar @ antes del string y fuera del string
                //Ruta = @"C:\Carpeta\1.txt";
            Ruta = "file1.txt";
            helper = new HelperFiles();
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string content = await helper.ReadFileAsync(Ruta);
            this.txtContenidoFile.Text = content;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            string content = GetNombresListBox();
            await helper.WriteFileAsync(Ruta, content);
            MessageBox.Show("Fichero escrito");
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string nombre in this.lstNombres.Items)
            {
                data += nombre + ",";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
