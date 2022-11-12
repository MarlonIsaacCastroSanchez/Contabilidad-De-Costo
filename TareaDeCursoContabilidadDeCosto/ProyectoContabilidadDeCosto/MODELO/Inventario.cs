using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MODELO
{
    internal class Inventario
    {
        private string codProducto;
        private string nomProducto;
        private int cantProducto;
        private double preProducto;
        
        public Inventario() { }
        public Inventario(string codProducto, string nomProducto, int cantProducto, double preProducto)
        {
            this.codProducto = codProducto;
            this.nomProducto = nomProducto;
            this.cantProducto = cantProducto;
            this.preProducto = preProducto;
        }
        public string CodProducto { get { return codProducto; } set { codProducto = value; } }
        public string NomProducto { get { return nomProducto; } set { nomProducto = value; } }
        public int CantProducto { get { return cantProducto; } set { cantProducto = value; } }
        public double PreProducto { get { return preProducto; } set { preProducto = value; } }
    }
}
