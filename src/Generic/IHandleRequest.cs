namespace MessageBus.Generic
{
    public interface IHandleRequest<TRequest, TResult> where TRequest : IRequest
    {
        TResult Get(TRequest arg);
    }
}
