namespace Tienda
{
    public class Electronicos:Productos_general
    {
        public int TiempoGarantia { get; set; } // en meses
        public string Voltaje { get; set; }

        public Electronicos()
        {
            TiempoGarantia=int.MinValue;
            Voltaje = string.Empty;
        }
    }
}
