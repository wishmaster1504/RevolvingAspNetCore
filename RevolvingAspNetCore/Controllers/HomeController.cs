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

        public IActionResult Details(string anr, string ncd)
        {
            MyTempFunctions tempFunctions = new MyTempFunctions(); // временные функции  

            List<Ewhpf> ewhpfs = new List<Ewhpf>(tempFunctions.CreateNewListEwh()).Where(x => x.Anr.Equals(anr)).ToList();
             
            List<Sddu> sddus = new List<Sddu>(tempFunctions.CreateNewListSddu());
            Sddu _sddu = new Sddu();
            _sddu = sddus.Single(x => x.Ncd.Equals(ncd));
           

              

            RevolvingsViewModel revolvingsViewModel = new RevolvingsViewModel()
            {
                Anr = anr,
                Ewhpf = ewhpfs,
                Sddu = _sddu
            };




            return View(revolvingsViewModel);
        } 

           
        
    }
}
