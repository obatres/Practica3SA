using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Modelos;
using Restaurante.Repositorios;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPPedido rpPedido = new RPPedido();
            return Ok(rpPedido.ObtenerPedidos());
            //sreturn Ok(View());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPPedido rpCli = new RPPedido();

            var cliRet = rpCli.ObtenerPedidoCliente(id);

            if (cliRet == null)
            {
                var nf = NotFound("El pedido del cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarPedido(Pedido nuevoPedido)
        {
            RPPedido rpCli = new RPPedido();
            rpCli.Agregar(nuevoPedido);
            return CreatedAtAction(nameof(AgregarPedido), nuevoPedido);
        }
    }
}