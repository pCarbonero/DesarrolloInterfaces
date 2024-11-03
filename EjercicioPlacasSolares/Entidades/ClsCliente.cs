namespace Entidades
{
    public class ClsCliente
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Tlfn { get; set; }
        #endregion

        #region Constructor
        public ClsCliente() { }
        public ClsCliente(string nombre, string direccion, int tlfn)
        {
            Nombre = nombre;
            Direccion = direccion;
            Tlfn = tlfn;
        }
    
        #endregion
    }
}
