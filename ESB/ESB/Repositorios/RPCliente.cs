using ESB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESB.Repositorios
{
    public class RPCliente
    {
        public static PedidoCliente Pcliente = new PedidoCliente()
        {
            Pedido="no hay pedido aun"
        };

        public object ObtenerPedidoCliente()
        {
            return Pcliente;
        }

        public void AgregarPedidoCliente(string nuevo)
        {
            
            Pcliente.Pedido = nuevo;
        }
    }
}
