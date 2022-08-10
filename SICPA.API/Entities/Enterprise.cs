using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.API.Entities
{
    [Table("enterprises")]
    public class Enterprise : Base
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }
    }
}
