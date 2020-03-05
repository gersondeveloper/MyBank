using MyBank.Core.DomainObjects;

namespace MyBank.Conta.Domain.ValueObjects
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
