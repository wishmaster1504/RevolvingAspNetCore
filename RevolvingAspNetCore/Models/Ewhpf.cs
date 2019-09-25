using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // для [Column(TypeName = "decimal(18, 2)")]

namespace RevolvingAspNetCore.Models
{
    public class Ewhpf
    {
        public string Anr { get; set; }
        public int Pnum { get; set; }
        //[DataType(DataType.Date)]                                 // не работает почему то
        //[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]     // не работает почему то
        public DateTime Dsp { get; set; }
        //[DataType(DataType.Date)]                                 // не работает почему то
        public DateTime Dep { get; set; }

        [Column(TypeName = "decimal(18, 2)")]                       // это скорее всего тоже не работает
        public decimal Vama { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Am1 { get; set; }
        public string Last { get; set; }
        public DateTime Ts { get; set; }

    }
}
