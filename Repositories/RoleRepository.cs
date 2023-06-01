using flyplaza.Areas.Identity.Data;
using flyplaza.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace flyplaza.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly flyplazaDbContext _context;
        public RoleRepository(flyplazaDbContext context) 
        {
            _context = context;
        }
        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
