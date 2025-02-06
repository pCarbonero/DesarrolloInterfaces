namespace Models
{
    public class clsMensajeUsuario
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
        public string Sala { get; set; }
        #endregion

        #region constructores
        public clsMensajeUsuario() { }
        public clsMensajeUsuario(string nombreUsuario, string mensajeUsuario)
        {
            Nombre = nombreUsuario;
            Mensaje = mensajeUsuario;
        }

        public clsMensajeUsuario(string nombreUsuario, string mensajeUsuario, string grupo)
        {
            Nombre = nombreUsuario;
            Mensaje = mensajeUsuario;
            Sala = grupo;
        }

        #endregion
    }
}
