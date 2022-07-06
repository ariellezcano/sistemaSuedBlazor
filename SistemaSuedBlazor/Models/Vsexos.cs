using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("vsexos")]
    public class Vsexos
    {
        [Key]
        public int id { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
    }
}
