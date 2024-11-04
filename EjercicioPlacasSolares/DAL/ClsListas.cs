using Entidades;

namespace DAL
{
    public class ClsListas
    {
        /// <summary>
        /// Funcion que devuelve un listado de objetos de la clase citas
        /// </summary>
        /// <returns>Listado de la clase clientes</returns>
        public static List<ClsCita> listaCitas()
        {

            List<ClsCita> lista = new List<ClsCita>();

            lista.Add(new ClsCita(DateTime.Today, new TimeOnly(9,30), 
                false, "", "Pablo Carbonero", "C/ A"));
            lista.Add(new ClsCita(DateTime.Today, new TimeOnly(11, 30),
                false, "", "Sara Ruiz", "C/ B"));
            lista.Add(new ClsCita(DateTime.Today, new TimeOnly(13, 30),
                false, "", "Zlatan Ibrahimovic", "C/ D"));

            return lista;
        }
    }
}
