using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numeros = txtNumeros.Text;
            int suma = 0;

            for (int i = 0; i < numeros.Length; ++i)
            {
                string caracter = numeros[i].ToString();
                int num = int.Parse(caracter);
                suma += num;
            }
            this.lblResultado.Text = "La suma es: " + suma;
        }
    }
}
