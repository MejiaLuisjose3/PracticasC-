using Newtonsoft.Json;
using PatronesDeDiseno.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Practicas_Importantes
{
    public class MetodosImportantesII
    {
        public static Model GetOperation()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;

            var url = "URL";

            var dicti = new Content() { accessCode = "" };

            response = client.PostAsJsonAsync(url, dicti).Result;
            //NOTA: para poder consumir el metodo de extencion PostAsJsonAsync Necesita agregar la DLL Microsoft.AspNet.WebApi.Client

            var responseBody = response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Model>(responseBody.Result);
        }

    }
}
