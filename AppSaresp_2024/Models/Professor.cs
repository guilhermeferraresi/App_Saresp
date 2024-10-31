﻿using System.ComponentModel.DataAnnotations;

namespace AppSaresp_2024.Models
{
    public class Professor
    {
        [Display(Name = "Código")]
        public int? idProfessor { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string telefone { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public decimal cpf { get; set; }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "O campo RG é obrigatório")]
        public decimal rg { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "O campo nascimento é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime data_nascimento { get; set; }
    }
}
