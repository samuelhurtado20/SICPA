using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.Models.Entities
{
    [Table(name: "departments_employees")]
    public class DepartmentEmployee : Base
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("id_department")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [Required]
        [Column("id_employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("EnterpriseId")]
        public Employee Employee { get; set; }

    }
}
