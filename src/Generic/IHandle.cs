namespace MessageBus.Generic
{
    public interface IHandle<TMessage> where TMessage : IMessage
    {
        void Handle(TMessage arg);
    }
}
