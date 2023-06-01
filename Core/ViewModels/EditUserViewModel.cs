using flyplaza.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace flyplaza.Core.ViewModels
{
    public class EditUserViewModel
    {
        public flyplazaUser User { get; set; }
        public IList<SelectListItem> Roles { get; set; }

    }
}
