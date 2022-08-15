using Microsoft.EntityFrameworkCore;
using MyVitals.API.Entities.Dto;

using System.Reflection;

namespace MyVitals.API.DataContext
{
    public class MyVitalsContext:DbContext
    {
        DbSet<UnitDto> Units { get; set; }

        public MyVitalsContext(DbContextOptions<MyVitalsContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
