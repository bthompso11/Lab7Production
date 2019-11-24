using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Linq;
using System.Web;


namespace FanSite.Controllers
{

    //Added constructor to use in testing 
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository r)
        {
            repo = r;
        }

       //Changed from ViewResult to IActionResult. --LAB 6 EDIT
        public IActionResult Index()
        {
            return View();
        }

       // //Created new controller and view to have controller return View --LAB6 EDIT
       // public String TestStringView()
       // {
       //     return "From theTest String View";
       // }

       // //Created a new view for to Test this Action Result -- LAB6 EDIT
       //public ActionResult TestActionResultView()
       // {
       //     return Redirect("Index");
       // }

       // //Created New View to reroute  -- LAB6 EDIT
       // public PartialViewResult TestPartialViewResult()
       // {
       //     return PartialView("TestPartialView");
       // }

       // //Created new view and controller to test Content -- LAB6 EDIT
       // public ContentResult TestContentResult()
       // {
       //     return Content("<h1>this is From the controller view</h1>", "text/html");
       // }
        

        [HttpGet]
        public ViewResult Stories()
        {
            return View("Stories");
        }

        //Overloaded Stories 
        [HttpPost]
        public ViewResult Stories(UserStory userstories)
        {            
            repo.AddResponse(userstories);
            repo.SortStories();
            return View("Submitted", userstories);
        }

        public ViewResult History()
        {
            return View("History");
        }

        public ViewResult Sources()
        {
            return View("Sources");
        }

        public ViewResult ListStories()
        {
            
            return View(repo.Stories);
        }

        public ViewResult BooksAndPrint()
        {
            repo.SortBooksAndPrintList();
            return View(repo.PrintMedia);
        }

        public ViewResult AddComment()
        {
            ViewBag.Test = "Testing View Bag for excercise";
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddComment(string name, string comment)
        {      
            ViewBag.Test = "Testing View Bag for excercise";

          
            repo.AddComment(new UserComments()
            {
                Name = name,
                Comment = comment
            });

            repo.AddCommentToStory(comment);           
          
            return RedirectToAction("Stories");
        }    
                

        public ViewResult OnlineResources()
        {
            return View(repo.OnlineResources);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
