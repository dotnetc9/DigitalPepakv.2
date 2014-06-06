using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PepakDigital;

namespace PepakDigital.Controllers
{
    public class ParamasastraUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();

        // GET: /ParamasastraUser/
        public ActionResult Index()
        {
            var paramasastra = db.Paramasastra.Include(p => p.Kategori);
            return View(paramasastra.ToList());
        }

       
    }
}
