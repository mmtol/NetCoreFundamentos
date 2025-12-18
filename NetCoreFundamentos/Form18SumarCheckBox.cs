using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckBox : Form
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private bool valido = false;

        public Form18SumarCheckBox()
        {
            InitializeComponent();

            foreach (CheckBox chk in this.panel1.Controls)
            {
                checkBoxes.Add(chk);
                chk.CheckedChanged += Cambio;
            }
        }

        private void Cambio(object? sender, EventArgs e)
        {
            if (valido)
            {
                int suma = int.Parse(this.textBox1.Text);
                CheckBox chk = (CheckBox)sender;
                if (chk.Checked)
                {
                    suma += int.Parse(chk.Text);
                }
                else
                {
                    suma -= int.Parse(chk.Text);
                }
                this.textBox1.Text = suma.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valido = true;

            Random generador = new Random();
            foreach (CheckBox chk in checkBoxes)
            {
                int aleatorio = generador.Next(1, 50);
                chk.Text = aleatorio.ToString();
            }
        }
    }
}
