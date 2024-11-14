using Entidades;

namespace DAL
{
    public class clsListados
    {
        /// <summary>
        /// Funcion que devuelve una lista de persoans
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<clsPersona> listadoPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>();

            lista.Add(new clsPersona("Pablo", "Carbonero Almellones", DateTime.Parse("02/01/2003"),
                "https://thispersondoesnotexist.com", "Calle De Los Guapos", 667256498));
            lista.Add(new clsPersona("Lucía", "Martínez Serrano", DateTime.Parse("14/05/1998"),
                "https://thispersondoesnotexist.com", "Avenida de la Paz", 612345678));
            lista.Add(new clsPersona("Carlos", "López Pérez", DateTime.Parse("30/08/1995"),
                "https://thispersondoesnotexist.com", "Calle Mayor", 678912345));
            lista.Add(new clsPersona("María", "García Sánchez", DateTime.Parse("12/12/2000"),
                "https://thispersondoesnotexist.com", "Plaza del Sol", 654321987));
            lista.Add(new clsPersona("Jorge", "Sanz Martín", DateTime.Parse("23/03/1987"),
                "https://thispersondoesnotexist.com", "Calle del Olmo", 612345123));
            lista.Add(new clsPersona("Ana", "Gómez Fernández", DateTime.Parse("07/09/1992"),
                "https://thispersondoesnotexist.com", "Avenida de los Álamos", 634567890));
            lista.Add(new clsPersona("Raúl", "Moreno Jiménez", DateTime.Parse("01/02/1999"),
                "https://thispersondoesnotexist.com", "Calle de la Luna", 687654321));
            lista.Add(new clsPersona("Elena", "Torres Rubio", DateTime.Parse("19/06/2001"),
                "https://thispersondoesnotexist.com", "Calle de los Jazmines", 699876543));
            lista.Add(new clsPersona("Sergio", "Navarro Ruiz", DateTime.Parse("27/11/1990"),
                "https://thispersondoesnotexist.com", "Paseo de la Victoria", 698765432));
            lista.Add(new clsPersona("Laura", "Pérez López", DateTime.Parse("15/07/1997"),
                "https://thispersondoesnotexist.com", "Camino de los Pinos", 687654098));

            return lista;
        }

        public static List<clsPersona> listadoFiltrado(String busqueda)
        {
            List<clsPersona> lista = clsListados.listadoPersonas();
            List<clsPersona> listaFiltrada = new List<clsPersona>();

            foreach (clsPersona persona in lista){
                if (persona.Nombre.Contains(busqueda))
                {
                    listaFiltrada.Add(persona);
                }
            }
            return listaFiltrada;
        }
    }
}
