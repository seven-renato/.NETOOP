using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio;
internal class ClienteRico
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    public ClienteRico(int id, string nome, string endereco)
    {
        DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome deve ser preenchido.");
        DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereço deve ser preenchido.");

        Id = id;
        Nome = nome;
        Endereco = endereco;
    }
}
