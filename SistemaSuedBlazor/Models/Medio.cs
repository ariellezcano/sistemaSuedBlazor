using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("medio")]
    public class Medio
    {
        [Key]
        public int id { get; set; }
        public int codMedio { get; set; }
        public string descripcion { get; set; }
        public int codTipo { get; set; }
    }
}
