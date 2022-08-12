using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.API.Entities
{
    [Table("departments")]
    public class Department : Base
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }

        [Required]
        [Column("id_enterprise")]
        public int EnterpriseId { get; set; }

        [ForeignKey("EnterpriseId")]
        public Enterprise Enterprise { get; set; }

        public virtual ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }
    }
}
