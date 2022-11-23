using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto.Opciones.Entrada
{
    public partial class Entrada : Form
    {
        MODELO.Inventario Inv;
        Controlador.Controller Control = new Controlador.Controller();
        
        public Entrada()
        {
            InitializeComponent();
            if(Datos.Entradas.Count > 0 && Datos.Pros.Count > 0)
            {
                Control.RellenarEntradas(dgvEntrada, Datos.Entradas, Datos.Pros);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Falta validar mucho :D =>
            Datos.Entry = new MODELO.Entrada(Convert.ToInt32(txtNumDoumento.Text),txtDocProveedor.Text, txtProveedor.Text,
                txtCodProducto.Text, Convert.ToDouble(txtPrecioCompra.Text), Convert.ToInt32(nupCant.Value), dtRegistro.Value);
            Datos.Entradas.Add(Datos.Entry);
            Inv = new MODELO.Inventario(Control.EncontrarProduct(Datos.Entry, Datos.Pros), Datos.Entry.Cantidad, 0);
            Datos.Inventory.Add(Inv);
            Control.RellenarEntradas(dgvEntrada, Datos.Entradas, Datos.Pros);
        }
    }
}
