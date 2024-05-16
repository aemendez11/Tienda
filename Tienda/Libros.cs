namespace Tienda
{
    public class Libros:Productos_general
    {
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }

        public Libros() 
        { 
            Editorial=string.Empty;
            Categoria=string.Empty;
            Autor=string.Empty;
        }
    }
}
