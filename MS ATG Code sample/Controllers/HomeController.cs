using MS_ATG_Code_sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MS_ATG_Code_sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public bool Vote(string gender)
        {
            var db = new ApplicationDbContext();
            db.Votes.Add(new Votes { Gender = gender });
            db.SaveChanges();
            return true;
        }

        [HttpGet]
        public string getStats()
        {
            var db = new ApplicationDbContext();
            VoteResultsViewModel view = new VoteResultsViewModel();
            int total = db.Votes.Count();
            float females = db.Votes.Count(x => x.Gender.ToLower() == "female");
            float males = db.Votes.Count(x => x.Gender.ToLower() == "male");
            if (males == 0)
            {
                view.males = 0;
            }
            else
            {
                view.males = (males / total) * 100;
            }
            if (females == 0)
            {
                view.females = females;
            }
            else
            {
                view.females = (females / total) * 100;
            }
            return JsonConvert.SerializeObject(view);
        }
    }
}