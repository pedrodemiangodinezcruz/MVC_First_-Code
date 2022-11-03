using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PuntoVenta.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Required]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column("Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        [RegularExpression("^([a-zA-ZÑñáéíóúÁÉÍÓÚ]+\\s)*[a-zA-ZÑñáéíóúÁÉÍÓÚ]+$", ErrorMessage = "Use letters only please, and no double spaces")]
        public string Name { get; set; }
        [Required]
        [Column("LastName", TypeName = "nvarchar")]
        [MaxLength(50)]
        [RegularExpression("^([a-zA-ZÑñáéíóúÁÉÍÓÚ]+\\s)*[a-zA-ZÑñáéíóúÁÉÍÓÚ]+$", ErrorMessage = "Use letters only please, and no double spaces")]
        public string LastName { get; set; }
        [Required]
        [Column("Address", TypeName = "nvarchar")]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [Column("Phone", TypeName = "nvarchar")]
        [MaxLength(10)]
        //Regular expression for phone field
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Invalid Phone Number, lenght limit, 10")]
        public string Phone { get; set; }
        [Required]
        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(50)]
        [EmailAddress]
        //Regular expression for Email
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        [Column("Password", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Password { get; set; }
        
    }
}