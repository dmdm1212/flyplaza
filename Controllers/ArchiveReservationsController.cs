using flyplaza.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace flyplaza.Controllers
{
    public class ArchiveReservationsController : Controller
    {
        private readonly ArchiveReservationsRepository _archiveRepository;

        public ArchiveReservationsController(ArchiveReservationsRepository archiveRepository)
        {
            _archiveRepository = archiveRepository;
        }

        public IActionResult Index()
        {
            var ArchiveReservations = _archiveRepository.GetArchiveReservations();
            return View(ArchiveReservations);
        }
    }
}
