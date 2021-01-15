using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Treats.Controllers
{
  public class OrdersController : Controller
  {
    private readonly TreatsContext _db;
    
    public OrdersController(TreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Order> model = _db.Orders.ToList();
      return View(model);
    }
  }
}