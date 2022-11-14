using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    internal class Salida
    {
        public int IdSalida { get; set; }
        public string FechaRegistro { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string MontoTotal { get; set; }
        public List<DetalleSalida> olistaDetalle { get; set; }
    }

    internal class DetalleSalida:Detalles
    {
    }
}
