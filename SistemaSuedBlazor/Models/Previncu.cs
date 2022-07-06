using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("previncu")]
    public class Previncu
    {
        [Key]
        public int id { get; set; }
        public int norden { get; set; }
        public int sexo { get; set; }
        public int edad { get; set; }
        public int nacionalidad { get; set; }
        public int estudios { get; set; }
        public int ocupacion { get; set; }
        public int vinculo { get; set; }
        public int detenido { get; set; }
        public DateTime fechaD { get; set; }
        public string nombre { get; set; }
        public string alias { get; set; }
        public int pronGabinete { get; set; }
        public int pronNro { get; set; }
        public int calle { get; set; }
        public int nroDir { get; set; }
        public string adicional { get; set; }
        public int localidad { get; set; }
        public int clase { get; set; }
        public int vehiculo { get; set; }

        [ForeignKey("sexo")]
        public virtual Vsexos? sexoNavigation { get; set; }
        [ForeignKey("nacionalidad")]
        public virtual Naciones? nacionesNavigation { get; set; }
        [ForeignKey("estudios")]
        public virtual Vestudios? estudiosNavigation { get; set; }
        [ForeignKey("ocupacion")]
        public virtual Ocupacion? ocupacionNavigation { get; set; }
        [ForeignKey("vinculo")]
        public virtual Vinculo? vinculoNavigation { get; set; }
        [ForeignKey("calle")]
        public virtual Calles? calleNavigation { get; set; }


    }
}
