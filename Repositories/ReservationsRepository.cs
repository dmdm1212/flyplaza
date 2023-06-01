using flyplaza.Areas.Identity.Data;
using flyplaza.Domain;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace flyplaza.Repositories
{
    public class ReservationsRepository
    {
        private readonly flyplazaDbContext _context;

        public ReservationsRepository(flyplazaDbContext context) 
        {
            _context = context;
        }
        public ICollection<AllTableReservation> GetTableReservations()
        {
            return _context.AllTableReservations.ToList();
        }
        public void AddReservation(AllTableReservation table, ArchiveReservation archive)
        {
            _context.AllTableReservations.Add(table);
            _context.ArchiveReservations.Add(archive);

            _context.SaveChanges();
        }

        public void DeleteReservation(AllTableReservation table)
        {
            _context.AllTableReservations.Remove(table);

            _context.SaveChanges();
        }
    }
}
