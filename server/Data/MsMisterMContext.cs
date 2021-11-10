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

        builder.Entity<MisterM.Models.MsMisterM.MsMisterMComputer>().HasNoKey();
        builder.Entity<MisterM.Models.MsMisterM.User>().HasNoKey();

        this.OnModelBuilding(builder);
    }


    public DbSet<MisterM.Models.MsMisterM.MsMisterMComputer> MsMisterMComputers
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
