using System;
using System.Collections.Generic;

namespace ATSBackend.Service.Models
{
    public class VagaModel
    {
        public int IdVaga { get; set; }
        public string Descricao { get; set; }
        public string Profissao { get; set; }
        public bool Encerrada { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Local { get; set; }
        public int IdCandidato { get; set; }
        public virtual IEnumerable<CandidatoModel> Candidatos { get; set; }
    }
}
