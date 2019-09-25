using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RevolvingAspNetCore.Models
{
    public class Ew0pf
    {
        public string Anr { get; set; }
        public string Ncd { get; set; }
        public string Sts { get; set; }
        public int Pnum { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dod { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dsd { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dsp { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dep { get; set; } 
        public DateTime Ts { get; set; }
}
}
