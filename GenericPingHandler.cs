using MediatR;
using MediatrStudying.Controllers;

namespace MediatrStudying
{
    public class GenericPingHandler<T> : IRequestHandler<GenericPing<T>, T>
        where T : class, IPinger
    {
        public Task<T> Handle(GenericPing<T> request, CancellationToken cancellationToken)
        {
            return Task.FromResult("ping");
        }
    }
}
