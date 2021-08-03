using System.Collections.Generic;

namespace ATSBackend.Service.Models
{
    public class CurriculoModel
    {
        public int IdCurriculo { get; set; }
        public int IdCandidato { get; set; }
        public int IdExperiencia { get; set; }
        public string FormacaoAcademica { get; set; }
        //public virtual CandidatoModel Candidato { get; set; }
        public virtual IEnumerable<ExperienciaModel> Experiencias { get; set; }
    }
}
