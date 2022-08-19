using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSuedBlazor.model
{
    public class Paginate
    {
        public bool needed { get; set; }
        public int count { get; set; }
        public int page { get; set; }
        public int lastPage { get; set; }
        public int nextPage { get; set; }
        public int prevPage { get; set; }
        public int limit { get; set; }
        public int skip { get; set; }
    }
}
