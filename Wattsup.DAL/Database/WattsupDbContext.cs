using Microsoft.EntityFrameworkCore;
using Wattsup.DAL.Database.Configurations;
using Wattsup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.DAL.Database;
public class WattsupDbContext : DbContext
{


    public DbSet<User> Users { get; set; }
    public DbSet<Store> Stores { get; set; }

	public WattsupDbContext(DbContextOptions<WattsupDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new StoreConfig());

	}
    
}
