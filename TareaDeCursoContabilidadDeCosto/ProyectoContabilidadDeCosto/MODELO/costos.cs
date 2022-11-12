namespace MODELO
{
    public class costos
    {
        public double costosIndirectosDeFabricacion { get; set; }
        public double materialesDirectos { get; set; }
        public double materialesIndirectosDeFabricacion { get; set; }
        public double manoDeObraDirecta { get; set; }
        public double manoDeObraIndirecta { get; set; }
        public double costoUnitario { get; set; }
    }
    public class venta
    {
        public double ganancias { get; set; }
        public double ventaRealizadas { get; set; }
    }

    public class baseDeDatos
    {
        static List<costos> baseDeDatosCostos = new List<costos>();
        static List<venta> baseDeDatosVentas = new List<venta>();
        public void AddContact(costos dato)
        {
            baseDeDatosCostos.Add(dato);
        }

        public void RemoverContacto(int i)
        {
            if (i != -1)
                baseDeDatosCostos.RemoveAt(i);
        }
        //public int BuscarIndice(String nombre)
        //{
        //    int indice = -1;
        //   costos a;
        //    for (int i = 0; i < baseDeDatosCostos.Count; i++)
        //    {
        //        a = (costos)baseDeDatosCostos[i];
        //        if (a. == nombre)
        //            indice = i;
        //    }
        //    return indice;
        //}
        //public Contacto BuscarContacto(string nombre)
        //{
        //    int i = BuscarIndice(nombre);
        //    if (i > -1)
        //        return (Contacto)datos[i];
        //    return null;
        //}
    }
}