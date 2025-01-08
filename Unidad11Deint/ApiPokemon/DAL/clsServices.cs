using DAL.Utilities;
using ENT;
using Newtonsoft.Json;

namespace DAL
{
    public class clsServices
    {
        /// <summary>
        /// metodo que devuelve una lista de pokemon
        /// </summary>
        /// <returns></returns>
        public static async Task<List<clsPokemon>> getListaPokemon(int limit = 0, int offset = 0)
        {
            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = clsUriBase.getUriBase();

            Uri miUri = new Uri($"{miCadenaUrl}/Pokemon");

            List<clsPokemon> listadoPokemon = new List<clsPokemon>();


            HttpClient mihttpClient;
            HttpResponseMessage miCodigoRespuesta;

            string textoJsonRespuesta;

            //Instanciamos el cliente Http
            mihttpClient = new HttpClient();

            try
            {
                miCodigoRespuesta = await mihttpClient.GetAsync(miUri);

                if (miCodigoRespuesta.IsSuccessStatusCode)
                {
                    textoJsonRespuesta = await mihttpClient.GetStringAsync(miUri);

                    mihttpClient.Dispose();

                    //JsonConvert necesita using Newtonsoft.Json;

                    //Es el paquete Nuget de Newtonsoft
                    listadoPokemon = JsonConvert.DeserializeObject<List<clsPokemon>>(textoJsonRespuesta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listadoPokemon;
        }
    }
}
