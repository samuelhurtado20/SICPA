using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICPA.Models.Entities
{
    [Table("employees")]
    public class Employee : Base
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("position")]
        public string Position { get; set; }

        [ForeignKey("surname")]
        public string Surname { get; set; }
    }
}
