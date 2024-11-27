namespace Entidades
{
    public class clsCandidato
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNac {  get; set; }
        public int PrecioMedio { get; set; }
        #endregion

        #region Constructores

        public clsCandidato() { }
        public clsCandidato(int id, string nombre, string apellido, string direccion, string nacionalidad, DateTime fechaNac, int precioMedio)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Nacionalidad = nacionalidad;
            FechaNac = fechaNac;
            PrecioMedio = precioMedio;
        }


        #endregion
    }
}
