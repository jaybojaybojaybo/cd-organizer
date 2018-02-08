using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/albums/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/albums/new")]
    public ActionResult Create()
    {
      Album newAlbum = new Album(
      Request.Form["albumTitle"],
      Convert.ToInt32(Request.Form["albumPrice"])
      );
      List<Album> allAlbums = Album.GetAll();
      return View("Index", allAlbums);
    }
  }
}
