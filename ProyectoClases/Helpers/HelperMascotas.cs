using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //queremos almacenar de forma fisica las mascotas en files
        private HelperFiles helper;
        private string ruta;

        public HelperMascotas()
        {
            Mascotas = new List<Mascota>();
            helper = new HelperFiles();
            ruta = "mascotas.txt";
        }

        //finalidad: el programador escriba write y guardamos las mascotas
                   //el programador escriba read y leemos un string y rellenamos la coleccion

        private void ConvertirMascotasList(string data)
        {
            Mascotas.Clear();
            //separamos cada mascota con @
            string[] datos = data.Split('@');
            foreach(string mascotaString in datos)
            {
                //separamos las propiedades mediante ,
                string[] propiedades = mascotaString.Split(",");
                //convertimos el triste string en objetos
                Mascota  mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                Mascotas.Add(mascota);
            }
        }

        public async Task ReadMascotasAsync()
        {
            //leemos el fichero de mascotas
            string data = await helper.ReadFileAsync(ruta);
            //convertimos el string en list
            ConvertirMascotasList(data);
        }

        //convertimos la coleccion a string
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in Mascotas)
            {
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.Trim('@');
            return data;
        }

        public async Task WriteMascotasAsync()
        {
            //convertimos la coleccion a string
            string data = ConvertirMascotasString();
            //escribimos los datos a file
            await helper.WriteFileAsync(ruta, data);
        }
    }
}
