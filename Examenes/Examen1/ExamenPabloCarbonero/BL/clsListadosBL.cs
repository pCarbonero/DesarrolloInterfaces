using DAL;
using Entidades;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// Funcion estatica que devuelve una lista completa de objetos de la clase candidatos que obtiene de la clase DAL
        /// </summary>
        /// <returns></returns>
        public static List<clsCandidato> listadoCompletoCandidatosBL()
        {
            List<clsCandidato> listadoCandidatos = new List<clsCandidato>();
            try
            {
                listadoCandidatos = clsListadosDAL.listadoCompletoCandidatosDAL();
            }
            catch (Exception e)
            {
                throw;
            }
           
           return listadoCandidatos;
        }

        /// <summary>
        /// Funcion estatica que devuelve un candidato con un id pasado por parametro que obtiene de la capa DAL
        /// </summary>
        /// <pre>el id debe ser mayor que 0</pre>
        /// <pos>si no encuentra el candidato devuelve un null</pos>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorIdBL(int id)
        {
            clsCandidato candidato;
            candidato = clsListadosDAL.getCandidatoPorId(id);
            return candidato;
        }
    }
}
