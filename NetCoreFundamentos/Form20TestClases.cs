using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Pepa";
            persona.Apellido = "Pepita";
            persona.Edad = -20;

            persona.Genero = Generos.Fem;
            persona.Pais = Paises.Noruega;

            persona.Domicilio = new Direccion("calle", "ciudad", "codigo postal");
            persona.Vacaciones = new Direccion("calle vacaciones", "ciudad vacaciones");

            persona[0] = "Desc 0";
            persona[1] = "Desc 1";

            this.lstPersonas.Items.Add(persona.Nombre + " " + persona.Apellido + ", " + persona.Edad + ", " + persona.Genero + ", " + persona.Pais + ", " + persona.Domicilio.Calle + ", " + persona.Vacaciones.Calle);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("nombre emp", "apellido emp");
        }
    }
}