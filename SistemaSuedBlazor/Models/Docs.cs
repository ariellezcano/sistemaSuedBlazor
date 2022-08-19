using SistemaSuedBlazor.model;

namespace SistemaSuedBlazor.Models
{
    public class Docs<T>
    {
        public List<T> docs { get; set; }
        public Paginate paginate { get; set; }
    }
}
