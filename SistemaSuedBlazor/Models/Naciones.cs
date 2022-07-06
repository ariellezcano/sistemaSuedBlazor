using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("naciones")]
    public class Naciones
    {
        [Key]
        public int id { get; set; }
        public int codigo { get; set; }
        public string nacion { get; set; }
        public string nacionalidad { get; set; }
    }
}
