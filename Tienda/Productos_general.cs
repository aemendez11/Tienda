using System.ComponentModel.DataAnnotations;

namespace Tienda
{
    public class Productos_general
    {
        [Required(ErrorMessage = "El Codigo del requerido")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Nombre del requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La Descripcion del requerido")]
        public string Descripcion { get; set; }
     
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        public Productos_general()
        {
            Codigo = string.Empty; 
            Nombre = string.Empty;  
            Descripcion = string.Empty;
            PrecioCompra = 0;
            PrecioVenta = 0;
        }
    }
}
