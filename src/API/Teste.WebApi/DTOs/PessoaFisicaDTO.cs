namespace Teste.WebApi.DTOs
{
    public record PessoaFisicaDTO(string Nome, 
                                    string Sobrenome,
                                    DateTime DataNascimento, 
                                    string Email, 
                                    string CPF, 
                                    string RG,
                                    List<ContatoDTO> Contatos,
                                    List<EnderecoDTO> Enderecos);
}
