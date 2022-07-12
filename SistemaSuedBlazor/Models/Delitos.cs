using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    public class Delitos
    {
        public int id { get; set; }
        public int codTitulo { get; set; }
        public string descripcion { get; set; }
        public string articulo { get; set; }
        public int dnpc { get; set; }
        public bool imputable { get; set; }
        public int codCapitulo { get; set;}
        public int codTipo { get; set;}
        public int codSubTipo { get; set; }

        [ForeignKey("dnpc")]
        public virtual Detdnpc? dnpcDelNavigation { get; set; }

    }
}
