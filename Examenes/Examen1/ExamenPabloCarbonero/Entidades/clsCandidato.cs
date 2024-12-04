namespace Entidades
{
    public class clsCandidato
    {
        #region atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructores
        public clsCandidato() { }
        public clsCandidato(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        #endregion
    }
}
