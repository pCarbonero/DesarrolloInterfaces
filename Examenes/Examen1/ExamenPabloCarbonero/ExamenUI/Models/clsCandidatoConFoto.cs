using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUI.Models
{
    public class clsCandidatoConFoto: clsCandidato
    {
        public String Imagen { get; set; }

        public clsCandidatoConFoto(clsCandidato padre)
        {
            Id = padre.Id;
            Nombre = padre.Nombre;
            Imagen = "f"+Id+"f.jfif";
        }
    }
}
