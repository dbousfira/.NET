using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{ 
    [Table("APP_LOGPRODUIT")]
    public class LogProduct
    {
        [Key]
        [Column("LOG_ID")]
        public int Id { get; set; }

        [Column("LOG_MESSAGE")]
        [Required]
        public string Message { get; set; }
    
        [Column("LOG_DATE")]
        public DateTime Date { get; set; }


        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public LogProduct()
	    {
        
        }
    }
}