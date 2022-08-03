using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveywModel.Models;

namespace DojoSurveywModel.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("result")]
    public IActionResult Result(Survey result)
    {
        return View(result);
    }

}
