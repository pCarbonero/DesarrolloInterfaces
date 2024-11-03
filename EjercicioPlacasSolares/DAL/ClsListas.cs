using Entidades;

namespace DAL
{
    public class ClsListas
    {
        /// <summary>
        /// Funcion que devuelve un listado de objetos de la clase clientes
        /// </summary>
        /// <returns>Listado de la clase clientes</returns>
        public static List<ClsCliente> listadoClientes()
        {
            List<ClsCliente>lista = new List<ClsCliente>();

            lista.Add(new ClsCliente("Pablo Carbonero", "C/ Anibal Gonzalez", 667291647));
            lista.Add(new ClsCliente("Sara Ruiz", "C/ Anibal Gonzalez", 647694201));
            lista.Add(new ClsCliente("Sergio Salas", "C/ Sejota Morena", 612457832));

            return lista;
        }

        public static List<ClsCita> listaCitas()
        {
            List<ClsCliente> listClientes = listadoClientes();

            List<ClsCita> lista = new List<ClsCita>();

            lista.Add(new ClsCita(DateTime.Today, TimeOnly.MinValue, 
                false, "", listClientes[0]));
            lista.Add(new ClsCita(DateTime.Today, TimeOnly.MinValue,
                false, "", listClientes[1]));
            lista.Add(new ClsCita(DateTime.Today, TimeOnly.MinValue,
                false, "", listClientes[2]));

            return lista;
        }
    }
}
