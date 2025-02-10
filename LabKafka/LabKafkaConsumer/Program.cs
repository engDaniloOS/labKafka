
using LabKafkaConsumer.Configuration;
using LabKafkaConsumer.Domain;
using LabKafkaConsumer.Domain.UseCases;

namespace LabKafkaConsumer
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            DependencyInjectionServiceConfig.Configure(builder.Services);
            KafkaConsumerServiceConfig.Configure(builder.Services, builder.Configuration);
            DatabaseServiceConfig.Configure(builder.Services, builder.Configuration);
            MapperServiceConfig.Configure(builder.Services);

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapGet("api/propostas", async (IRecuperarPropostaUseCase recuperarProposta) =>
            {
                var resposta = await recuperarProposta.Execute();

                if (resposta.HasError)
                    return Results.BadRequest(resposta.ErrorMessage);

                if (resposta.Propostas is null || resposta.Propostas.Count == 0)
                    return Results.NotFound();

                return Results.Ok(resposta.Propostas);
            });

            app.Run();
        }
    }
}
