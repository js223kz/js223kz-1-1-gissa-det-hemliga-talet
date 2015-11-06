using GuessSecretNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessSecretNumber.Controllers
{
    
    public class HomeController : Controller
    {
        private SecretNumber _secretNumber = new SecretNumber();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SecretNumber _guessedNumber)
        {
            return View();
        }
    }
}