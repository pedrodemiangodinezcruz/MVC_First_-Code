using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace PuntoVenta.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column("Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [RegularExpression("^([a-zA-ZÑñáéíóúÁÉÍÓÚ]+\\s)*[a-zA-ZÑñáéíóúÁÉÍÓÚ]+$", ErrorMessage = "Use letters only please, and no double spaces")]
        public string Name { get; set; }
        [Required]
        [Column("Description", TypeName = "nvarchar")]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Column("UnitPrice", TypeName = "money")]
        [RegularExpression("^(0*[1-9][0-9]*(\\.[0-9]*)?|0*\\.[0-9]*[1-9][0-9]*)$", ErrorMessage = "Use only positive numbers")]
        public int UnitPrice { get; set; }
        [Required]
        [Column("Quantity", TypeName = "int")]
        [RegularExpression("^(0*[1-9][0-9]*(\\.[0-9]*)?|0*\\.[0-9]*[1-9][0-9]*)$", ErrorMessage = "Use only positive numbers")]
        public int Quantity { get; set; }
    }
}