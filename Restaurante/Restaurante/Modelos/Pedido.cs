using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdRestaurante { get; set; }
        public int IdRepartidor { get; set; }
        public int IdCliente { get; set; }
    }
}
