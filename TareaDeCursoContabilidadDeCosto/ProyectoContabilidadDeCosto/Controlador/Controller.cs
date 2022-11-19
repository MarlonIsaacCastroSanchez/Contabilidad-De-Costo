using System.Windows.Forms;

namespace Controlador
{
    public class Controller
    {
        public DataGridView RellanrProductos(DataGridView Propus, MODELO.Producto Products)
        {
            Propus.Rows.Add(Products.Codigo, Products.Nombre, Products.Categoria);
            return Propus;
        }
    }
}