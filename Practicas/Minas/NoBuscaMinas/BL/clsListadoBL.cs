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
            int numBombas = numBombasPorDificultad(dificultad);

            switch (dificultad)
            {
                case 1:
                    lista = rellenarCeldas(9, numBombas);
                    break;
                case 2:
                    lista = rellenarCeldas(16, numBombas);
                    break;
                case 3:
                    lista = rellenarCeldas(25, numBombas);
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

        /// <summary>
        /// Funcion estatica que devuelve el numero de intentos que tiene el juagdor para completar un nivel
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static int numIntentosPorDificultad(int dificultad)
        {
            int num = 0;

            switch(dificultad)
            {
                case 1:
                    num = 8; 
                    break;
                case 2:
                    num = 15;
                    break;
                case 3:
                    num = 20;
                    break;
            }
            return num;
        }

        /// <summary>
        /// Funcion estatica que devuelve el numero de bombas que hay en la partidas
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static int numBombasPorDificultad(int dificultad)
        {
            int num = 0;

            switch (dificultad)
            {
                case 1:
                    num = 3;
                    break;
                case 2:
                    num = 6;
                    break;
                case 3:
                    num = 12;
                    break;
            }
            return num;
        }

        /// <summary>
        /// Funcion estatica que devuelve el numero de cartas correctas que hay en la partida
        /// </summary>
        /// <param name="dificultad"></param>
        /// <returns></returns>
        public static int numCartasCorrectasPorDificultad(int dificultad)
        {
            int num = 0;

            switch (dificultad)
            {
                case 1:
                    num = 6;
                    break;
                case 2:
                    num = 10;
                    break;
                case 3:
                    num = 13;
                    break;
            }
            return num;
        }
    }
}
