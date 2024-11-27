using Entidades;

namespace DAL
{
    public class clsListadosDAL
    {
        private static List<clsCandidato> listadoCandidatos = new List<clsCandidato>
        {
            new clsCandidato(1, "Giovanni", "Rossi", "Via Roma 12", "Italia", new DateTime(1973, 6, 2), 45000),
            new clsCandidato(2, "Luca", "Bianchi", "Piazza Venezia 8", "Italia", new DateTime(1984, 3, 12), 50000),
            new clsCandidato(3, "Matteo", "Ricci", "Corso Italia 22", "Italia", new DateTime(1999, 4, 5), 47000),
            new clsCandidato(4, "Francesco", "Esposito", "Via Milano 5", "Italia", new DateTime(1988, 7, 14), 52000),
            new clsCandidato(5, "Alessandro", "Conti", "Viale dei Colli 17", "Italia", new DateTime(1995, 12, 6), 48000),

            new clsCandidato(6, "Andrea", "De Luca", "Via Torino 9", "Usa", new DateTime(2000, 3, 22), 49000),
            new clsCandidato(7, "Marco", "Gallo", "Largo Napoli 3", "Usa", new DateTime(1961, 11, 10), 51000),
            new clsCandidato(8, "Federico", "Moretti", "Piazza Firenze 10", "Usa", new DateTime(1998, 12, 9), 47000),
            new clsCandidato(9, "Stefano", "Romano", "Via Bologna 16", "Usa", new DateTime(1968, 7, 24), 53000),
            new clsCandidato(10, "Simone", "Giordano", "Via Venezia 20", "Usa", new DateTime(1966, 01, 30), 50000)
        };
        private static List<clsMision> listadoMisiones = new List<clsMision>
        {
            new clsMision(1, "Recoger impuestos en el restaurante", 1),
            new clsMision(2, "Hacer una oferta que no pueda rechazar el sindicato de basura", 2),
            new clsMision(3, "Supervisar obras en New Jersey", 3),
            new clsMision(4, "Convencer al Concejal de urbanismo para conseguir favores", 4),
            new clsMision(5, "Encargarse del concejal de urbanismo que no se dejo convencer", 5),
            new clsMision(6, "Llevar la contabilidad del Bada Bing", 1)
        };

        /// <summary>
        /// Funcion estatica que devuelve un listado completo de onjetos de la clase clsMision
        /// </summary>
        /// <returns></returns>
        public static List<clsMision> listadoCompletoMisionesDAL()
        {
            return listadoMisiones;
        }

        /// <summary>
        /// Funcion estatica que devuelve una lista de objetos de la clase clsCandidato
        /// </summary>
        /// <returns></returns>
        public static List<clsCandidato> listadoCompletoCandidatosDAL()
        {
            return listadoCandidatos;
        }

        /// <summary>
        /// Funcion estatica que devuelve a un cadidato con un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorIdDAL(int id)
        {
            clsCandidato candidato = (clsCandidato) listadoCandidatos.Where(per => per.Id == id).FirstOrDefault();
            return candidato;
        }

        /// <summary>
        /// Funcion estatica que devuelve a una mision con un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsMision getMisionPorIdDAL(int id)
        {
            clsMision mision = (clsMision)listadoMisiones.Where(per => per.Id == id).FirstOrDefault();
            return mision;
        }
    }
}
