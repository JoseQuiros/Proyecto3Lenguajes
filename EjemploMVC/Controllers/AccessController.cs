using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EjemploMVC.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {/*
                using (cursomvcEntities db = new cursomvcEntities())
                {
                    var lst = from d in db.user
                              where d.email == user && d.password == password && d.idState == 1
                              select d;
                    if (lst.Count() > 0)
                    {
                        user oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario invalido :(");
                    }
                }*/

                return Content("Usuario invalido :(");

            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :( " + ex.Message);
            }

        }
    }
}