using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.infrastructure.Persistance {
    public class CarWorkshopeDBContext : DbContext 
    {
        //public CarWorkshopeDBContext(DbContextOptions options) : base(options) 
        //{
        //}
        public DbSet<Domain.Entities.CarWorkshop> carWorkshops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=10.0.0.15;Database=CarWorkshopDb;User ID=SA;Password=t3d%69H35CzfD#(b6z47;Encrypt = False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Domain.Entities.CarWorkshop>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}
