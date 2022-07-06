﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaSuedBlazor.Models
{
    [Table("")]
    public class Calles
    {
        [Key]
        public int id { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int barrio { get; set; }
    }
}
