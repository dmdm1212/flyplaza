using flyplaza.Domain;
using flyplaza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Diagnostics;
using flyplaza.Repositories;

namespace flyplaza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReservationsRepository _reservationsRepository;
        public HomeController(ReservationsRepository reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexHome()
        {
            return View();
        }

        public IActionResult MyReservations()
        {
            var reservations = _reservationsRepository.GetTableReservations();
            return View(reservations);
        }
        [HttpPost]
        public IActionResult AddReservation(AllTableReservation table, ArchiveReservation archive)
        {
            if (ModelState.IsValid)
            {
                _reservationsRepository.AddReservation(table, archive);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteReservation(Guid id)
        {
            _reservationsRepository.DeleteReservation(new AllTableReservation { Id = id});
            return RedirectToAction("MyReservations");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}