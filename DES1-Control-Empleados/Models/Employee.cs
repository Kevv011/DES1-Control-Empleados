using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DES1_Control_Empleados.Models
{
    public class Employee : IValidatableObject
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        public string Code { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        public DateOnly BirthDate { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [Required]
        public DateTime HireDate { get; set; }

        [Display(Name = "Salario")]
        [Range(0d, double.MaxValue, MinimumIsExclusive = true)] // Data annotation para asegurar que el salario sea mayor a cero
        [Required]
        public decimal Salary { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BirthDate < new DateOnly(1900, 1, 1) || BirthDate > new DateOnly(2050, 1, 1))
            {
                yield return new ValidationResult("La fecha de nacimiento debe estar entre el año 1900 y el 2050.", new[] { nameof(BirthDate) });
            }

            if (HireDate < new DateTime(2000, 1, 1) || HireDate > new DateTime(2050, 1, 1))
            {
                yield return new ValidationResult("La fecha de contratación debe estar entre el año 2000 y el 2050.", new[] { nameof(HireDate) });
            }
        }
    }
}
