using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        private List<Button> botones;
        private List<TextBox> cajasTexto;

        public Form19TablaMultiplicar()
        {
            InitializeComponent();

            botones = new List<Button>();
            cajasTexto = new List<TextBox>();

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
                else if (control is TextBox)
                {
                    cajasTexto.Add((TextBox)control);
                }
            }
            cajasTexto.Reverse();

            Random generador = new Random();
            foreach (var boton in botones)
            {
                boton.Click += Boton_Click;
                int aleaorio = generador.Next(1, 50);
                boton.Text = aleaorio.ToString();
            }
        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            int total = cajasTexto.Count;
            int numero = int.Parse(((Button)sender).Text);

            for (int i = 1; i <= total; ++i)
            {
                int resultado = numero * i;
                cajasTexto[i - 1].Text = resultado.ToString();
            }
        }
    }
}
