using System;
using Factory.Models;
using System.Collections.Generic;
using System.linq;
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
  }
}