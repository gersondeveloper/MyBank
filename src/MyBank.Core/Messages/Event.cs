using MediatR;

namespace MyBank.Core.Messages
{
    public abstract class Event : Message, INotification
    {

    }
}
