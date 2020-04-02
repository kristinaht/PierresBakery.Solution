using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresBakery.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierresBakeryContext _db;

    public FlavorsController(PierresBakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
      _db.Flavors.Add(flavor);
      if(TreatId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() {TreatId = TreatId, FlavorId = flavor.FlavorId});
      }
       _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}