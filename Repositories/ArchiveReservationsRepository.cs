using flyplaza.Areas.Identity.Data;
using flyplaza.Domain;

namespace flyplaza.Repositories
{
    public class ArchiveReservationsRepository
    {
        private readonly flyplazaDbContext _context;

        public ArchiveReservationsRepository(flyplazaDbContext context)
        {
            _context = context;
        }
        public ICollection<ArchiveReservation> GetArchiveReservations()
        {
            return _context.ArchiveReservations.ToList();
        }
    }
}
