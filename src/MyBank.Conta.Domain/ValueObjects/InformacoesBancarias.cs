using MyBank.Core.DomainObjects;

namespace MyBank.Conta.Domain.ValueObjects
{
    public class InformacoesBancarias : Entity
    {
        public int NumeroAgencia { get; private set; }
        public int NumeroConta { get; private set; }
        public int DigitoConta { get; private set; }

    }
}
