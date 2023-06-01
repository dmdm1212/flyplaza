using flyplaza.Areas.Identity.Data;
using flyplaza.Domain;
using flyplaza.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace flyplaza.Areas.Identity.Data;

public class flyplazaDbContext : IdentityDbContext<flyplazaUser>
{
    public flyplazaDbContext(DbContextOptions<flyplazaDbContext> options)
        : base(options)
    {
    }
    public DbSet<TableReservation> TableReservations { get; set; }
    public DbSet<AllTableReservation> AllTableReservations { get; set; }
    public DbSet<ArchiveReservation> ArchiveReservations { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new flyplazaUserEntityConfiguration());

    }
}

internal class flyplazaUserEntityConfiguration : IEntityTypeConfiguration<flyplazaUser>
{
    public void Configure(EntityTypeBuilder<flyplazaUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}