using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class AlbumsController : Controller
  {
    [HttpGet("/artists/{artistId}/albums/new")]
    public ActionResult CreateForm(int artistId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      return View(artist);
    }

    [HttpGet("/artists/{artistId}/albums/{albumId}")]
    public ActionResult Details(int artistId, int albumId)
    {
      Album album = Album.Find(albumId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      model.Add("album", album);
      model.Add("artist", artist);
      return View(album);
    }


    // [HttpPost("/albums")]
    // public ActionResult Create()
    // {
    //   Album newAlbum = new Album(
    //   Request.Form["albumTitle"],
    //   Convert.ToInt32(Request.Form["albumPrice"])
    //   );
    //   List<Album> allAlbums = Album.GetAll();
    //   return View("Index", allAlbums);
    // }
  }
}
