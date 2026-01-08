using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    #region ENUMS
    public enum Generos { Fem, Masc }
    public enum Paises {Spain, Italia, Belgica, Noruega}
    #endregion

    public class Persona
    {
        #region ATTR
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Paises Pais { get; set; }
        public Direccion Domicilio { get; set; }
        public Direccion Vacaciones { get; set; }

        private int _Edad;
        private Generos _Genero;
        private string _Descripcion;

        #endregion

        #region PROPS
        public int Edad
        {
            get 
            { 
                return _Edad; 
            }
            set 
            { 
                if (value < 0)
                {
                    _Edad = 0;
                    //throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }

        public Generos Genero
        {
            get 
            { 
                return _Genero; 
            }
            set 
            { 
                foreach (Generos genero in Enum.GetValues(typeof(Generos)))
                {
                    _Genero = value;

                    //if (value == genero)
                    //{
                    //    _Genero = value;
                    //}
                    //else
                    //{
                    //    throw new Exception("Género no válido");
                    //}
                }
            }
        }

        public string this[int index]
        {
            get 
            { 
                return _Descripcion; 
            }
            set 
            {
                Random generador = new Random();
                int aleatorio = generador.Next(1, 20);
                this._Descripcion = "Descripcion" + aleatorio;
            }
        }

        #endregion

        #region CONSTRUCTOR
        public Persona()
        {
            Debug.WriteLine("Constructor Persona vacio");
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

            Debug.WriteLine("Constructor Persona con 2 param");
        }

        #endregion

        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public string GetNombreCompleto(bool reves)
        {
            string nombre;
            if (reves)
            {
                nombre = this.Apellido + ", " + this.Nombre;
            }
            else
            {
                nombre = GetNombreCompleto();
            }

            return nombre;
        }

        #endregion
    }
}
