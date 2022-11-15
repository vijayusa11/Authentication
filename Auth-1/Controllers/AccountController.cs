using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Auth_1.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        WebAppEntities db = new WebAppEntities();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(tbl_User user)
        {

            var isUserExist = db.tbl_User.Where(x => x.UserName == user.UserName && x.Password == user.Password).Count();
            if (isUserExist != 0)
            {
                FormsAuthentication.SetAuthCookie(user.UserName,false);

                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Invalid User";
                return View();
            }
            

            //var isUserExist = db.tbl_User.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            //if (isUserExist != null)
            //{
            //    return RedirectToAction("Index");
            //}
            //else
            //{

            //}
            //return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View();
        }
    }
}