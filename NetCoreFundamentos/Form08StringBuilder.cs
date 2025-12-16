using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string txt = this.txtTexto.Text;
            int longitud = txt.Length;

            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i < longitud; ++i)
            {
                char letra = txt[longitud - 1];
                txt = txt.Remove(longitud - 1, 1);
                txt = txt.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Ha tardado " + krono.Elapsed.Microseconds + " microsec";
            this.txtTexto.Text = txt;
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder txt = new StringBuilder();
            txt.Append(this.txtTexto.Text);
            int longitud = txt.Length;

            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i < longitud; ++i)
            {
                char letra = txt[longitud - 1];
                txt = txt.Remove(longitud - 1, 1);
                txt = txt.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Ha tardado " + krono.Elapsed.Microseconds + " microsec";
            this.txtTexto.Text = txt.ToString();
        }
    }
}
