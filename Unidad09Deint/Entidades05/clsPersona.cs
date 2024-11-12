namespace Entidades05
{
    public class clsPersona
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime fechaNac { get; set; }
        public string Foto { get; set; }
        public string Direccion { get; set; }
        public int Tlfn { get; set; }
        #endregion

        #region constructores
        public clsPersona() { }
        public clsPersona(string nombre, string apellidos, DateTime fechaNac, string foto, string direccion, int tlfn)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            this.fechaNac = fechaNac;
            Foto = foto;
            Direccion = direccion;
            Tlfn = tlfn;
        }
        #endregion
    }
}
