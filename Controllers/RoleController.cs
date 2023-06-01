using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Constants = flyplaza.Core.Constants;

namespace flyplaza.Controllers
{
    public class RoleController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		[Authorize(Policy = "RequireAdmin")]
		public IActionResult Admin()
		{
			return View();
		}
	}
}
