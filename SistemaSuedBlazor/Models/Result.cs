namespace SistemaSuedBlazor.Models
{
    public class Result
    {
        public object dato { get; set; }
        public object[] data { get; set; };
        public int totalPaginas { get; set; };
        public int totalRegistros { get; set; };
        public string code { get; set; };
        public string message;
        public string error;
    }
}
