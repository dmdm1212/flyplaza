using flyplaza.Domain;
using flyplaza.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace flyplaza.Controllers
{
    public class AllTableReservationsController : Controller
    {
        private readonly AllReservationsRepository _allReservationsRepository;
        public AllTableReservationsController(AllReservationsRepository allReservationsRepository)
        {
            _allReservationsRepository = allReservationsRepository;
        }
        public IActionResult AllReservations()
        {
            var AllReservations = _allReservationsRepository.GetTableReservations();
            return View(AllReservations);
        }
        //[HttpPost]
        //public IActionResult DeleteAllReservation(Guid id/*, Guid id2, ArchiveReservation table*/)
        //{
        //    _allReservationsRepository.DeleteAllReservation(new AllTableReservation { Id = id }/*, new TableReservation { Id = id2}, table*/);
        //    return RedirectToAction("AllReservations");
        //}
    }
}
