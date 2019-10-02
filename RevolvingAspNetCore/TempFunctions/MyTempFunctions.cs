using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RevolvingAspNetCore.Models;

namespace RevolvingAspNetCore.TempFunctions
{
    public class MyTempFunctions
    {
        //временно создадим в классе списки,
        // имитирующие данные в БД
        // Создаваться списки будут вместе
        // с созданием экземпляра класса MyTempFunctions

        public List<Sddu> CreateNewListSddu(){
            List<Sddu> sddus = new List<Sddu>()
            {
                new Sddu(){Ncd = "KKKKKKKK", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
                new Sddu(){Ncd = "LLLLLLLL", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
                new Sddu(){Ncd = "LLLMMMMM", Type = "KRK", Dnk = DateTime.Now, Dek = DateTime.Now, Ts = DateTime.Now},
            };

            return sddus;
        }

        public List<Ewhpf> CreateNewListEwh()
        {
            List<Ewhpf> ewhpfs = new List<Ewhpf>()
            {
                new Ewhpf() { Anr = "RV25", Pnum = 1, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "N", Ts = DateTime.Now},
                new Ewhpf() { Anr = "RV25", Pnum = 2, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "Y", Ts = DateTime.Now},
                new Ewhpf() { Anr = "RV33", Pnum = 1, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "Y", Ts = DateTime.Now}
            };

            return ewhpfs;
        }
        
    }
}
