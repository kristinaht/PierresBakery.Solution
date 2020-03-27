using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PierresBakery
{
  public class TreatsController: Controller
  {
    private readonly PierresBakeryContext _db;
    public TreatsController(PierresBakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}