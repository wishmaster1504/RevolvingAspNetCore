using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RevolvingAspNetCore.Models;
using RevolvingAspNetCore.ViewModels;
using RevolvingAspNetCore.TempFunctions;

namespace RevolvingAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
             
            return View();
        }

        public IActionResult ViewRev()
        {
            List<Ew0pf> ew0Pfs = new List<Ew0pf>()
            {
                new Ew0pf() {Anr = "RV25",Ncd = "KKKKKKKK", Sts = "A", Dsp = DateTime.Now, Pnum = 2, Dsd = DateTime.Now, Dod = DateTime.Now, Dep = DateTime.Now, Ts = DateTime.Now},
                new Ew0pf() {Anr = "RV33",Ncd = "LLLLLLLL", Sts = "A", Dsp = DateTime.Now, Pnum = 1, Dsd = DateTime.Now, Dod = DateTime.Now, Dep = DateTime.Now, Ts = DateTime.Now},
                new Ew0pf() {Anr = "RV43",Ncd = "LLLMMMMM", Sts = "A", Dsp = DateTime.Now, Pnum = 1, Dsd = DateTime.Now, Dod = DateTime.Now, Dep = DateTime.Now, Ts = DateTime.Now}


            };
             
            return View(ew0Pfs);
        }

         
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddRev()
        {
            return View();
        }

        public IActionResult Details(Ew0pf ew0pf)
        {
            List<Ewhpf> ewhpfs = new List<Ewhpf>()
            {
             new Ewhpf() { Anr = "RV25", Pnum = 1, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "N", Ts = DateTime.Now},
             new Ewhpf() { Anr = "RV25", Pnum = 2, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "Y", Ts = DateTime.Now},
             new Ewhpf() { Anr = "RV33", Pnum = 1, Dsp = DateTime.Now, Dep = DateTime.Now, Vama = 400, Am1 = 300, Last = "Y", Ts = DateTime.Now},
            };

            
            List<Ewhpf> _ewh = new List<Ewhpf>(ewhpfs.Where(x => x.Anr.Equals(ew0pf.Anr)).ToList());


            MyTempFunctions tempFunctions = new MyTempFunctions(); // временные функции  
            List<Sddu> sddus = new List<Sddu>(tempFunctions.CreateNewListSddu());
            Sddu _sddu = new Sddu();
            foreach (var t in
            //_sddu = sddus.Where(x => x.Ncd.Equals(ew0pf.Ncd));
            from t in sddus
            where t.Ncd.Equals(ew0pf.Ncd)
            select t)
            {
                _sddu = t;
                break;
            }

            sddus = tempFunctions.CreateNewListSddu();


            RevolvingsViewModel revolvingsViewModel = new RevolvingsViewModel()
            {
                Anr = ew0pf.Anr,
                Ewhpf = _ewh,
                Sddu = _sddu
            };




            return View(revolvingsViewModel);
        } 

           
        
    }
}
