using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sirlean.Estudo.WebMVC.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}