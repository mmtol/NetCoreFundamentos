using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        private int contador;

        public Form16ListDelegados()
        {
            InitializeComponent();

            this.contador = 0;
            this.txtContador.Text = this.contador.ToString();

            List<Button> botones = new List<Button>();
            //botones.Add(button1);
            //botones.Add(button2);
            //botones.Add(button3);
            //botones.Add(button4);
            //botones.Add(button5);
            //botones.Add(button6);
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
            }

            foreach (Button btn in botones)
            {
                btn.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            ++contador;
            this.txtContador.Text = this.contador.ToString();
            
            if (this.contador % 2 == 0)
            {
                ((Button)sender).BackColor = Color.LightBlue;
            }
            else
            {
                ((Button)sender).BackColor = Color.LightGreen;
            }
        }
    }
}
