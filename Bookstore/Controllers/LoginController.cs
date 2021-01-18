using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Repository;
using Bookstore.POCO;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(Login objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (RestaurantDBEntities db = new RestaurantDBEntities())
        //        {
        //            var id = 0;
        //            if (int.TryParse(objUser.Username, out id))
        //            {
        //                var obj = db.Workers.Where(a => a.Id == id && a.Password.Equals(objUser.Password)).FirstOrDefault();
        //                if (obj != null)
        //                {
        //                    WorkerModel.Id = obj.Id;
        //                    WorkerModel.Name = obj.Name;
        //                    WorkerModel.Surname = obj.Surname;
        //                    WorkerModel.Position = (int)obj.Postion.Access;

        //                    return RedirectToAction("Index");
        //                }
        //            }
        //            else
        //                ViewBag.Failedcount = "Incorect data!";

        //        }
        //        ViewBag.NotValidUser = "User Does not Exists!";
        //    }
        //    else
        //        ViewBag.Failedcount = "Incorect data!";

        //    return View(objUser);
        //}
    }
}
