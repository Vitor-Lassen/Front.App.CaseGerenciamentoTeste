using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace Front.App.CaseGerenciamentoTeste.Utilities
{
    class InteractionAPI
    {
        HttpClient httpClient = new HttpClient();

        public HttpResponseMessage Post(string route, object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpClient.PostAsync("http://localhost:50949/" + route, content).Result;
        }
    }
}

