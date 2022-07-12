using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    public class PreAmpli
    {
        public int id { get; set; }
        public string nroOrden { get; set; }
        public DateTime fecha { get; set; }
        public string nota { get; set; }
        public int unidad { get; set; }
        public string obs { get; set; }

        //[ForeignKey("unidad")]
        //public virtual Unidad? unidadNavigation { get; set; }

    }
}
