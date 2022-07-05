using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("modus")]
    public class Modus
    {
        [Key]
        public int id { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
    }
}
