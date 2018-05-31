using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("APP_CATEGORIE")]
    public class Category
    {
        [Key]
        [Column("CAT_ID")]
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        [Column("CAT_LIBELLE")]
        public string Name { get; set; }

        [Column("CAT_ACTIF")]
        public bool isActive { get; set; }

        public Category()
        {

        }
    }
}