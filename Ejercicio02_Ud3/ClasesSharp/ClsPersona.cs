namespace ClasesSharp
{
    public class ClsPersona
    {
        #region Atributos
        private String nombre;
        #endregion

        #region constructores
        public ClsPersona(String nombre)
        {
            this.nombre = nombre;
        }

        public ClsPersona()
        {

        }
        #endregion

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion
    }
}
