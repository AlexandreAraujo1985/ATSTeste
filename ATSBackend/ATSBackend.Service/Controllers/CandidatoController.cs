using AutoMapper;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ATSBackend.Service.Models;
using ATSBackend.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using ATSBackend.Application.Interfaces;

namespace ATSBackend.Service.Controllers
{
    [Route("api/[controller]")]
    public class CandidatoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICandidatoApplication _candidatoApplication;
        public CandidatoController(ICandidatoApplication candidatoApplication, IMapper mapper)
        {
            _mapper = mapper;
            _candidatoApplication = candidatoApplication;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ListarCandidatos()
        {
            var candidatos = _candidatoApplication.ListarCandadatosAtivos();

            return Ok(candidatos);
        }

        [HttpGet("{idCandidato}")]
        [AllowAnonymous]
        public IActionResult ObterCandidato(int idCandidato)
        {
            var candidato = _candidatoApplication.ObterCantidado(idCandidato);

            return Ok(candidato);
        }

        [HttpGet("candidatos/{idVaga}")]
        [AllowAnonymous]
        public IActionResult ListarCandadatosPorVaga(int idVaga)
        {
            var candidatosPorVaga = _candidatoApplication.ListarCandadatosPorVaga(idVaga);

            return Ok(candidatosPorVaga);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult IncluirCandidato([FromBody] CandidatoModel candidatoModel)
        {
            var candidatos = _candidatoApplication.Listar().ToList();

            if (candidatos.FirstOrDefault(x => x.Nome == candidatoModel?.Nome) != null || candidatoModel == null)
                return BadRequest();

            var candidatoCadastro = _mapper.Map<Candidato>(candidatoModel);
            _candidatoApplication.Incluir(candidatoCadastro);

            return Ok();
        }

        [HttpPatch("{idCandidato}")]
        [AllowAnonymous]
        public IActionResult AlterarCandidato([FromBody] CandidatoModel candidatoModel, int idCandidato)
        {
            if (candidatoModel == null || string.IsNullOrEmpty(candidatoModel?.Nome))
                return BadRequest("Favor preencher todos os campos com *");

            var candidatoAlterar = _mapper.Map<Candidato>(candidatoModel);
            candidatoAlterar.IdCandidato = idCandidato;
            candidatoAlterar.IdCurriculo = candidatoModel.Curriculo.IdCurriculo;

            _candidatoApplication.AlterarCandidato(candidatoAlterar);
            return Ok();
        }

        [HttpDelete("{idCandidato}")]
        [AllowAnonymous]
        public IActionResult ExcluirCandidato(int idCandidato)
        {
            _candidatoApplication.ExcluirCandidato(idCandidato);

            return Ok();
        }

        [HttpDelete("experiencia/{idExperiencia}")]
        [AllowAnonymous]
        public IActionResult ExcluirExperienciaCandidato(int idExperiencia)
        {
            _candidatoApplication.ExcluirExperienciaCandidato(idExperiencia);

            return Ok();
        }
    }
}
