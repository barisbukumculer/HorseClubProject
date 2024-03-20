using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HorseClubProject.Models.Entity;

namespace HorseClubProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        HorseDbEntities db=new HorseDbEntities();
        public ActionResult Index()
        {
            var values = db.TBLBILGI.ToList();
            return View(values);
        }
    }
}