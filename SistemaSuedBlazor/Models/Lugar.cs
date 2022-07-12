using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    public class Lugar
    {   
        public int id { get; set; }
        public int codLugar { get; set; }
        public int codTipo { get; set; }
        public int codSubTipo { get; set; }
        public string descripcion { get; set; }
        public int calle { get; set; }
        public int dirNro { get; set; }
        public string dirAdic { get; set; }

        [ForeignKey("calle")]
        public virtual Calles? calleNavigation { get; set; }

    }
}
