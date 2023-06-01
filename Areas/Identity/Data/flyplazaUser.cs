using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace flyplaza.Areas.Identity.Data;

// Add profile data for application users by adding properties to the flyplazaUser class
public class flyplazaUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public class flyplazaRole : IdentityRole
{

}