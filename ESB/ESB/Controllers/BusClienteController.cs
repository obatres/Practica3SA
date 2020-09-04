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
        public async Task<IActionResult> AgregarPedidoAsync(PedidoCliente nuevoPedido)
        {

            RPCliente RPC = new RPCliente();
            await RPC.AgregarPedidoClienteAsync(nuevoPedido);
            return CreatedAtAction(nameof(AgregarPedidoAsync), nuevoPedido);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedidoCliente(int id)
        {
            RPCliente rp = new RPCliente();
            var pedido = await rp.ObtenerPedidoClienteUnicoAsync(id);
            return Ok(pedido);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarPedido(PedidoCliente actual)
        {
            RPCliente rp = new RPCliente();
            await rp.ActualizarPedidoAsync(actual);
            return CreatedAtAction(nameof(ActualizarPedido), actual);
        }
    }
}