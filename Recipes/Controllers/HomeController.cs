using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Recipes.Controllers
{
    

    public class HomeController : BaseController
    {

        
        public ActionResult Index()
        {
            var contex = new DAL.RecipeDBContext();
            var count = contex.Users.Count();
            return View();


        }
    }
}