using System;

namespace ATSBackend.Service.Models
{
    public class ExperienciaModel
    {
        public int IdExperiencia { get; set; }
        public string NomeEmpresa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
