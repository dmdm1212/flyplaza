using flyplaza.Areas.Identity.Data;

namespace flyplaza.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<flyplazaUser> GetUsers();

        flyplazaUser GetUser(string id);

        flyplazaUser UpdateUser(flyplazaUser user);
    }
}
