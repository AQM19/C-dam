using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GuardiApp
{
    public class WebConsumer
    {
        /// <summary>
        /// Cache
        /// </summary>
        #region
        private HttpClient client;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        #region
        public WebConsumer()
        {
            client = new HttpClient();
        }
        #endregion

        /// <summary>
        /// Manejo de objetos genéricos consumiendo la API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        #region
        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(content);
                return result;
            }
            else
            {
                throw new ApplicationException($"Error al obtener el recurso: {response.StatusCode}");
            }
        }
        public async Task<T> PostAsync<T>(string url, string usuario, string password)
        {
            object data = new { user = usuario, password = password };
            string json = JsonConvert.SerializeObject(data);
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                string responseJson = await response.Content.ReadAsStringAsync();
                T responseObject = JsonConvert.DeserializeObject<T>(responseJson);
                return responseObject;
            }
            else
            {
                return default;
            }
        }
        public async Task<T> CreateAsync<T>(string url, T data)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsJsonAsync(url, data);
            response.EnsureSuccessStatusCode();

            return default;
        }
        public async Task<T> UpdateAsync<T>(string url, T data)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsJsonAsync(url, data);
            response.EnsureSuccessStatusCode();
            T genericObject = await response.Content.ReadAsAsync<T>();
            return genericObject;
        }
        public async Task<T> DeleteAsync<T>(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync(url);
            return default;
        }
        #endregion

    }
}
