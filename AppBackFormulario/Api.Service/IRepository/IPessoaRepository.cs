using Api.Service.Entidade;

namespace Api.Service.IRepository
{
    public interface IPessoaRepository
    {
        Task AdicionarAsync(Pessoa pessoa);
    }
}
