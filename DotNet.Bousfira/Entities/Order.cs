using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("APP_COMMANDE")]
    public class Order
    {
        [Key]
        [Column("CMD_ID")]
        public int Id { get; set; }


        [Column("CMD_DATECOMMANDE")]
        [Required]
        public DateTime Date { get; set; }

        [StringLength(50)]
        [Column("CMD_OBSERVATION")]
        public string Note { get; set; }


        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }



        public Order()
        {
        }
    }
}