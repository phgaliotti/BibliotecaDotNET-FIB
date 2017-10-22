using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Models
{
    public class Emprestimo
    {
        [Key]
        public int EmprestimoID { get; set; }

        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

		[DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Digite uma data de inicio")]
        public string DataInicio { get; set; }

		[DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Digite uma data Final")]
        public string DataFim { get; set; }

		[DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string DataDevolucao { get; set; }

        public ICollection<LivroEmprestimo> LivroEmprestimo { get; set; }
    }
}
