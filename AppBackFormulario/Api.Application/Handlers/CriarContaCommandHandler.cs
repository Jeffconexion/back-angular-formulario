using Api.Application.Commands;
using Api.Application.DTOs;
using Api.Service.Common;
using Api.Service.Entidade;
using Api.Service.IRepository;
using MediatR;

namespace Api.Application.Handlers
{
    public class CriarContaCommandHandler : IRequestHandler<CriarContaCommand, ApiResponse<ContaDto>>
    {
        private readonly IPessoaRepository _pessoaRepository;

        public CriarContaCommandHandler(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Task<ApiResponse<ContaDto>> Handle(CriarContaCommand request, CancellationToken cancellationToken)
        {
            var contaDto = new ContaDto
            {
                Nome = request.Nome,
                Cpf = request.Cpf,
                DataDeNascimento = request.DataDeNascimento,
                Email = request.Email,
                Uf = request.Uf,
                Municipio = request.Municipio
            };

            var pessoa = new Pessoa
            {
                Nome = contaDto.Nome,
                Cpf = contaDto.Cpf,
                DataDeNascimento = contaDto.DataDeNascimento,
                Email = contaDto.Email,
                Uf = contaDto.Uf,
                Municipio = contaDto.Municipio
            };

            try
            {
                _pessoaRepository.AdicionarAsync(pessoa);

            }
            catch (Exception ex)
            {

                throw;
            }


            var response = new ApiResponse<ContaDto>
            {
                Dados = contaDto,
                Error = null,
                StatusCode = 201,
                Sucesso = true,
                Mensagem = "Conta Criada com sucesso"
            };

            return Task.FromResult(response);
        }
    }
}
