﻿using System.ComponentModel.DataAnnotations;

namespace KaemeWebApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Endereco { get; set; }
        public string? Signo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
