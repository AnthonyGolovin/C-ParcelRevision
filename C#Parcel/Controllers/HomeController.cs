using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Package.Models;

namespace Package.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Order() { return View(); }

    [Route("/cart")]
    public ActionResult Cart(int length, int width, int height) 
    {
      Parcel newParcel = new Parcel(length, width, height);

      newParcel.Volume();
      newParcel.Price();
      return View(newParcel); 
    }
  }
}