using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DES1_Control_Empleados.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        public string Code { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Range(typeof(DateOnly), "1/1/1900", "1/1/2050")] // Rango de fechas válido
        [Required]
        public DateOnly BirthDate { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [Range(typeof(DateTime), "1/1/2000", "1/1/2050")] // Rango de fechas válido
        [Required]
        public DateTime HireDate { get; set; }

        [Display(Name = "Salario")]
        [Range(0d, double.MaxValue, MinimumIsExclusive = true)] // Data annotation para asegurar que el salario sea mayor a cero
        [Required]
        public decimal Salary { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }
    }
}
