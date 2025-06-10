using Microsoft.AspNetCore.Mvc;

namespace MediatrStudying.Controllers
{
     
    public class Pinger : IPinger

    {

        public string? Msg { get; set; }


    }
}
