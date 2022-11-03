using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace PuntoVenta.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Required]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column("Date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("Total", TypeName = "money")]
        public int Total { get; set; }
        [ForeignKey("Product")]
        [Required]
        [Column("IdProduct", TypeName = "int")]
        public int IdProduct { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Client")]
        [Required]
        [Column("IdClient", TypeName = "int")]
        public int IdClient { get; set; }
        public virtual Client Client { get; set; }
    }
}