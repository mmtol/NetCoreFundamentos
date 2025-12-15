using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            bool valido = true;

            int posArroba = email.IndexOf('@');
            string[] split = (email.Substring(posArroba + 1)).Split('.');
            string dominio = split[1];

            int totalArrobas = 0;
            foreach (char letra in email)
            {
                if (letra == '@')
                {
                    ++totalArrobas;
                }
            }

            if (!email.Contains('@') || email.StartsWith('@') || email.EndsWith('@') || totalArrobas > 1)
            {
                valido = false;
            }
            else
            {
                if (!email.Contains('.') || email.IndexOf('.', posArroba) == -1)
                {
                    valido = false;
                }
                else if (dominio.Length < 3 && dominio.Length > 2)
                {
                    valido = false;
                }
            }

            if (valido)
            {
                this.lblResultado.Text = "Email válido";
            }
            else
            {
                this.lblResultado.Text = "Email inválido";
            }
        }
    }
}
