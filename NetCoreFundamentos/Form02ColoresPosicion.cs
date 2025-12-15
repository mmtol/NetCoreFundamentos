using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPos_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosX.Text);
            int posY = int.Parse(this.txtPosY.Text);
            this.btnCambiarPos.Location = new Point(posX, posY);
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
