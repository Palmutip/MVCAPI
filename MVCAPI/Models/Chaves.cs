using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models
{
    public partial class Chaves
    {
        [Key]
        public int Id { get; set; }
        public byte Numchave { get; set; }
        public string Stringchave { get; set; }
    }
}
