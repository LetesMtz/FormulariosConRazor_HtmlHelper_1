using System.ComponentModel.DataAnnotations;

namespace FormulariosConRazor_HtmlHelper_1.Models
{
    public class usuarios
    {
        [Key]
        public int id_usuarios { get; set; }
        public string nombre_usuario { get; set; }
        public string clave { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
        public string? pasatiempos { get; set; }
        public string curso { get; set; }
        public string conocimientos { get; set; }
    }
}
