using Ejercicio05ENT;

namespace Ejercicio05DAL
{
    public class ClsListaPersonas
    {
        
        /// <summary>
        /// Funcion que devuelve una lista con 10 objetos de tipo perposna 
        /// </summary>
        /// <returns>Listado de personas</returns>
        public List<ClsPersona> listaPersonas()
        {
            List<ClsPersona> lista = new List<ClsPersona>();

            ClsPersona p1 = new ClsPersona("Pablo", "Carbonero Almellones", 21);
            ClsPersona p2 = new ClsPersona("Lorenzo Jesús", "Bellido Ballena", 19);
            ClsPersona p3 = new ClsPersona("Javier", "Carbonero Almellones", 24);
            ClsPersona p4 = new ClsPersona("Sara", "Ruíz Rico", 23);
            ClsPersona p5 = new ClsPersona("Marcos", "Holguín Cascajado", 19);
            ClsPersona p6 = new ClsPersona("Hector", "Arias Campana", 12);
            ClsPersona p7 = new ClsPersona("Raúl", "Romera Romerap", 20);
            ClsPersona p8= new ClsPersona("Jordi", "Arias Catalan", 54);
            ClsPersona p9 = new ClsPersona("Elena", "Lorenzo Rico", 19);
            ClsPersona p10 = new ClsPersona("Raquel", "Madrigal Ramos", 19);


            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(p9);
            lista.Add(p10);

            return lista;
        }
    }
}
