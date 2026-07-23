using DES1_Control_Empleados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DES1_Control_Empleados.Models.Seeds
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Code = "EMP-001",
                    Name = "John Doe",
                    BirthDate = new DateOnly(1985, 5, 20),
                    HireDate = new DateTime(2010, 8, 15),
                    Salary = 50000m
                    // DepartmentId = 1 
                },
                new Employee
                {
                    Id = 2,
                    Code = "EMP-002",
                    Name = "Jane Smith",
                    BirthDate = new DateOnly(1990, 3, 10),
                    HireDate = new DateTime(2015, 1, 25),
                    Salary = 70000m
                    // DepartmentId = 2  <-- TI
                },
                new Employee
                {
                    Id = 3,
                    Code = "EMP-003",
                    Name = "Mark Johnson",
                    BirthDate = new DateOnly(1982, 11, 22),
                    HireDate = new DateTime(2012, 6, 18),
                    Salary = 55000m
                    // DepartmentId = 3  <-- Ventas
                },
                new Employee
                {
                    Id = 4,
                    Code = "EMP-004",
                    Name = "Emily Davis",
                    BirthDate = new DateOnly(1978, 7, 30),
                    HireDate = new DateTime(2005, 10, 12),
                    Salary = 75000m
                    // DepartmentId = 1  <-- RH
                },
                new Employee
                {
                    Id = 5,
                    Code = "EMP-005",
                    Name = "Michael Brown",
                    BirthDate = new DateOnly(1995, 12, 5),
                    HireDate = new DateTime(2020, 4, 15),
                    Salary = 60000m
                    // DepartmentId = 2 <-- TI
                }
            );
        }
    }
}
