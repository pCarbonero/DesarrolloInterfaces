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

        /// <summary>
        /// Metodo que se encarga de realizar una solicitud de delete a la api
        /// </summary>
        /// <param name="personaBorrar"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo que se encarga de realizar una solicitud post para añadir una persona a la base de datos
        /// </summary>
        /// <param name="personaAdd"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> addPersona(clsPersona personaAdd)
        {
            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = clsUriBase.getUriBase();

            string datos;

            HttpContent contenido;

            Uri miUri = new Uri($"{miCadenaUrl}/personaapi/");


            HttpClient mihttpClient;
            HttpResponseMessage miCodigoRespuesta = new HttpResponseMessage();

            string textoJsonRespuesta;

            //Instanciamos el cliente Http
            mihttpClient = new HttpClient();

            try
            {
                datos = JsonConvert.SerializeObject(personaAdd);
                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "application/json");
                miCodigoRespuesta = await mihttpClient.PostAsync(miUri, contenido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return miCodigoRespuesta.StatusCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<List<clsDepartamento>> getListaDepartamentos()
        {
            //Pido la cadena de la Uri al método estático
            string miCadenaUrl = clsUriBase.getUriBase();

            Uri miUri = new Uri($"{miCadenaUrl}/departamentoapi");

            List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>();


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
                    listadoDepartamentos = JsonConvert.DeserializeObject<List<clsDepartamento>>(textoJsonRespuesta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listadoDepartamentos;
        }
    }
}
