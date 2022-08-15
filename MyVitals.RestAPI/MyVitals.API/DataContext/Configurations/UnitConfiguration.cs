using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MyVitals.API.Entities.Dto;

namespace MyVitals.API.DataContext.Configurations
{
    public class UnitConfiguration: IEntityTypeConfiguration<UnitDto>
    {
        public void Configure(EntityTypeBuilder<UnitDto> builder)
        {
            builder.ToTable("Units");
            builder.HasKey(x => x.Id)
                .IsClustered();
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            builder.Property<string>(x => x.Name)
                .HasMaxLength(64)
                .IsRequired();
            builder.Property<string>(p => p.Symbol)
                .HasMaxLength(16)
                .IsRequired();
            builder.Property<bool>(p=>p.IsActive)
                .HasDefaultValue(true);
            builder.Property<DateTime>(p => p.Created)
                .ValueGeneratedOnAdd()
                .HasDefaultValue(DateTime.Now);
            builder.Property<DateTime?>(p => p.Updated)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValue(DateTime.Now);
        }
    }
}
