namespace conexiondebasededatos.Models
{
    public class Contacto
    {
        public int id { get; set; }
        public required string nombre { get; set; }
        public required string telefono { get; set; }
        public int usuarioId { get; set; }
        public required Usuario usuario { get; set; }
        =null!;
        //Paranguatirimicuaro
    }
}
