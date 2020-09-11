using System.Collections.Generic;
using System.Linq;
using Starter.DAO;
using Starter.Models;
using Microsoft.AspNetCore.Mvc;

namespace Starter.Controllers
{
    public class Primary : Controller
    {
        private readonly StarterDbContext _context;
        public Primary(StarterDbContext context)
        {
            _context = context;
        }
        // view all bands
        public IActionResult Index()
        {
            return View();
        }
        // view band details and band albums
        public IActionResult BandDetails()
        {
            return View();
        }
        // add band to db
        [HttpPost]
        public IActionResult CreateBand()
        {
            return Content("Band Created");
        }
        // display form to add band to db
        public IActionResult CreateBandForm()
        {
            return View();
        }
        // update existing band in db
        [HttpPost]
        public IActionResult UpdateBand()
        {
            return Content("Band Updated");
        }
        public IActionResult UpdateBandForm()
        {
            return View();
        }
        // add album to db
        [HttpPost]
        public IActionResult CreateAlbum()
        {
            return Content("Album Created");
        }
        // display form to add album to db
        public IActionResult CreateAlbumForm()
        {
            return View();
        }
    }
}