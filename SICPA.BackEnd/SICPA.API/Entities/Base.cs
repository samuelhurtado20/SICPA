using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.API.Entities
{
    public abstract class Base
    {
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
        public bool Status { get; set; }
    }
}
