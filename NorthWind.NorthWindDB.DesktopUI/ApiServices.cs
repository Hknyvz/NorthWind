using Newtonsoft.Json;
using NorthWind.NorthWindDB.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.DesktopUI
{
    public class ApiServices
    {
        HttpClient httpClient;
        string endPoint;
        public ApiServices(string endPoint)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress= new Uri("http://localhost:61643/api/");
            this.endPoint = endPoint;
        }
        public async Task<T> GetEntityAsync<T>(int id) where T : class,IEntity
        {
            T entity=null;
            var response = await httpClient.GetAsync($"{endPoint}/{id}");

            if (response.IsSuccessStatusCode)
            {
                entity = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            return entity;
        }

        public async Task<IEnumerable<T>> GetEntitiesAsync<T>() where T : class,IEntity
        {
            IEnumerable<T> entities=null;
            var response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                entities = JsonConvert.DeserializeObject<IEnumerable<T>>(await response.Content.ReadAsStringAsync());
            }
            return entities;
        }

        public async Task<int> AddEntityAsync<T>(T entity) where T : IEntity
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(endPoint, stringContent);
            return Convert.ToInt32(response.StatusCode);
        }

        public async Task<int> UpdateEntityAsync<T>(T entity) where T :IEntity
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(endPoint, stringContent);
            return Convert.ToInt32(response.StatusCode);
        }

        public async Task<int> DeleteEntityAsync<T>(string id) where T : IEntity
        {
            var response = await httpClient.DeleteAsync($"{endPoint}/{id}");
            return Convert.ToInt32(response.StatusCode);
        }
    }
}
