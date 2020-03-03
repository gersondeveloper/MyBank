using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank.Core.DomainObjects
{
    public class Entity
    {
        public Guid Id { get; private set; }

        private List<Event> _notificacoes;
        public IReadOnlyCollection<Event> Notificacoes => _notificacoes?.AsReadOnly();

        public Entity()
        {
            Id = Guid.NewGuid();
        }


    }
}
