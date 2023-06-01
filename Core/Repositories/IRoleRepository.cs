using flyplaza.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace flyplaza.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
