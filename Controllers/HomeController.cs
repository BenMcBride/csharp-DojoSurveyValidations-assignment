using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidations.Models;

namespace DojoSurveyValidations.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      return View("Index");
    }

    [HttpPost("result")]
    public IActionResult Result(Survey survey)
    {
      if (ModelState.IsValid)
      {
        ViewBag.Name = survey.Name;
        ViewBag.Location = survey.Location;
        ViewBag.Language = survey.Language;
        ViewBag.Comment = survey.Comment;
        return View();
      }
      else
      {
        return View("Index");
      }
    }

    [HttpGet("result")]
    public RedirectToActionResult Redirect()
    {
      return RedirectToAction("Index");
    }
  }
}
