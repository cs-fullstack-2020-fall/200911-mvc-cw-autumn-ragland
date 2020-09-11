using System.Collections.Generic;
using System.Linq;
using Starter.DAO;
using Starter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return View(_context);
        }
        // view band details and band albums
        public IActionResult BandDetails(int id)
        {
            BandModel foundBand = _context.bands.Include(band => band.albums).FirstOrDefault(band => band.id == id);
            return View(foundBand);
        }
        // add band to db
        [HttpPost]
        public IActionResult CreateBand(BandModel newBand)
        {
            _context.bands.Add(newBand);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // display form to add band to db
        public IActionResult CreateBandForm()
        {
            return View();
        }
        // update existing band in db
        [HttpPost]
        public IActionResult UpdateBand(BandModel updateBand)
        {
            BandModel foundBand = _context.bands.FirstOrDefault(band => band.id == updateBand.id);
            foundBand.bandName = updateBand.bandName;
            foundBand.yearFormed = updateBand.yearFormed;
            foundBand.contactEmail = updateBand.bandName;
            foundBand.isActive = updateBand.isActive;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateBandForm(int id)
        {
            BandModel foundBand = _context.bands.FirstOrDefault(band => band.id == id);
            return View(foundBand);
        }
        // add album to db
        [HttpPost]
        public IActionResult CreateAlbum(AlbumModel newAlbum)
        {
            BandModel foundBand = _context.bands.Include(band => band.albums).FirstOrDefault(band => band.id == newAlbum.bandID);
            foundBand.albums.Add(newAlbum);
            _context.albums.Add(newAlbum);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // display form to add album to db
        public IActionResult CreateAlbumForm()
        {
            return View();
        }
    }
}