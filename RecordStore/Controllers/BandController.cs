using RecordStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordStore.Controllers
{
    public class BandController : Controller
    {
        BandContext db = new BandContext();
        // GET: Band
        public ActionResult Index()
        {
            ViewBag.AllBands = db.Bands.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Band band)
        {
            using (var db = new BandContext())
            {
                
                db.Bands.Add(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}