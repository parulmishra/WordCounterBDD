using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
		return View();
    }
	[HttpPost("/count")]
	public ActionResult WordCount()
	{
		RepeatCounter rc = new RepeatCounter(Request.Form["word"] ,Request.Form["sentence"]);
		return View("Index", rc);
	}
  }
}