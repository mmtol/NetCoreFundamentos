using System;
using System.Collections.Generic;
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

        private int _Edad;
        private Generos _Genero;
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
                    if (value == genero)
                    {
                        _Genero = value;
                    }
                    else
                    {
                        throw new Exception("Género no válido");
                    }
                }
            }
        }

        #endregion

        public Persona()
        {
            
        }

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
