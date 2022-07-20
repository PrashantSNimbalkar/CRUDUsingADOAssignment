using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsingADO2.Models
{
    //BO-business obejct/
    //poco class-
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "salary is required")]
        [Display(Name = "salary Price")]
        [Range(minimum: 1, maximum: 100000)]
        public double Salary { get; set; }

    }
}
