using DAL.Utilities;
using Entidades;
using Newtonsoft.Json;
using System.Net;

namespace DAL
{
    public class Services
    {
        /// <summary>
        /// metodo que devuelve una lista de perlsonas
        /// </summary>
        /// <returns></returns>
        public static async Task<List<clsPersona>> getListaPersonas()
        {
            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = clsUriBase. getUriBase();

            Uri miUri = new Uri($"{miCadenaUrl}/personaapi");

            List<clsPersona> listadoPersonas = new List<clsPersona>();


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
                    listadoPersonas = JsonConvert.DeserializeObject<List<clsPersona>>(textoJsonRespuesta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listadoPersonas;
        }

        public static async Task<HttpStatusCode> deletePersona(clsPersona personaBorrar)
        {
            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = clsUriBase.getUriBase();

            string datos;

            HttpContent contenido;

            Uri miUri = new Uri($"{miCadenaUrl}/personaapi/{personaBorrar.Id}");


            HttpClient mihttpClient;
            HttpResponseMessage miCodigoRespuesta = new HttpResponseMessage();

            string textoJsonRespuesta;

            //Instanciamos el cliente Http
            mihttpClient = new HttpClient();

            try
            {
                datos = JsonConvert.SerializeObject(personaBorrar);
                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "application/json");
                miCodigoRespuesta = await mihttpClient.DeleteAsync(miUri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return miCodigoRespuesta.StatusCode;
        }
    }
}
