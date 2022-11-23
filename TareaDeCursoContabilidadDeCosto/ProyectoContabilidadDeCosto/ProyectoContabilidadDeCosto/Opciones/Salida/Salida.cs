﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoContabilidadDeCosto.Opciones.Salida
{
    public partial class Salida : Form
    {
        Controlador.Controller Control = new Controlador.Controller();
        public Salida()
        {
            InitializeComponent();
            if(Datos.Entradas.Count > 0&& Datos.Salidas.Count > 0 && Datos.Pros.Count>0)
            {
                Control.RellenarSalidas(dgvSalida, Datos.Salidas, Datos.Pros);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Falta validar mucho :D =>
            Datos.Exit = Control.ValidarSalida(Datos.Entradas, txtNumDoumento, txtNumCliente, txtCliente,
                txtCodProducto, nupCant, dtRegistro);
            Datos.Salidas.Add(Datos.Exit);
            Control.AsignarPrecioVenta(Datos.Salidas, Datos.Entradas);
            Control.RegistrarSalida(Datos.Inventory, Datos.Salidas);
            Control.RellenarSalidas(dgvSalida, Datos.Salidas, Datos.Pros);
        }
    }
}
