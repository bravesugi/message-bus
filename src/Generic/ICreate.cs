namespace MessageBus.Generic
{
    public interface ICreate<TMessage, TResult> where TMessage : ICommand
    {
        TResult Handle(TMessage arg);
    }
}
