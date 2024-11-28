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

        /// <summary>
        /// Funcion estatica que se encarga de filtrar la lista
        /// </summary>
        /// <pre>la dificultad debe ser de 1 a 5</pre>
        /// <pos>si no hay candidatos disponibles se enviará una lista vacia</pos>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static List<clsCandidato> listadoCandidatosParaMision(int dificultad)
        {
            List<clsCandidato> listaFiltrada = new List<clsCandidato>();

            switch (dificultad)
            {
                case 1 or 2:
                    listaFiltrada = clsListadosDAL.listadoSolicitadoCandidatos("Usa");
                    break;
                case 3:
                    listaFiltrada = clsListadosDAL.listadoSolicitadoCandidatos("Usa", 40);
                    break;
                case 4:
                    listaFiltrada = clsListadosDAL.listadoSolicitadoCandidatos("Italia", 0, 45);
                    break;
                case 5:
                    listaFiltrada = clsListadosDAL.listadoSolicitadoCandidatos("Italia", 45, 55);
                    break;
            }

            if  (listaFiltrada.Count == 0)
            {
                throw new NoCandidatesAvailablesException();
            }
            return listaFiltrada;
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
