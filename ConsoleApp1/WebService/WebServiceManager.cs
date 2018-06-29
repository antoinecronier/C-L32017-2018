using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WebService
{
    public class WebServiceManager<T> where T : class
    {
        public String DataConnectionResource { get; set; }

        public WebServiceManager(String baseUrl)
        {
            DataConnectionResource = baseUrl;
        }

        public async Task<T> Get(Int32 id)
        {
            T item = default(T);
            String url = typeof(T).Name + "/" + id + "/";
            item = await HttpClientCaller<T>(url);
            return item;
        }

        public async Task<List<T>> Get()
        {
            List<T> item = default(List<T>);
            String url = typeof(T).Name + "/";
            item = await HttpClientCaller<List<T>>(url);
            return item;
        }

        public async Task<TItem> HttpClientCaller<TItem>(String url)
        {
            TItem item = (TItem)Activator.CreateInstance(typeof(TItem));
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataConnectionResource);
                client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                return await HandleResponse<TItem>(response);
            }
        }

        private async Task<TItem> HandleResponse<TItem>(HttpResponseMessage response)
        {
            TItem item = (TItem)Activator.CreateInstance(typeof(TItem));
            if (response.IsSuccessStatusCode)
            {
                String result = await response.Content.ReadAsStringAsync();
                item = JsonConvert.DeserializeObject<TItem>(result);
            }

            return item;
        }

        #region JObject
        public async Task<JObject> HttpClientCaller(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(DataConnectionResource);
                client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                return await HandleResponse<JObject>(response);
            }
        }
        #endregion
    }
}
