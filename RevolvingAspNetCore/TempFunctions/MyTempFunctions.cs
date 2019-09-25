using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevolvingAspNetCore.Models;

namespace RevolvingAspNetCore.TempFunctions
{
    public class MyTempFunctions
    {

        public List<Sddu> CreateNewListSddu(){
            List<Sddu> sddus = new List<Sddu>()
            {
                new Sddu(){Ncd = "KKKKKKKK", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
                new Sddu(){Ncd = "LLLLLLLL", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
                new Sddu(){Ncd = "LLLMMMMM", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
            };

            return sddus;
        }
        
    }
}
