using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            var contex = new DAL.RecipeDBContext();
            var count = contex.Forms.Count();
            return View();
            
            
        }

        






    }
}