namespace SistemaSuedBlazor.Models
{
    public class Contravenciones
    {
        public int id { get; set; }
        //public string denominacion { get; set; }
        public DateTime periodo { get; set; }
        public TimeOnly hora { get; set; }
        public string expediente { get; set; }
        public int unidad { get; set; }
        public int total { get; set; }
        public int articulo { get; set; }
        public Boolean detenidos { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
    }
}
