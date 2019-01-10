using System;
using System.ComponentModel.DataAnnotations;

namespace Meu.Projeto.Teste.MVC.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [MaxLength(50)]
        [MinLength(10, ErrorMessage ="Valor inválido")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data Nascimento", ShortName ="Data Nasc.")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(11)]
        [MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
    }
}