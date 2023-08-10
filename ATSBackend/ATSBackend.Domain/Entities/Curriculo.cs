using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSBackend.Domain.Entities
{
    //Modificador de acesso
    public class Curriculo
    {
        public int IdCurriculo { get; set; }
        public string FormacaoAcademica { get; set; }
        [ForeignKey("IdCurriculo")]
        public virtual IEnumerable<Experiencia> Experiencias { get; set; }
    }
}
