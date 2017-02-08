using RecordStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchBox1)
        {
            BandContext db = new BandContext();
            {
                if (!String.IsNullOrEmpty(searchBox1)) 
                {
                    ViewBag.FindBand = db.Albums.Where(b => b.AlbumTitle.Contains(searchBox1) || b.Band.BandName.Contains(searchBox1));
                }
                else
                {
                    ViewBag.FindBand = db.Albums.OrderBy(album => album.Band.BandName).ToList();
                }
                return View();
            }
        }
    }
}