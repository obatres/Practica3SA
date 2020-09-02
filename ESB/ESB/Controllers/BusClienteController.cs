using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESB.Modelos;
using ESB.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace ESB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusClienteController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            RPCliente rc = new RPCliente();
            return Ok(rc.ObtenerPedidoCliente());
        }

        [HttpPost("agregar")]
        public IActionResult AgregarPedido(string nuevoPedido)
        {

            Console.WriteLine(nuevoPedido);
            RPCliente RPC = new  RPCliente();
            RPC.AgregarPedidoCliente(nuevoPedido);
            return CreatedAtAction(nameof(AgregarPedido), nuevoPedido);
        }
    }
}