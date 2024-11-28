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
        /// Funcion estatica que se encarga de filtrar la lista
        /// </summary>
        /// <pre>la dificultad debe ser de 1 a 5</pre>
        /// <pos>si no hay candidatos disponibles se enviará una lista vacia</pos>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static List<clsCandidato> listadoCandidatosParaMision(int dificultad)
        {
            List<clsCandidato> listaFiltrada = new List<clsCandidato>();
            List<clsCandidato> listaCompleta = clsListadosBL.listadoCompletoCandidatosBL();

            switch (dificultad)
            {
                case 1 or 2: 
                    listaFiltrada = listaCompleta.Where(per => per.Nacionalidad == "Usa").ToList();
                    break;
                case 3:
                    listaFiltrada = listaCompleta.Where(per => per.Nacionalidad == "Usa" && 
                    (DateTime.Now.Year - per.FechaNac.Year - (DateTime.Now.DayOfYear < per.FechaNac.DayOfYear ? 1 : 0)) >= 40).ToList();
                    break;
                case 4:
                    listaFiltrada = listaCompleta.Where(per => per.Nacionalidad == "Italia" && DateTime.Now.Year - per.FechaNac.Year < 45).ToList();
                    break;
                case 5:
                    listaFiltrada = listaCompleta.Where(per => per.Nacionalidad == "Italia" && 
                    (DateTime.Now.Year - per.FechaNac.Year >= 45 && DateTime.Now.Year - per.FechaNac.Year <= 55)).ToList();
                    break;
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
