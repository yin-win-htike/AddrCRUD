using AddrCRUD.Data;
using AddrCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddrCRUD.Controllers
{
    public class AddrController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AddrController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Addr> objCatlist = _context.Addrs;
            return View(objCatlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Addr addrobj)
        {
            if (ModelState.IsValid)
            {
                var cdate=DateTime.Now;
                addrobj.RecordCreatedOn = cdate;

                _context.Addrs.Add(addrobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(addrobj);
        }

    }
}
