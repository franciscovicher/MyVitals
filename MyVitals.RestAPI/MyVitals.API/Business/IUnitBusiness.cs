using System.Collections.Generic;
using System.Threading.Tasks;
using MyVitals.API.Entities.Dto;

namespace MyVitals.API.Business
{
    public interface IUnitBusiness
    {
        Task<List<UnitDto>> GetAll();
        Task<UnitDto> Get(int id);
        Task<int> Add(UnitDto unit);
        Task<UnitDto> Update(UnitDto unit);
        Task<bool> Delete(int id);
    }
}