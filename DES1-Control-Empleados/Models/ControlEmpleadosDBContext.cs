using Microsoft.EntityFrameworkCore;
using DES1_Control_Empleados.Models.Seeds;

namespace DES1_Control_Empleados.Models
{
    public class ControlEmpleadosDBContext : DbContext
    {
        public ControlEmpleadosDBContext(DbContextOptions options) : base(options) { }

        // DbSet para entidades (Employee & Department)
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Agregar precisión al campo decimal que causaba el Warning anteriormente
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2);

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }

}
