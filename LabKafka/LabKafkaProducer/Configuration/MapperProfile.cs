using AutoMapper;
using LabKafkaProducer.Domain.Dtos;
using LabKafkaProducer.Domain.Models;

namespace LabKafkaProducer.Configuration
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<PropostaDto, Proposta>();
            CreateMap<Proposta, PropostaOutDto>();

            CreateMap<ClienteDto, Cliente>();
            CreateMap<Cliente, ClienteDto>();

            CreateMap<OfertaDto, Oferta>();
            CreateMap<Oferta, OfertaDto>();
        }
    }
}
