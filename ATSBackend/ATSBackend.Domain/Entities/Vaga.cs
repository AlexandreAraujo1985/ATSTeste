using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSBackend.Domain.Entities
{
    public class Vaga
    {
        public int IdVaga { get; set; }
        public string Descricao { get; set; }
        public string Profissao { get; set; }
        public bool Encerrada { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Local { get; set; }
    }
}
