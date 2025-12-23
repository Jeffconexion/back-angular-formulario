using Api.Application.DTOs;
using Api.Service.Common;
using MediatR;

namespace Api.Application.Commands
{
    public record CriarContaCommand(
         string Nome,
         string Email,
         string Cpf,
         DateTime DataDeNascimento,
         string Uf,
         string Municipio
        ) : IRequest<ApiResponse<ContaDto>>;
}
