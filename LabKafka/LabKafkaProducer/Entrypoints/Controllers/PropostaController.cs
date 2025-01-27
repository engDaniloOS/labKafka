using LabKafkaProducer.Domain.Dtos;
using LabKafkaProducer.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace LabKafkaProducer.Entrypoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropostaController(IPublicarPropostaUseCase publicarUseCase) : ControllerBase
    {

        private readonly IPublicarPropostaUseCase _publicarUseCase = publicarUseCase;

        [HttpPost]
        public async Task<IActionResult> PublicarProposta([FromBody]PropostaDto propostaDto)
        {
            var propostaPublicada = await _publicarUseCase.Executar(propostaDto);

            if(propostaPublicada.HasError)
                return BadRequest(propostaPublicada.ErrorMessage);

            return Ok(propostaPublicada);
        }
    }
}
