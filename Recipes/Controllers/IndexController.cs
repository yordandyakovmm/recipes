using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Recipes.Controllers
{
    

    public class IndexController : BaseController
    {

        
        public ActionResult Index(string studentId, string seond)
        {
            var contex = new DAL.RecipeDBContext();
            var count = contex.Users.Count();
            return View();


        }

        [Route("{category}/{item}")]
        [Route("recipes/{category}/{item}")]
        public ActionResult Spliter(string category, string item)
        {
            var contex = new DAL.RecipeDBContext();
            var count = contex.Users.Count();
            return View("Index");


        }
    }
}