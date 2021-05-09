using DesafioTake.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioTake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {
        [HttpGet]
        public  async Task<string> GetRepositoryByLanguageAndCreatedDate(string language, int NumberOfResults)
        {
            List<Repository.Details> result = await API.URLConnection();
            List<Repository.Details> RepositoriesByLanguage = new List<Repository.Details>();
            int count = 0;
            
            foreach(Repository.Details obj in result)
            {
                if(obj.Language == language)
                {
                    RepositoriesByLanguage.Add(obj);
                    count += 1;
                    if (count == NumberOfResults) break;
                }
            }
            var serialized = JsonConvert.SerializeObject(RepositoriesByLanguage);
            return serialized;
        }         

    }
}
