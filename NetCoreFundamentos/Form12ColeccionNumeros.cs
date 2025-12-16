using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        private int[] nums;

        public Form12ColeccionNumeros()
        {
            InitializeComponent();
            nums = new int[10];
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random generador = new Random();
            int aleatorio;
            for (int i = 0; i < 10; ++i)
            {
                aleatorio = generador.Next(1, 100);
                nums[i] = aleatorio;
                this.lstNumeros.Items.Add(aleatorio);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                suma += nums[i];

                if (nums[i] % 2 == 0)
                {
                    pares += nums[i];
                }
                else
                {
                    impares += nums[i];
                }
            }

            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
