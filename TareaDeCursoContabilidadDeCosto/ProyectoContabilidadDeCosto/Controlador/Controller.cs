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
        public void EliminarProducto(int Pos, List<MODELO.Producto> Productos, DataGridView ola)
        {
            if(Pos > -1 && Pos < Productos.Count)
            {
                Productos.RemoveAt(Pos);
                ola.Rows.RemoveAt(Pos);
            }
        }
    }
}