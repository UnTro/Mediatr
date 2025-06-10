using MediatR;
using MediatrStudying.Controllers;

namespace MediatrStudying
{
    public class GenericPing<T> :IRequest<T> where T : class,IPinger
    {
        public T? Ping { get; set; }    

    }
}
