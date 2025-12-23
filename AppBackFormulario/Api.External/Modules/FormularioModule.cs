using Api.Application.Commands;
using Carter;
using MediatR;

namespace Api.External.Modules
{
    public class FormularioModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/formulario/")
                           .WithTags("Formulário")
                           .WithOpenApi();

            group.MapPost("criar", async (CriarContaCommand command, IMediator mediator) =>
            {
                var resultado = await mediator.Send(command);

                return resultado.Sucesso ? Results.Json(resultado, statusCode: resultado.StatusCode) :
                                           Results.Json(resultado, statusCode: resultado.StatusCode);

            })
             .WithName("Criar")
             .WithSummary("Criar novo cadastro")
             .WithDescription("Criar um novo cadastro para funcionário novo");
        }
    }
}
