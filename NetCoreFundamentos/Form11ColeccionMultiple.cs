using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
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

        private void btnResetear_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
            this.lblIndex.Text = "";
            this.lblItem.Text = "";
        }

        private void btnSelecc_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";

            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }

            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }

            this.lblItem.Text = items.TrimEnd(',');
            this.lblIndex.Text = indices.TrimEnd(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nElementos = this.lstElementos.SelectedIndices.Count - 1;

            for (int i = nElementos; i >= 0; --i)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}
