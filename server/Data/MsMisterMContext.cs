using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using MisterM.Models.MsMisterM;

namespace MisterM.Data
{
  public partial class MsMisterMContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public MsMisterMContext(DbContextOptions<MsMisterMContext> options):base(options)
    {
    }

    public MsMisterMContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<MisterM.Models.MsMisterM.Computer>();
        builder.Entity<MisterM.Models.MsMisterM.User>().HasNoKey();


        builder.Entity<MisterM.Models.MsMisterM.Computer>()
              .Property(p => p.temperature)
              .HasPrecision(24, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<MisterM.Models.MsMisterM.Computer> Computers
    {
      get;
      set;
    }

    public DbSet<MisterM.Models.MsMisterM.User> Users
    {
      get;
      set;
    }
  }
}
