using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("vinculo")]
    public class Vinculo
    {
        [Key]
        public int id { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
    }
}
