using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyVitals.API.Business;
using MyVitals.API.Entities.Dto;
using MyVitals.API.ViewModels;

namespace MyVitals.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitsController
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitBusiness _business;
        private readonly IMapper _mapper;


        public UnitsController(IConfiguration configuration, IUnitBusiness business, IMapper mapper)
        {
            _configuration = configuration;
            _business = business;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UnitViewModel>> Get()
        {
            var result = await _business.GetAll();
            return _mapper.Map<List<UnitViewModel>>(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<UnitViewModel> GetById([FromRoute] int id)
        {
            var result = await _business.Get(id);
            return _mapper.Map<UnitViewModel>(result);
        }

        [HttpPost]
        public async Task<int> Post(UnitViewModel unit)
        {
            return await _business.Add(_mapper.Map<UnitDto>(unit));
        }
    }
}
