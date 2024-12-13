using Modelos;

namespace BL
{
    public class clsListadoBL
    {
        /// <summary>
        /// Funcion estatica que devuelve la lista de celdas segun su dificultad
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static List<clsCelda> listadoDeCeldas (int dificultad)
        {
            List<clsCelda> lista = new List<clsCelda>();

            switch (dificultad)
            {
                case 1:
                    lista = rellenarCeldas(9, 3);
                    break;
                case 2:
                    lista = rellenarCeldas(9, 3);
                    break;
                case 3:
                    lista = rellenarCeldas(9, 3);
                    break;
            }

            return lista;
        }

        /// <summary>
        /// Funcion estatica que se encarga de rellenar la lista de celdas con sus bombas
        /// </summary>
        /// <param name="numCeldas"></param>
        /// <param name="numBombas"></param>
        /// <returns></returns>
        private static List<clsCelda> rellenarCeldas (int numCeldas, int numBombas)
        {
            Random rand = new Random();
            List<clsCelda> lista = new List<clsCelda>();
            List<int> listaBombas = new List<int>();

            for (int i = 0; i < numCeldas; i++)
            {
                lista.Add(new clsCelda());
            }

            while (listaBombas.Count < numBombas)
            {
                int celdaCambiar = rand.Next(0, numCeldas-1);

                if (!listaBombas.Contains(celdaCambiar))
                {
                    lista[celdaCambiar].EsBomba = true;
                    listaBombas.Add(celdaCambiar);
                }
            }


            return lista;
        }
    }
}
