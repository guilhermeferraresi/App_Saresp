using System.ComponentModel.DataAnnotations;

namespace AppSaresp_2024.Models
{
    public class Aluno
    {
        [Display(Name = "Código")]
        public int? idProfessor { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string telefone { get; set; }


    }
}
