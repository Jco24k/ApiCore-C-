using System.ComponentModel.DataAnnotations;
namespace LibreriaBackEnd.Models
{
    public class PA_PRODUCTO_CLIENTE
    {
        [Key]
        public string clave { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double total { get; set; }

    }
}
