using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("prevmedio")]
    public class PrevMedio
    {
        [Key]
        public int id { get; set; }
        public int nroOrden { get; set; }
        public string sec { get; set; }
        public int codigo { get; set; }
        public bool secuestro { get; set; }
        public DateTime fecha { get; set; }

    }
}
