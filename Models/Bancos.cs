using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PC2MKTS.Models
{
    [Table("T_Bancoss")]
    public class Bancos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string? nomTit { get; set; }
        public string? tipCuen { get; set; }
        public decimal salIni { get; set; }
        public string? correO { get; set; }
    }
}