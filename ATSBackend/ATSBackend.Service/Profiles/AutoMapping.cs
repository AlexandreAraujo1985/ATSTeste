using AutoMapper;
using ATSBackend.Service.Models;
using ATSBackend.Domain.Entities;

namespace ATSBackend.Service.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Candidato, CandidatoModel>();
            CreateMap<CandidatoModel, Candidato>();
            CreateMap<VagaModel, Vaga>();
            CreateMap<CurriculoModel, Curriculo>();
            CreateMap<ExperienciaModel, Experiencia>();    
        }
    }
}
