using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ATSBackend.Service.Models;
using Microsoft.AspNetCore.Authorization;
using ATSBackend.Application.Interfaces;
using ATSBackend.Domain.Entities;

namespace ATSBackend.Service.Controllers
{
    [Route("api/[controller]")]
    public class VagaController : Controller
    {
        private readonly IVagaApplication _vagaApplication;
        private readonly IMapper _mapper;

        public VagaController(IVagaApplication vagaApplication, IMapper mapper)
        {
            _vagaApplication = vagaApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ListarVagas()
        {
            var vagas = _vagaApplication.ListarVagasEmAberto();
            return Ok(vagas);
        }

        [HttpGet("{idVaga}")]
        [AllowAnonymous]
        public IActionResult ObterVaga(int IdVaga)
        {
            var vaga = _vagaApplication.Pesquisar(IdVaga);

            return Ok(vaga);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult IncluirVaga([FromBody] VagaModel vagaModel)
        {
            if (vagaModel == null || string.IsNullOrEmpty(vagaModel?.Descricao))
                return BadRequest("Favor Preencher os campos");

            var vagaPesquisa = _vagaApplication.Pesquisar(vagaModel.IdCandidato);

            if (vagaPesquisa?.Descricao == vagaModel?.Descricao && vagaPesquisa?.Local == vagaModel?.Local)
                return BadRequest("Vaga já existe!");

            var vagaCadastro = _mapper.Map<Vaga>(vagaModel);

            _vagaApplication.Incluir(vagaCadastro);
            return Ok(vagaModel);
        }

        [HttpPatch("{idVaga}")]
        [AllowAnonymous]
        public IActionResult AlterarVaga([FromBody] VagaModel vagaModel, int idVaga)
        {
            var vagaAlterar = _mapper.Map<Vaga>(vagaModel);
            vagaAlterar.IdVaga = idVaga;

            _vagaApplication.Alterar(vagaAlterar);

            return Ok(vagaModel);
        }

        [HttpDelete("{idVaga}")]
        [AllowAnonymous]
        public IActionResult ExcluirVaga(int idVaga)
        {
            _vagaApplication.EncerrarVaga(idVaga);
            return Ok();
        }
    }
}
