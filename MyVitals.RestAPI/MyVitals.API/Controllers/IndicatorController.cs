using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyVitals.API.Entities;

namespace MyVitals.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndicatorController
    {
        private readonly IConfiguration _configuration;

        public IndicatorController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<List<Indicator>> Get()
        {
            return await Task.FromResult(new List<Indicator>());
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<Indicator> GetById(int Id)
        {
            return await Task.FromResult(new Indicator());
        }

        [HttpPost]
        public async Task<int> Post([FromBody] Indicator indicator)
        {
            return 0;
        }

        [HttpPut]
        public async Task<bool> Put([FromBody] Indicator indicator)
        {
            return false;
        }

        [HttpPatch]
        public async Task<bool> Patch([FromBody] Indicator indicator)
        {
            return false;
        }

        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return false;
        }
    }
}
