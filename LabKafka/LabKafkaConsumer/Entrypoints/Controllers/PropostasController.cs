using LabKafkaConsumer.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace LabKafkaConsumer.Entrypoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropostasController(IRecuperarPropostaUseCase recuperarProposta) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUltimasPropostas()
        {
            var resposta = await recuperarProposta.Execute();

            if (resposta.HasError)
                return BadRequest(resposta.ErrorMessage);

            if (resposta.Propostas is null || resposta.Propostas.Count == 0)
                return NotFound();

            return Ok(resposta.Propostas);
        }
    }
}
