using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_asp_Maui.Models
{
    public class clsCandidatoEdad: clsCandidato
    {
        private int edad;

        public int Edad { get { return edad; } }

        public clsCandidatoEdad(clsCandidato padre)
        {
            Id = padre.Id;
            Nombre = padre.Nombre;
            Apellido = padre.Apellido;
            FechaNac = padre.FechaNac;
            Direccion = padre.Direccion;
            Nacionalidad = padre.Nacionalidad;
            PrecioMedio = padre.PrecioMedio;

            edad = DateTime.Now.Year - FechaNac.Year;

            if (FechaNac.DayOfYear < DateTime.Now.DayOfYear)
            {
                edad -= 1;
            }
        }
    }
}
