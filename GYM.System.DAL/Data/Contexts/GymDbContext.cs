using Gym.System.DAL.Data.Entites;
using GYM.System.DAL.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.DAL.Data.Contexts
{
	public class GymDbContext : DbContext
	{
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
            
        }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			base.OnModelCreating(modelBuilder);
		}

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Equipments> Equipments { get; set; }
        public DbSet<CashPayment> CashPayment { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
		public DbSet<Booking_Subscription> BookingSubscription { get; set; }
		public DbSet<Sessions> Sessions { get; set; }
        public DbSet<Booking_Seessions> BookingSeessions { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Employees> Employees { get; set; }


    }
}
