using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.Models.Entities
{
    public class Department : Base
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }

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
    }
}
