using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anho = int.Parse(txtAnho.Text);

            if (mes == 1)
            {
                mes = 13;
                --anho;
            }
            else if (mes == 2)
            {
                mes = 14;
                anho -= 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anho / 4;
            int op3 = anho / 100;
            int op4 = anho / 400;
            int op5 = dia + (mes * 2) + anho + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);

            string diaSemana = "";
            switch (resultado)
            {
                case 0:
                    diaSemana = "Sabado";
                    break;
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Lunes";
                    break;
                case 3:
                    diaSemana = "Martes";
                    break;
                case 4:
                    diaSemana = "Miercoles";
                    break;
                case 5:
                    diaSemana = "Jueves";
                    break;
                case 6:
                    diaSemana = "Viernes";
                    break;
            }

            this.lblResultado.Text = "Naciste un: " + diaSemana;
        }
    }
}
