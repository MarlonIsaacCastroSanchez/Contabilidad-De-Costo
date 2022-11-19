using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto.Opciones.Productos
{
    public partial class Productos : Form
    {
        Controlador.Controller Control = new Controlador.Controller();
        public Productos()
        {
            InitializeComponent();
            if (Datos.Pros.Count > 0)
            {
                dgvProductos.Rows.Clear();
                dgvProductos = Control.ActualizarProductos(dgvProductos, Datos.Pros);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (cbCategorias.Text != "")
            { 
                if (Datos.Pros.Count > 0)
                {
                    dgvProductos.Rows.Clear();
                    dgvProductos = Control.ActualizarProductos(dgvProductos, Datos.Pros);
                }
                Datos.Pro = new MODELO.Producto(txtCodProducto.Text, txtProducto.Text, cbCategorias.Text, 0, 0);
                Datos.Pros.Add(Datos.Pro);
                dgvProductos = Control.RellenarProductos(dgvProductos, Datos.Pro);
                MessageBox.Show("Producto Agregado");
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una categoria");
            }
        }
    }
}
