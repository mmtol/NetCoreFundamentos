using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();

            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            if (this.lstTienda.Items.Contains(producto))
            {
                this.lstTienda.SelectedItem = producto;
            }
            else
            {
                this.lstTienda.Items.Add(producto);
            }
            this.txtProducto.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstAlmacen.Items.Add(this.lstTienda.Items[index]);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.Items.Count; ++i)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.Items[i]);
            }

            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex != -1)
            {
                int index = this.lstAlmacen.SelectedIndex;
                string producto = this.lstAlmacen.SelectedItem.ToString();

                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index - 1, producto);

                this.lstAlmacen.SelectedItem = producto;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex != -1)
            {
                int index = this.lstAlmacen.SelectedIndex;
                string producto = this.lstAlmacen.SelectedItem.ToString();

                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index + 1, producto);

                this.lstAlmacen.SelectedItem = producto;
            }
        }
    }
}
