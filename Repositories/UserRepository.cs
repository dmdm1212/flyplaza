using flyplaza.Areas.Identity.Data;
using flyplaza.Core.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace flyplaza.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly flyplazaDbContext _context;
        public UserRepository(flyplazaDbContext context) 
        {
            _context = context;
        }
        public ICollection<flyplazaUser> GetUsers()
        {
            return _context.Users.ToList();
        }
        public flyplazaUser GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public flyplazaUser UpdateUser(flyplazaUser user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}
