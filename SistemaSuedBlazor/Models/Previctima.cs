using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("previctima")]
    public class Previctima
    {
        [Key]
        public int id { get; set; }
        public int norden { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public string nacionalidad { get; set; }
        public string estudios { get; set; }
        public string ocupacion { get; set; }
        public int clase_dnpc { get; set; }
        public int vehiculo_dnpc { get; set;  }
        public bool fallecio { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sitOcup { get; set; }
        public string especidificar { get; set;  }


        [ForeignKey("sexo")]
        public virtual Vsexos? sexoNavigation { get; set; }
        [ForeignKey("nacionalidad")]
        public virtual Naciones? nacionalidadNavigation { get; set; }
        [ForeignKey("estudios")]
        public virtual Vestudios? estudiosNavigation { get; set; }
        [ForeignKey("ocupacion")]
        public virtual Ocupacion? ocupacionNavigation { get; set; }

    }
}
