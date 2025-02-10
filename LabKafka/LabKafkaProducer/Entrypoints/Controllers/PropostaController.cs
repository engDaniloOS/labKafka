using LabKafkaProducer.Domain.Dtos;
using LabKafkaProducer.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabKafkaProducer.Entrypoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropostaController(IPublicarPropostaUseCase publicarUseCase) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PublicarProposta([FromBody]PropostaDto propostaDto)
        {
            var watch = Stopwatch.StartNew();

            var propostaPublicada = await publicarUseCase.Executar(propostaDto);

            watch.Stop();

            Console.WriteLine($"Requisicao processada em {watch.Elapsed.TotalMilliseconds}ms");

            if(propostaPublicada.HasError)
                return BadRequest(propostaPublicada.ErrorMessage);

            return Ok(propostaPublicada);
        }
    }
}
