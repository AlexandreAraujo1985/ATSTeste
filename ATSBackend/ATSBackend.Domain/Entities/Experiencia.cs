using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSBackend.Domain.Entities
{
    public class Experiencia
    {
        public int IdExperiencia { get; set; }
        public string NomeEmpresa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        //[ForeignKey("IdCurriculo")]
        //public virtual Curriculo Curriculo { get; set; } = null;
    }
}
