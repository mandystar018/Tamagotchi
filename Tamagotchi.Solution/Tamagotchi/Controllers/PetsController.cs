using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/Pets")]
    public ActionResult Index()
    {
      return View();
    }
    // [HttpPost("/pets/game")]
    // public ActionResult Game()
    // {
    //   Pet newPet = new Pet();
    //   return View(newPet);
    // }
  }
}