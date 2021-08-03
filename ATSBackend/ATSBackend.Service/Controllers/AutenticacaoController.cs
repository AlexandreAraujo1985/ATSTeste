using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace ATSBackend.Controllers
{
    [Route("api/[controller]")]
    public class AutenticacaoController : Controller
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar([FromBody] User user)
        {
            var usuarios = new List<User>
            {
                new User{ Nome = "Nair Ferreira Alves de Araujo" }
            };

            var usuario = usuarios.FirstOrDefault(u => u.Nome == user.Nome);

            if (usuario == null)
                return NotFound(new { mensagem = "Usuário ou senha inválidos" });

            var token = Token.GenerateToken(usuario);
            return Ok(new { usuario = usuario, token = token });
        }
    }
}
