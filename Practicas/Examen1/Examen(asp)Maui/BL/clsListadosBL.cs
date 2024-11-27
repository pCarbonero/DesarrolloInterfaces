using Entidades;
using DAL;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// Funcion oisjdksdnvokl
        /// </summary>
        /// <returns></returns>
        public static List<clsMision> listadoCompletoMisionesBL()
        {
            List<clsMision> lista = clsListadosDAL.listadoCompletoMisionesDAL();
            return lista;
        }

        public static List<clsCandidato> listadoCompletoCandidatosBL()
        {
            List<clsCandidato> lista = clsListadosDAL.listadoCompletoCandidatosDAL();
            return lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorIdDAL(int id)
        {
            clsCandidato candidato = clsListadosDAL.getCandidatoPorIdDAL(id);
            return candidato;
        }

        /// <summary>
        /// Funcion estatica que devuelve a una mision con un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsMision getMisionPorIdDAL(int id)
        {
            clsMision mision = clsListadosDAL.getMisionPorIdDAL(id);
            return mision;
        }
    }
}
