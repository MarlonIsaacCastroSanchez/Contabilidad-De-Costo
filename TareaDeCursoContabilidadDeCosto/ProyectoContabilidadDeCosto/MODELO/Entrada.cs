using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    internal class Entrada
    {
        public int IdEntrada { get; set; }
        public string FechaRegistro { get; set; }
        public string DocumentoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string MontoTotal { get; set; }
        public List<DetallesEntrada> EntradaDetalles { get; set; }
    }
    internal class DetallesEntrada : Detalles { }
}
