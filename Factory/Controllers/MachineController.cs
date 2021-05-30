using System;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController :Controller
  {
    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines
      .Include(machine => machine.JoinEntities)
      .ThenInclude(join => join.Engineer)
      .FirstOrDefault(machine => machine.MachineId ==id);
      return View(thisMachine);
    }
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db =db;
    }
  }
}