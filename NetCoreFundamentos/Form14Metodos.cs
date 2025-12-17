using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text != "")
            {
                int num = int.Parse(this.txtNumero.Text);
                this.GetDobleValor(num);
                this.lblResultado.Text = num.ToString();
            }
        }

        private void GetDobleValor(int num)
        {
            num *= 2;
        }

        private void btnObj_Click(object sender, EventArgs e)
        {
            CambiarColor(this.btnObj);
        }

        private void CambiarColor(Button boton)
        {
            if (boton.BackColor == Color.Aqua)
            {
                boton.BackColor = Color.White;

            }
            else
            {
                boton.BackColor = Color.Aqua;
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text != "")
            {
                int num = int.Parse(this.txtNumero.Text);
                this.GetDobleRef(ref num);
                this.lblResultado.Text = num.ToString();
            }
        }

        private void GetDobleRef(ref int num)
        {
            num *= 2;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text != "")
            {
                int num = int.Parse(this.txtNumero.Text);
                num = this.GetDobleReturn(num);
                this.lblResultado.Text = num.ToString();
            }
        }

        private int GetDobleReturn(int num)
        {
            return num * 2;
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + " - Y: " + e.Y;
        }

        private void txtNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
