namespace Teste.WebApi.DTOs
{
    public record EnderecoDTO(string Logradouro, 
                                string Numero, 
                                string CEP, 
                                string Complemento, 
                                string Cidade, 
                                string UF);
}
