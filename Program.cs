using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using flyplaza.Areas.Identity.Data;
using System.ComponentModel;
//using Microsoft.VisualBasic;
using flyplaza.Core;
using flyplaza.Core.Repositories;
using flyplaza.Repositories;
using flyplaza.Models;
using flyplaza.Domain;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("flyplazaDbContextConnection") ?? throw new InvalidOperationException("Connection string 'flyplazaDbContextConnection' not found.");

builder.Services.AddDbContext<flyplazaDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<flyplazaUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<flyplazaDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<ReservationsRepository>();

#region Authorization

AddAuthorizationPolicies(builder.Services);

#endregion

AddScoped();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // IndexHome при готовности

app.MapRazorPages();

app.Run();

void AddAuthorizationPolicies(IServiceCollection services)
{
    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
    });

    builder.Services.AddAuthorization(options =>
    {
		options.AddPolicy(Constants.Policies.RequireAdmin, policy => policy.RequireRole(Constants.Roles.Administrator));
		//options.AddPolicy(Constants.Policies.RequireManager, policy => policy.RequireRole(Constants.Roles.Manager));
	});
}
void AddScoped()
{
    builder.Services.AddScoped<IUserRepository, UserRepository>();
    builder.Services.AddScoped<IRoleRepository, RoleRepository>();
    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    builder.Services.AddScoped<ReservationsRepository, ReservationsRepository>();
    builder.Services.AddScoped<AllReservationsRepository, AllReservationsRepository>();
    builder.Services.AddScoped<ArchiveReservationsRepository, ArchiveReservationsRepository>();
}