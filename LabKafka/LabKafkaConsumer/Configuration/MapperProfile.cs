using AutoMapper;
using LabKafkaConsumer.Domain.Dtos;
using LabKafkaConsumer.Domain.Models;

namespace LabKafkaProducer.Configuration
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<PropostaDto, Proposta>();
            CreateMap<Proposta, PropostaDto>();

            CreateMap<Cliente, ClienteDto>();
            CreateMap<Oferta, OfertaDto>();
        }
    }
}
