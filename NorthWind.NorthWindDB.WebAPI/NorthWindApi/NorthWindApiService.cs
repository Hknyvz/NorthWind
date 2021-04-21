using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.NorthWindApi
{
    public class NorthWindApiService
    {
        private readonly HttpClient httpClient;
        public NorthWindApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<T> GetEntityAsync<T>(int id) where T : class, INorthWindEntity, new()
        {
            T entity = new T();

            var response = await httpClient.GetAsync($"{entity}/{id}");

            if (response.IsSuccessStatusCode)
            {
                entity = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                entity = null;
            }

            return entity;
        }

        public async Task<IEnumerable<T>> GetEntitiesAsync<T>(int id) where T : class, INorthWindEntity, new()
        {
            T entity=new T();
            IEnumerable<T> entities;
            var response = await httpClient.GetAsync($"{entity}");

            if (response.IsSuccessStatusCode)
            {
                entities = JsonConvert.DeserializeObject<IEnumerable<T>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                entities = null;
            }
            return entities;
        }

        public async Task<int> AddEntityAsync<T>(T entity) where T : class, INorthWindEntity, new()
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8,"application/json");
            var response = await httpClient.PostAsync($"{entity}",stringContent);
            return Convert.ToInt32(response.StatusCode);
        }

        public async Task<int> UpdateEntityAsync<T>(T entity) where T : class, INorthWindEntity, new()
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync($"{entity}", stringContent);
            return Convert.ToInt32(response.StatusCode);
        }

        public async Task<int> DeleteEntityAsync<T>(string id) where T : class, INorthWindEntity, new()
        {
            T entity = new T();
            var response = await httpClient.DeleteAsync($"{entity}/{id}");
            return Convert.ToInt32(response.StatusCode);
        }
    }
}
