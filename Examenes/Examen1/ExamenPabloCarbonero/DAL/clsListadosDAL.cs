using Entidades;

namespace DAL
{
    public class clsListadosDAL
    {
        private static List<clsCandidato> listadoCandidatos = new List<clsCandidato>()
        {
            new clsCandidato(1, "Paulie Gualtieri"),
            new clsCandidato(2, "Christopher Moltisanti"),
            new clsCandidato(3, "Silvio Dante"),
            new clsCandidato(4, "Vito Spatafore"),
            new clsCandidato(5, "Ralph Cifaretto"),
            new clsCandidato(6, "Furio Giunta"),
            new clsCandidato(7, "Carlo Cervasi"),
            new clsCandidato(8, "Jackie Aprile, Jr."),
            new clsCandidato(9, "Richie Aprile"),
            new clsCandidato(10, "Bobby Baccalieri"),
            new clsCandidato(11, "Phil Leotardo"),
            new clsCandidato(12, "Big Pussy Bonpensiero"),
            new clsCandidato(13, "Benny Fazio"),
            new clsCandidato(14, "Tony Blundetto"),
            new clsCandidato(15, "Little Paulie Germani")
        };

        /// <summary>
        /// Funcion estatica que devuelve una lista completa de objetos de la clase candidatos
        /// </summary>
        /// <returns></returns>
        public static List<clsCandidato> listadoCompletoCandidatosDAL()
        {
            return listadoCandidatos;
        }

        /// <summary>
        /// Funcion estatica que devuelve un candidato con un id pasado por parametro
        /// </summary>
        /// <pre>el id debe ser mayor que 0</pre>
        /// <pos>si no encuentra el candidato devuelve un null</pos>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorId(int id)
        {
            clsCandidato candidato;
            candidato = (clsCandidato)listadoCandidatos.Where(per => per.Id == id).FirstOrDefault();
            return candidato;
        }
    }
}
