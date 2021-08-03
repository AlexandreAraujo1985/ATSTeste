using System;

namespace ATSBackend.Service.Models
{
    public class CandidatoModel
    {
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdVaga { get; set; }
        public virtual CurriculoModel Curriculo { get; set; }
    }
}
