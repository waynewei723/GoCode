using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoCodeBiz.IBiz;
using GoCodeData.Model;

namespace GoCodeWeb.Controllers
{
    public class LoginController : Controller
    {
        IGoUser userService;

        public LoginController(IGoUser userService)
        {
            this.userService = userService;
        }

        //
        // GET: /Login/

        public ActionResult Index()
        {
            GoUser user = new GoUser();
            //user.Name = "123";
            //user.Password = "123";
            //userService.Add(user);

            return View(user);
        }

        [HttpPost]
        public ActionResult Index(GoUser user)
        {
            GoUser userTemp = userService.Get(o => o.Name == user.Name && o.Password == user.Password);
            if (userTemp != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }
    }
}
