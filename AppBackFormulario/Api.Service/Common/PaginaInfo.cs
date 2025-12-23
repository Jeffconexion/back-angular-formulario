namespace Api.Service.Common;

public class PaginaInfo
{
    public int Pagina { get; set; }
    public int TamanhoDaPagina { get; set; }
    public int TotalDePaginas { get; set; }
    public int TotalDeItens { get; set; }

    public PaginaInfo(int pagina, int tamanhoDaPagina, int totalDeItens)
    {
        Pagina = pagina;
        TamanhoDaPagina = tamanhoDaPagina;
        TotalDeItens = totalDeItens;
        TotalDePaginas = (int)Math.Ceiling(totalDeItens / (double)tamanhoDaPagina);
    }
}

