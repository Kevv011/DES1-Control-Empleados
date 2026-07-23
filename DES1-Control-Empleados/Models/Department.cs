using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DES1_Control_Empleados.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Code { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
