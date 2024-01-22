namespace Teste.WebApi.DTOs
{
    public record ContatoDTO(string Nome,
                            string ContatoEmail,
                            string ContatoTelefone,
                            int TipoContato);
}
