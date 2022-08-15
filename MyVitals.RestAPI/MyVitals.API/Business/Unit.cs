using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MyVitals.API.DataContext.Repositories;
using MyVitals.API.Entities.Dto;

namespace MyVitals.API.Business
{
    public class Unit: IUnitBusiness
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitRepository _unitRepository;

        public Unit(IConfiguration configuration, IUnitRepository unitRepository)
        {
            _configuration = configuration;
            _unitRepository = unitRepository;
        }

        
        public async Task<List<UnitDto>> GetAll()
        {
            return await _unitRepository.GetAll();
        }

        public async Task<UnitDto> Get(int id)
        {
            return await _unitRepository.Get(id);
        }

        public async Task<int> Add(UnitDto unit)
        {
            return await _unitRepository.Add(unit);
        }

        public Task<UnitDto> Update(UnitDto unit)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }


}
