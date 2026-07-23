using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DES1_Control_Empleados.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        public string Code { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }
    }
}
