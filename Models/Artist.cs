using System;
using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _artistName;
    private int _id;
    private List<Album> _albums;

    public Artist(string artistName)
    {
      _artistName = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _albums = new List<Album> {};
    }

    public string GetName()
    {
      return _artistName;
    }

    public void SetName(string artistName)
    {
      _artistName = artistName;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<Album> GetAlbums()
    {
      return _albums;
    }
    public void AddAlbum(Album album)
    {
      _albums.Add(album);
    }

  }
}
