using flyplaza.Areas.Identity.Data;
using flyplaza.Domain;

namespace flyplaza.Repositories
{
    public class AllReservationsRepository
    {
        private readonly flyplazaDbContext _context;

        public AllReservationsRepository(flyplazaDbContext context)
        {
            _context = context;
        }

        public ICollection<AllTableReservation> GetTableReservations()
        {
            return _context.AllTableReservations.ToList();
        }
        //public ICollection<AllTableReservation> GetAllTableReservations()
        //{
        //    return _context.AllTableReservations.ToList();
        //}
        //public void DeleteAllReservation(AllTableReservation table, ArchiveReservation archive)
        //{
        //    _context.ArchiveReservations.Add(archive);
        //    _context.AllTableReservations.Remove(table);

        //    _context.SaveChanges();
        //}
    }
}
