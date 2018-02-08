using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
