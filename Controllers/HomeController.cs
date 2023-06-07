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
        Survey results = new Survey()
        {
          Name = survey.Name,
          Location = survey.Location,
          Language = survey.Language,
          Comment = survey.Comment
        };
        return View(results);
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
