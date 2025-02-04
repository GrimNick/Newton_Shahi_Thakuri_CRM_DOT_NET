using CRM_Newton_2025v2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM_Newton_2025v2.Data;

public class CRM_Newton_2025v2Context : IdentityDbContext<IdentityUser>
{
    public CRM_Newton_2025v2Context(DbContextOptions<CRM_Newton_2025v2Context> options)
        : base(options)
    {
    }

    public DbSet<Complaint> Complaints { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
