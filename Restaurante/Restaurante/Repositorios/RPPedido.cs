using Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Repositorios
{
    public class RPPedido
    {
        public static List<Pedido> _listaPedidos = new List<Pedido>()
        {
            new Pedido() { Id = 1, Descripcion = "Pedido 1" , IdRestaurante = 1, IdRepartidor=1 , IdCliente= 1, Estado=1},
            new Pedido() { Id = 2, Descripcion = "Pedido 2" , IdRestaurante = 1, IdRepartidor=2 , IdCliente= 2, Estado=2},
            new Pedido() { Id = 3, Descripcion = "Pedido 3" , IdRestaurante = 1, IdRepartidor=3 , IdCliente=3, Estado=5}
        };

        public IEnumerable<Pedido> ObtenerPedidos()
        {
            return _listaPedidos;
        }

        public Pedido ObtenerPedidoCliente(int id)
        {
            var pedido = _listaPedidos.Where(ped => ped.IdCliente == id);

            return pedido.FirstOrDefault();
        }

        public void Agregar(Pedido nuevoCliente)
        {
            _listaPedidos.Add(nuevoCliente);
        }
    }
}
