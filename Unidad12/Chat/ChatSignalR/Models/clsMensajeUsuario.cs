namespace Models
{
    public class clsMensajeUsuario
    {
        #region Propiedades
        public string Grupo { get; set; }
        public string NombreUsuario { get; set; }
        public string MensajeUsuario { get; set; }
        #endregion

        #region constructores
        public clsMensajeUsuario() { }
        public clsMensajeUsuario(string nombreUsuario, string mensajeUsuario)
        {
            NombreUsuario = nombreUsuario;
            MensajeUsuario = mensajeUsuario;
        }

        #endregion
    }
}
