﻿namespace LabKafkaConsumer.Domain.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
