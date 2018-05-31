using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("APP_PRODUIT")]
    public class Product
    {
        [Key]
        [Column("PRD_ID")]
        public int ID { get; set; }

        [Column("PRD_CODE")]
        [Required]
        public string Code { get; set; }

        [Column("PRD_LIBELLE")]
        public string Name { get; set; }

        [Column("PRD_DESCRIPTION")]
        public string Desc { get; set; }

        [Column("PRD_ACTIF")]
        public bool isActive { get; set; }

        [Column("PRD_STOCK")]
        public int Stock { get; set; }

        [Column("PRD_PRIX")]
        public float Price { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public Product()
        {
            Code = "1234";
            Name = "Test";
        }
    }
}