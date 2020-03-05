using MyBank.Conta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Conta.Domain.ValueObjects
{
    public class Correntista
    {
        public string NomeCompleto { get; set; }
        public long Cpf { get; set; }
        public long RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public List<ContaCorrente> ContasCorrente { get; set; }
        public List<ContaPoupanca> ContasPoupanca { get; set; }
    }
}
