using MODELO;
using System.Windows.Forms;

namespace Controlador
{
    public class Controller
    {
        public DataGridView RellenarProductos(DataGridView Propus, MODELO.Producto Products)
        {
            Propus.Rows.Add(Products.Codigo, Products.Nombre, Products.Categoria);
            return Propus;
        }
        public DataGridView ActualizarProductos(DataGridView Pros, List<MODELO.Producto> Products)
        {
            foreach(Producto Product in Products)
            {
                Pros.Rows.Add(Product.Codigo, Product.Nombre, Product.Categoria);
            }
            return Pros;
        }
    }
}