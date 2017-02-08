using RecordStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RecordStore.Controllers
{
    public class BandController : Controller
    {
        BandContext db = new BandContext();
        // GET: Band
        public ActionResult Index(string searchBox)
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

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Band band = db.Bands.Find(id);
            if (band == null)
            {
                return HttpNotFound();
            }
            db.Bands.Remove(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
 
            
                
            