namespace conexiondebasededatos.Models
{
    public class Usuario
    {
       public int id { get; set; }
         public required string nombre { get; set; }
        public int edad { get; set; }
        public List<Contacto> contactos = new();
    }
}
