using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevo.Text;
            if (elemento != "")
            {
                this.lstElementos.Items.Add(elemento);
                this.txtNuevo.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                int index = this.lstElementos.SelectedIndex;
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
            this.lblIndex.Text = "";
            this.lblItem.Text = "";
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
