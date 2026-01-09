using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Ruta { get; set; }

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
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(Ruta);
            using (TextReader reader = file.OpenText())
            {
                string content = await reader.ReadToEndAsync();
                reader.Close();
                this.txtContenidoFile.Text = content;
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            //tenemos una clase llamada FileInfo que nos devuelve un file
            //y podemos generar un writer/reader
            FileInfo file = new FileInfo(Ruta);
            //creamos el fichero
            using (TextWriter writer = file.CreateText())
            {
                string content = GetNombresListBox();
                //escribimos en el fichero
                await writer.WriteAsync(content);
                //despues de escribir debemos liberar la memoria
                await writer.FlushAsync();
                //cerramos el fichero
                writer.Close();
                MessageBox.Show("Fichero terminado");
            }
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
