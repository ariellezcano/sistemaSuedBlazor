namespace SistemaSuedBlazor.Models
{
    public class Result<T>
    {
        public string code { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public Docs<T> data { get; set; }
    }
}
