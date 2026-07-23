using DES1_Control_Empleados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DES1_Control_Empleados.Models.Seeds
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department { Id = 1, Code = "DEP-RH", Name = "Recursos Humanos", Description = "Gestión de talento humano" },
                new Department { Id = 2, Code = "DEP-TI", Name = "Tecnología", Description = "Sistemas y desarrollo" },
                new Department { Id = 3, Code = "DEP-VEN", Name = "Ventas", Description = "Ventas y marketing" }
            );
        }
    }
}
