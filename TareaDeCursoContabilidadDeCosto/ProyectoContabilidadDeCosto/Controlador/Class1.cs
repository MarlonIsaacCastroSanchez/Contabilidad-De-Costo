using MODELO;
namespace Controlador
{
    public class Controlador
    {
        baseDeDatos baseDeDatos= new baseDeDatos();
        //public void ViewContact(DataGridView dgvDatos)
        //{
        //    dgvDatos.Rows.Add(c.nombre, c.telefono, c.email);
        //}
        //public void SaveContact(TextBox Cel, TextBox Nom, TextBox Ema, ErrorProvider error, DataGridView dgvDatos)
        //{
        //    bool i = VerificarCamposLlenosAgregar(Cel, Nom, Ema, error);
        //    bool k = ValidarNumero(Cel, Nom, Ema, error);
        //    bool v = ValidarCorreo(Cel, Nom, Ema, error);
        //    if (i)
        //    {
        //        if (k && v)
        //        {
        //            BorrarErrorAgregar(Cel, Nom, Ema, error);
        //            string nom = Nom.Text;
        //            string cel = Cel.Text;
        //            string ema = Ema.Text;
        //            c.email = ema;
        //            c.nombre = nom;
        //            c.telefono = cel;
        //            bd.AddContact(c);
        //            ViewContact(dgvDatos);
        //            MessageBox.Show("Contacto Agregado");
        //        }
        //        else { MessageBox.Show("Ingrese los datos correctamente"); }
        //    }
        //    else { MessageBox.Show("Ingrese los datos"); }
        //}
        public void RemoverContacto(int i, DataGridView dgvDatos)
        {
            dgvDatos.Rows.RemoveAt(i);
            baseDeDatos.RemoverContacto(i);
            MessageBox.Show("Contacto Eliminado");
        }
    }
}