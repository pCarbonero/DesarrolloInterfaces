using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsMision
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dificultad {  get; set; }
        #endregion

        #region constructores
        public clsMision() { }

        public clsMision(int id, string nombre, int dificultad)
        {
            Id = id;
            Nombre = nombre;
            Dificultad = dificultad;
        }
        #endregion
    }
}
