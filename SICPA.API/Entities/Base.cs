using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.API.Entities
{
    public abstract class Base
    {
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; }
        public bool Status { get; set; }
    }
}
