using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        private List<Button> botones;
        private bool valido;

        public Form17SumarBotones()
        {
            InitializeComponent();

            valido = false;

            this.botones = new List<Button>();
            foreach (Button btn in this.panel1.Controls)
            {
                botones.Add(btn);
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            if (valido)
            {
                Button btn = (Button)sender;
                int numero = int.Parse(btn.Text);
                int total = int.Parse(this.txtSuma.Text);
                total += numero;
                this.txtSuma.Text = total.ToString();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            valido = true;

            Random generador = new Random();
            foreach (Button btn in this.botones)
            {
                int aleatorio = generador.Next(1, 50);
                btn.Text = aleatorio.ToString();
            }
        }
    }
}
