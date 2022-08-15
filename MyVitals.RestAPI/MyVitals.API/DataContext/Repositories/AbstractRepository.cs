using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyVitals.API.DataContext.Repositories
{
    public class AbstractRepository<T,T2> : IRepository<T,T2> where T : class
    {
        private readonly IConfiguration _configuration;
        private readonly MyVitalsContext _db;

        protected AbstractRepository(IConfiguration configuration, MyVitalsContext db)
        {
            _configuration = configuration;
            _db = db;
        }
        public Task<List<T>> GetAll()
        {
            return Task.FromResult(_db.Set<T>().ToList());
        }

        public async Task<T> Get(T2 id)
        {
            if(id == null)
                throw new ArgumentNullException("id");
            return await _db.Set<T>().FindAsync<T>(id);
        }

        public async Task<int> Add(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.Set<T>().Update(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<bool> Delete(T2 id)
        {
            if(id == null)
                return false;
            var entity = await _db.FindAsync(id);
            _db.Set<T>().Remove(entity);
            return (await _db.SaveChangesAsync()) > 0;
        }
    }
}
