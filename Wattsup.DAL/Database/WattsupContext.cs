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
public class WattsupContext : DbContext
{


    public DbSet<User> Users { get; set; }

    public WattsupContext(DbContextOptions<WattsupContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UserConfig());

        }
    
}
