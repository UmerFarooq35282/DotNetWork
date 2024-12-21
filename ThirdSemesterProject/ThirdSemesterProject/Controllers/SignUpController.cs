using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdSemesterProject.Models;

namespace ThirdSemesterProject.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUpClient()
        {
            return View();
        }

        public ActionResult Captcha()
        {
            CapcthaClass ca = new CapcthaClass();
            return ca;
        }

        public ActionResult CaptchaCheck(string KeyWord)
        {
            string captchaText = Session["captchaString"].ToString();

            if(captchaText == KeyWord)
            {
                TempData["SubmitMsg"] = "Captcha Matched";
            }
            else
            {
                TempData["SubmitMsg"] = "Captcha not Matched Try Again";
            }
            return RedirectToAction("SignUpClient");
        }
    }
}