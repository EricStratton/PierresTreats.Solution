using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Treats.Models;

namespace Treats.Controllers
{
    public class HomeController : Controller
    {
        private readonly TreatsContext _db;

        public HomeController(TreatsContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            var flavors = _db.Flavors.ToList();
            var treats = _db.Treats.ToList();
            Dictionary<string, object> model = new Dictionary<string, object> { };
            model.Add("flavor", flavors);
            model.Add("treat", treats);
            return View(model);
        }

    }       
}
