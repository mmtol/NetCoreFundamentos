using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09ValidarISBN : Form
    {
        public Form09ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text.Trim();
            bool valido;

            if (isbn.Length == 10)
            {
                valido = true;

                int suma = 0;
                int contador = 1;
                for (int i = 0; i < isbn.Length; ++i)
                {
                    string num = isbn[i].ToString();
                    int mult = int.Parse(num) * contador;
                    suma += mult;
                    ++contador;
                }

                if (suma % 11 == 0)
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }
            }
            else
            {
                valido = false;
            }

            if (valido)
            {
                this.lblResultado.Text = "ISBN válido";
            }
            else
            {
                this.lblResultado.Text = "ISBN inválido";
            }
        }
    }
}
