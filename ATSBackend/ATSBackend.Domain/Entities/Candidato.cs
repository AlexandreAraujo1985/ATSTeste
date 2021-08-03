using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSBackend.Domain.Entities
{
    public class Candidato
    {
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        //[DefaultValue(true)]
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdCurriculo { get; set; }
        [ForeignKey("IdCurriculo")]
        public virtual Curriculo Curriculo { get; set; }
        //[ForeignKey("IdVaga")]
        public int IdVaga { get; set; }
        //public virtual Vaga Vaga { get; set; }
    }
}
