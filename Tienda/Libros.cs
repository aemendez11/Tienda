namespace Tienda
{
    public class Libros
    {
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }

        Libros() 
        { 
            Editorial=string.Empty;
            Categoria=string.Empty;
            Autor=string.Empty;
        }
    }
}
