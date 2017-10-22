using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Digite um nome")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite um email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Digite uma senha")]
        public string Senha { get; set; }

        public virtual ICollection<Emprestimo> Emprestimo { get; set; }
    }
}
