namespace ClasesSharp
{
    public class ClsPersona
    {
        #region Atributos
        private String nombre;
        private int edad;
        private DateTime fechaNac;
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

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        #endregion
    }
}
