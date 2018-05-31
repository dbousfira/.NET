using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities
{
    [Table("APP_CLIENT")]
    public class Customer
    {
        [Key]
        [Column("CLI_ID")]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Column("CLI_NOM")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        [Column("CLI_PRENOM")]
        public string FirstName { get; set; }

        [Column("CLI_ACTIF")]
        public bool isActive { get; set; }


        public Customer(string LastName)
        {
            this.LastName = LastName;
        }


    }
}