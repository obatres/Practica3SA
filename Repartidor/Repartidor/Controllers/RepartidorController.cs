using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repartidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepartidorController : Controller
    {
        public IActionResult Index()
        {
            WebRequest r = WebRequest.Create("http://localhost:51630/api/pedido/3");
            WebResponse response = r.GetResponse();
            return Ok(response);
             using ( Stream dataStream = response.GetResponseStream()) {
                   StreamReader reader = new StreamReader(dataStream);
                    object responseFromserver = reader.ReadToEnd();
                    
                    return Ok(responseFromserver);
                }
            
        }
    }
}