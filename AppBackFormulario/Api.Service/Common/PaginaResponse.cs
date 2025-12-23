namespace Api.Service.Common;

public class PaginaResponse<T>
{
    public List<T> Contas { get; set; } = new();
    public PaginaInfo Paginacao { get; set; }

    public PaginaResponse(List<T> itens, int pagina, int tamanhoDaPagina, int totalDeItens)
    {
        Contas = itens;
        Paginacao = new PaginaInfo(pagina, tamanhoDaPagina, totalDeItens);
    }
}

