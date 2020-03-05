using MyBank.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Conta.Domain.Models
{
    public abstract class Conta : Entity
    { 
        private Guid Id { get; set; }
        public decimal Saldo { get; private set; }

        public Conta(decimal saldo)
        {
            Id = Guid.NewGuid();
            Saldo = saldo;
        }


    }
}
