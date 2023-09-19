using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProyectoContabilidadDeCosto
{
    public partial class frmInicio : Form
    {
        int tri = 3;
        Thread th;
        string Usuario = "a", Clave = "a";
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContrase�a.Text;
            if (usuario == Usuario)
            {
                Error.SetError(txtUsuario, "");
                if (clave == Clave)
                {
                    Error.SetError(txtContrase�a, "");
                    time.Enabled = true;
                }
                else
                {
                    Error.SetError(txtContrase�a, "Contrase�a Incorrecta");
                    txtContrase�a.Clear(); 
                    txtContrase�a.Focus();
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
                    MessageBox.Show("Ha llegado al n�mero m�ximo de intentos");
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
            txtContrase�a.Clear();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (pbrContinuar.Value < 100)
                pbrContinuar.Value += 5;
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
                txtContrase�a.PasswordChar = '\0';
            else if (Mostrar.Checked == false)
                txtContrase�a.PasswordChar = '�';
        }
    }
}