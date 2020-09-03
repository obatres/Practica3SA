using ESB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;


namespace ESB.Repositorios
{
    public class RPCliente
    {
        public static PedidoCliente ListaPedidoCliente = new PedidoCliente()
        {
             Id =0, Descripcion = "Pedido 0" , IdRestaurante = 0, IdRepartidor=0 , IdCliente= 0, Estado=0
        };


        public PedidoCliente ObtenerPedidoCliente()
        {
            return ListaPedidoCliente;
        }

        public async Task AgregarPedidoClienteAsync(PedidoCliente nuevo)
        {

            var response = await "http://localhost:51630/api/Pedido/agregar".PostJsonAsync(nuevo);

        }

        public async Task<PedidoCliente> ObtenerPedidoClienteUnicoAsync(int id)
        {
            var url = "http://localhost:51630/api/pedido/" + id.ToString();
            var response = await url.GetJsonAsync<PedidoCliente>();
            //Console.WriteLine("-AQUI ABAJO ESTA EL RWSULTADO----");
            //Console.WriteLine(response.Id);
            //PedidoCliente p = new PedidoCliente();
            return response;
        }

    }
}
