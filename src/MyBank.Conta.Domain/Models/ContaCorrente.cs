using MyBank.Conta.Domain.ValueObjects;

namespace MyBank.Conta.Domain.Models
{
    public class ContaCorrente
    {
        public Correntista Correntista { get; set; }
        public decimal Saldo { get; private set; }
        public string TipoConta { get; private set; }
        public Endereco Endereco { get; private set; }
        public InformacoesBancarias InformacoesBancarias { get; private set; }

        public ContaCorrente(Correntista correntista, decimal saldo, string tipoConta, Endereco endereco, InformacoesBancarias informacoesBancarias)
        {
            Correntista = correntista;
            Saldo = saldo;
            TipoConta = tipoConta;
            Endereco = endereco;
            InformacoesBancarias = informacoesBancarias;
        }
    }
}
