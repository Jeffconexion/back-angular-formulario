namespace Api.Service.Common;
public class ApiResponse<T>
{
    public T? Dados { get; set; }
    public string? Error { get; set; }
    public int StatusCode { get; set; }
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; } = string.Empty;

    public static ApiResponse<T> SucessResponse(T dados, string mensagem = "Operação completa com sucesso")
    {
        return new ApiResponse<T>
        {
            Dados = dados,
            Error = null,
            StatusCode = 200,
            Sucesso = true,
            Mensagem = mensagem
        };
    }

    public static ApiResponse<T> ErrorResponse(string error, int statusCode, string mensagem = "Ocorreu um erro.")
    {
        return new ApiResponse<T>
        {
            Dados = default,
            Error = error,
            StatusCode = statusCode,
            Sucesso = false,
            Mensagem = mensagem
        };
    }

    public static ApiResponse<T> NotFoundResponse(string mensagem = "Recursos não encontrado")
    {
        return new ApiResponse<T>
        {
            Dados = default,
            Error = "Not Found",
            StatusCode = 404,
            Sucesso = false,
            Mensagem = mensagem
        };
    }

    public static ApiResponse<T> BadRequestResponse(string error, string mensagem = "Requisição inválida.")
    {
        return new ApiResponse<T>
        {
            Dados = default,
            Error = error,
            StatusCode = 400,
            Sucesso = false,
            Mensagem = mensagem
        };
    }

    public static ApiResponse<T> UnauthorizedResponse(string mensagem = "Autorização Negada")
    {
        return new ApiResponse<T>
        {
            Dados = default,
            Error = "Unauthorized",
            StatusCode = 401,
            Sucesso = false,
            Mensagem = mensagem
        };
    }

}

