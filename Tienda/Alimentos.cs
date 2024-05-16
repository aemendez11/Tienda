namespace Tienda
{
    public class Alimentos:Productos_general
    {
        public DateTime FechaVencimiento { get; set; }
        public string UnidadMedida { get; set; }

         public Alimentos()
        {
            FechaVencimiento= DateTime.Now;
            UnidadMedida = string.Empty;
        }
    }
}
