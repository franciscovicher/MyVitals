using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyVitals.API.Entities.Dto;

namespace MyVitals.API.DataContext.Repositories
{
    public class UnitRepository: IRepository<UnitDto, int>, IUnitRepository
    {
        private readonly IConfiguration _configuration;
        private readonly MyVitalsContext _db;

        public UnitRepository(IConfiguration configuration, MyVitalsContext db)
        {
            _configuration = configuration;
            _db = db;
        }

        public async Task<List<UnitDto>> GetAll()
        {
            return  await  Task.FromResult(_db.Set<UnitDto>().ToList());
        }

        public async Task<UnitDto> Get(int id)
        {
            var result = await _db.Set<UnitDto>().FindAsync(id);
            if (result == null)
                throw new Exception("Unit not found");
            return result;
        }

        public async Task<int> Add(UnitDto entity)
        {
            await _db.Set<UnitDto>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> Update(UnitDto entity)
        {
            _db.Entry<UnitDto>(entity).State = EntityState.Modified;
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> Delete(int id)
        {
            _db.Set<UnitDto>().Remove(await _db.Set<UnitDto>().FindAsync(id));
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
