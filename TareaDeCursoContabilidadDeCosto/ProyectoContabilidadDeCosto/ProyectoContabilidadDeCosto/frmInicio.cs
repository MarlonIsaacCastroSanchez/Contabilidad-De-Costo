using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProyectoContabilidadDeCosto
{
    public partial class frmInicio : Form
    {
        int tri = 3;
        Thread th;
        string Usuario = "Proyecto", Clave = "Contabilidad";
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;
            if (usuario == Usuario)
            {
                Error.SetError(txtUsuario, "");
                if (clave == Clave)
                {
                    Error.SetError(txtContraseña, "");
                    time.Enabled = true;
                }
                else
                {
                    Error.SetError(txtContraseña, "Contraseña Incorrecta");
                    txtContraseña.Clear(); 
                    txtContraseña.Focus();
                    return;
                }
            }
            else
            {
                Error.SetError(txtUsuario, "Usuario Incorrecto");
                Limpiar();
                txtUsuario.Focus();
                return;
            }
            if (usuario !=Usuario && clave != Clave)
            {
                tri--;
                if (tri == 0)
                {
                    MessageBox.Show("Ha llegado al número máximo de intentos");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tri = 3;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AbrirNuevoFrom()
        {
            Application.Run(new frmPrincipalMenu());
        }
        public void Limpiar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (pbrContinuar.Value < 100)
                pbrContinuar.Value++;
            if (pbrContinuar.Value == 100)
            {
                time.Enabled = false;
                th = new Thread(AbrirNuevoFrom);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }
        private void Mostrar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Mostrar.Checked == true)
                txtContraseña.PasswordChar = '\0';
            else if (Mostrar.Checked == false)
                txtContraseña.PasswordChar = '*';
        }
    }
}