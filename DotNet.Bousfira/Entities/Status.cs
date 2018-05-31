using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("APP_STATUT")]
    public class Status
    {
        [Key]
        [Column("STA_ID")]
        public int Id { get; set; }

        [Column("STA_LIBELLE")]
        [Required]
        public string Name { get; set; }
    
        public Status()
	    {
        }
    }
}
