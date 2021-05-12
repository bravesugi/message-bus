namespace MessageBus
{
    public interface IMessageBus
    {
        TResult Create<TMessage, TResult>(TMessage arg) where TMessage : ICommand where TResult : ICommand;
        void Send<T>(T arg) where T : ICommand;
        void Publish<T>(T arg) where T : IEvent;
        TResult Request<TMessage, TResult>(TMessage arg) where TMessage : IRequest;
    }
}
