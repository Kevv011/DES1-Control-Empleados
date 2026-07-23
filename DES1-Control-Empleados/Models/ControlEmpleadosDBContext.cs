using Microsoft.EntityFrameworkCore;

namespace DES1_Control_Empleados.Models
{
    public class ControlEmpleadosDBContext : DbContext
    {
        public ControlEmpleadosDBContext(DbContextOptions options) : base(options) { }

        // DbSet para entidades (Employee & Department)
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

}
