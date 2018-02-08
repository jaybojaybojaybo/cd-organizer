using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class ArtistsController : Controller
  {

    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult CreateArtists()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create()
    {
      Console.WriteLine("new artist went through");
      Artist newArtist = new Artist(Request.Form["artistName"]);
      List<Artist> allArtists = Artist.GetAll();
      return View("Index", allArtists);
    }

    [HttpGet("artists/{id}")]
    public ActionResult Details(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Album> artistAlbums = selectedArtist.GetAlbums();
      model.Add("artist", selectedArtist);
      model.Add("albums", artistAlbums);
      return View(model);
    }

    [HttpPost("/albums")]
    public ActionResult CreateAlbum()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(Int32.Parse(Request.Form["artist-name"]));
      string albumTitle = Request.Form["albumTitle"];
      int albumPrice = Convert.ToInt32(Request.Form["albumPrice"]);
      Album newAlbum = new Album(albumTitle, albumPrice);
      foundArtist.AddAlbum(newAlbum);
      List<Album> artistAlbums = foundArtist.GetAlbums();
      model.Add("albums", artistAlbums);
      model.Add("artist", foundArtist);
      return View("Details", model);
    }
  }
}
