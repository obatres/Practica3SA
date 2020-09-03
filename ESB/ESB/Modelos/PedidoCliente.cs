using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESB.Modelos
{
    public class PedidoCliente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdRestaurante { get; set; }
        public int IdRepartidor { get; set; }
        public int IdCliente { get; set; }
        public int Estado { get; set; }
    }
}
