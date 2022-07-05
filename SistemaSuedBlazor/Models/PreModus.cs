using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("premodus")]
    public class PreModus
    {
        [Key]
        public int id { get; set; }
        public int nororden { get; set; }
        public int modalidad { get; set; }

        [ForeignKey("modalidad")]
        public virtual Modus? ModusNavigation { get; set; }
    }
}
