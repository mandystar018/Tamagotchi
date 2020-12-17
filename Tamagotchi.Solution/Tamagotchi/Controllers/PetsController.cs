using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpPost("/pets/game")]
    public ActionResult Game(string name)
    {
      Pet newPet = new Pet(name);
      return View(newPet);
    }

    [HttpPost("/pets/feed")]
    public ActionResult Game()
    {
      newPet.Feed();
    }
  }
}