using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using areaapp1.Models;
using System.Web.Security;

namespace areaapp1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string returnUrl)
        {

            LoginModel loginModel = new LoginModel()
            {
                ReturnUrl = returnUrl,
            };
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include ="UserName,Password,ReturnUrl")] LoginModel user)
        {
            if(ModelState.IsValid)
            {
                if(user.UserName == "mehdi" && user.Password =="123")
                {
                   FormsAuthentication.SetAuthCookie(user.UserName,false);
                    return Redirect(user.ReturnUrl);
                }
                return View();
            }
            string eifc = "eiwnip4pv";
            return View();
        }
    }
}