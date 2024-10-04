namespace ClasesMauiHM
{
    public class ClsPersona
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        public ClsPersona(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }

        public ClsPersona() { }
    }
}
