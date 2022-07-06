using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    public class Localidad
    {
        public int id { get; set; }
        public string localidad { get; set; }
        public int departamento { get; set; }
        public int nacion { get; set; }
        public string cp { get; set; }

        //public int indec_p { get; set; }
        //public int indec_dlo { get; set; }
        //public int indec_i { get; set; }

        [ForeignKey("nacion")]
        public virtual Naciones? nacionNavigation { get; set; }


    }
}
