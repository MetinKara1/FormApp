using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer;

namespace FormViewerApp.Controllers
{
    public class HomeController : Controller
    {
        DataBaseContext db = new DataBaseContext();
        public ActionResult Index()
        {
            if (Session["userID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            var formList = new FormGetPost();
            formList.FormList = db.Forms.ToList();
            return View(formList);
        }

        [HttpGet]
        public JsonResult GetData()
        {
            var formList = db.Forms.ToList();
            return Json(formList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Save(Form form)
        {
            if (ModelState.IsValid)
            {
                if (form != null)
                {
                    form.CreatedAt = DateTime.Now;
                    form.CreatedBy = (int)Session["userID"];
                    db.Forms.Add(form);
                    db.SaveChanges();
                }
            }
            else
            {
                ModelState.AddModelError("", "Lütfen tüm eksik alanları doldurun.");
            }
            
            return RedirectToAction("Index","Home");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                ModelState.AddModelError("", "eksik alanları doldurun");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userExist = db.Users.Where(x => x.NickName == user.NickName && x.Password == user.Password).ToList();

            if (userExist.Count > 0)
            {
                Session["userID"] = userExist.First().Id;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            int a = userExist.Count();
            return View();
        }
    }
}