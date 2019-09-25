using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevolvingAspNetCore.Models;

namespace RevolvingAspNetCore.ViewModels
{
    public class RevolvingsViewModel
    {
         
        public string Anr { get; set; }
        public List<Ewhpf> Ewhpf { get; set; }
        public Sddu Sddu { get; set; }
    }

     
}
