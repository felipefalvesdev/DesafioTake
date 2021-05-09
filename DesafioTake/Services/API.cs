using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioTake.Services
{
    public class API
    {
        /// <summary>
        /// Este metodo é responsavel por conectar a api do github e traz todos os repositorios de determinada org.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Repository.Details>> URLConnection()
        {
            try
            {
                
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://api.github.com/");

                httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("DesafioTake", "1.0"));
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync("orgs/takenet/repos?per_page=100");

                string RepositoryJsonString = await response.Content.ReadAsStringAsync();

                List<Repository.Details> deserialized = JsonConvert.DeserializeObject<List<Repository.Details>>(RepositoryJsonString);

                List<Repository.Details> repositoriesByCreatedDateDesc = deserialized.OrderBy(x => x.CreatedAt).ToList();



                return repositoriesByCreatedDateDesc;

                //IEnumerable<Repository.Details> deserialized = JsonConvert.DeserializeObject<IEnumerable<Repository.Details>>(RepositoryJsonString);

            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
