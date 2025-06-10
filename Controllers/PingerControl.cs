using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatrStudying.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingerControl :ControllerBase
    {
        private IMediator _mediator;

        [HttpGet(Name = "ggg")]
        public async void Get()
        {
           var ping =  await _mediator.Send(new GenericPing<Pinger> { Ping = new() { Msg = "ping" } });
           Console.WriteLine(ping.Msg);
        }
    }
}
