using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresBakery.Controllers
{
  [Authorize]
  public class TreatsController: Controller
  {
    private readonly PierresBakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public TreatsController(PierresBakeryContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }

    [Authorize]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

   
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat =>treat.Flavors)  
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Description");
      return View(thisTreat);
    }

      [HttpPost]
    public ActionResult Edit(Treat treat, int FlavorId)
    {
      if (FlavorId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { TreatId = treat.TreatId, FlavorId = FlavorId });
      }
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
} 