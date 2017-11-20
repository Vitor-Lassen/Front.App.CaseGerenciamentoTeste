using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Windows.Forms;

namespace Front.App.CaseGerenciamentoTeste.Utilities
{
    class InteractionAPI
    {
        HttpClient httpClient = new HttpClient();

        public string Post(string route, object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = httpClient.PostAsync("http://localhost:50949/" + route, content).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK) 
                return response.Content.ReadAsStringAsync().Result;
            else
            {
               
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }

        public string Get(string route)
        {
            //string json = JsonConvert.SerializeObject(obj);
            //StringContent content = new StringContent(json);
           // content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = httpClient.GetAsync("http://localhost:50949/" + route ).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response.Content.ReadAsStringAsync().Result;
            else
            {
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }

    }
}

